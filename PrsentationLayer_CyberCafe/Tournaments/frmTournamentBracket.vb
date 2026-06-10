Imports BusinessLayer_CyberCafe
Imports Guna.UI2.WinForms

Public Class frmTournamentBracket

    Private _tournamentID As Integer
    Private _tournamentName As String

    ' Bracket runtime panels
    Private pnlBracketScrollContainer As Panel
    Private pnlBracketCanvas As Panel
    Private matchControls As New Dictionary(Of String, Control)

    ' Bracket Layout Settings
    Private ReadOnly _cardWidth As Integer = 200
    Private ReadOnly _cardHeight As Integer = 60
    Private _horizontalGap As Integer = 140
    Private _verticalGap As Integer = 30
    Private ReadOnly _startX As Integer = 40
    Private ReadOnly _startY As Integer = 40

    Public Sub New(tournamentID As Integer, tournamentName As String)

        InitializeComponent()
        _tournamentID = tournamentID
        _tournamentName = tournamentName

    End Sub

    Private Sub frmTournamentBracket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblBracketTitle.Text = $"{_tournamentName.ToUpper()} — TOURNAMENT BRACKET"
        InitializeBracketPanels()
        LoadTournamentMatches()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


    Private Sub InitializeBracketPanels()

        pnlBracketScrollContainer = New Panel()
        pnlBracketScrollContainer.Dock = DockStyle.Fill
        pnlBracketScrollContainer.AutoScroll = False
        pnlBracketScrollContainer.BackColor = Color.Transparent
        pnlBracketCard.Controls.Add(pnlBracketScrollContainer)

        pnlBracketCanvas = New Panel()
        pnlBracketCanvas.Location = New Point(0, 0)
        pnlBracketCanvas.BackColor = Color.Transparent
        pnlBracketCanvas.Dock = DockStyle.Fill
        pnlBracketScrollContainer.Controls.Add(pnlBracketCanvas)

        AddHandler pnlBracketScrollContainer.Resize, Sub(s, e)
                                                         If pnlBracketScrollContainer.Visible AndAlso pnlBracketScrollContainer.Width > 0 Then
                                                             LoadTournamentMatches()
                                                         End If
                                                     End Sub

        EnableDoubleBuffering(pnlBracketCanvas)

        AddHandler pnlBracketCanvas.Paint, AddressOf DrawConnectors

    End Sub

    ' ================================================
    ' LOAD TOURNAMENT MATCHES & BUILD BRACKET
    ' ================================================

    Public Sub LoadTournamentMatches()

        Try

            pnlBracketCanvas.Controls.Clear()
            matchControls.Clear()

            Dim dtMatches As DataTable = TournamentMatchesServices.GetTournamentMatches(_tournamentID)

            If dtMatches Is Nothing OrElse dtMatches.Rows.Count = 0 Then

                lblBracketPlaceholder.Visible = True
                pnlBracketScrollContainer.Visible = False
                Return

            End If

            lblBracketPlaceholder.Visible = False
            pnlBracketScrollContainer.Visible = True

            BuildBracket(dtMatches)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Bracket Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BuildBracket(dtMatches As DataTable)


        Dim maxRound As Integer = dtMatches.AsEnumerable().Max(Function(r) Convert.ToInt32(r("RoundNumber")))
        Dim matchesByRound As New Dictionary(Of Integer, List(Of DataRow))

        For Each row As DataRow In dtMatches.Rows

            Dim r As Integer = Convert.ToInt32(row("RoundNumber"))

            If Not matchesByRound.ContainsKey(r) Then

                matchesByRound(r) = New List(Of DataRow)

            End If

            matchesByRound(r).Add(row)

        Next

        For Each r In matchesByRound.Keys.ToList()

            matchesByRound(r) = matchesByRound(r).OrderBy(Function(x) Convert.ToInt32(x("MatchOrder"))).ToList()

        Next

        Dim firstRoundCount As Integer = matchesByRound(1).Count
        Dim totalRounds As Integer = Convert.ToInt32(Math.Ceiling(Math.Log(firstRoundCount * 2, 2)))

        Dim leftSideCount As Integer = firstRoundCount \ 2
        Dim rightSideCount As Integer = firstRoundCount - leftSideCount

        Dim totalColumns As Integer = (totalRounds * 2) - 1
        Dim availableWidth As Integer = pnlBracketScrollContainer.ClientSize.Width
        Dim availableHeight As Integer = pnlBracketScrollContainer.ClientSize.Height

        Dim maxCardsVertically As Integer = Math.Max(leftSideCount, rightSideCount)

        If maxCardsVertically > 1 Then
            _verticalGap = (availableHeight - (2 * _startY) - (maxCardsVertically * _cardHeight)) \ (maxCardsVertically - 1)
        Else
            _verticalGap = 30
        End If

        If totalColumns > 1 Then
            _horizontalGap = (availableWidth - (2 * _startX) - (totalColumns * _cardWidth)) \ (totalColumns - 1)
        Else
            _horizontalGap = 140
        End If

        If _verticalGap < 5 Then _verticalGap = 5
        If _horizontalGap < 20 Then _horizontalGap = 20

        Dim canvasWidth As Integer = availableWidth
        Dim canvasHeight As Integer = availableHeight


        For round As Integer = 1 To maxRound

            If Not matchesByRound.ContainsKey(round) Then
                Continue For
            End If

            Dim roundMatches = matchesByRound(round)

            For i As Integer = 0 To roundMatches.Count - 1

                Dim row = roundMatches(i)
                Dim order As Integer = Convert.ToInt32(row("MatchOrder"))

                Dim card As Guna2Panel = CreateMatchCard(
                    Convert.ToInt32(row("MatchID")),
                    row("Player1Name").ToString(),
                    row("Player2Name").ToString(),
                    If(row("Player1Score") Is DBNull.Value, "", row("Player1Score").ToString()),
                    If(row("Player2Score") Is DBNull.Value, "", row("Player2Score").ToString()),
                    row("WinnerPlayerID"),
                    row("Player1ID"),
                    row("Player2ID"),
                    Convert.ToByte(row("MatchStatus"))
                )

                Dim x As Integer = 0
                Dim y As Integer = 0

                If round = 1 Then

                    If i < leftSideCount Then
                        ' LEFT SIDE
                        x = _startX
                        y = _startY + (i * (_cardHeight + _verticalGap))
                    Else
                        ' RIGHT SIDE
                        x = canvasWidth - _cardWidth - _startX
                        y = _startY + ((i - leftSideCount) * (_cardHeight + _verticalGap))
                    End If

                Else

                    Dim parent1Key = $"{round - 1}_{(order * 2) - 1}"
                    Dim parent2Key = $"{round - 1}_{(order * 2)}"

                    Dim parent1 As Control = Nothing
                    Dim parent2 As Control = Nothing

                    If matchControls.ContainsKey(parent1Key) Then
                        parent1 = matchControls(parent1Key)
                    End If

                    If matchControls.ContainsKey(parent2Key) Then
                        parent2 = matchControls(parent2Key)
                    End If

                    If parent1 IsNot Nothing AndAlso parent2 IsNot Nothing Then

                        y = ((parent1.Top + parent2.Top) \ 2)
                        Dim isLeftSide As Boolean = parent1.Left < (canvasWidth \ 2)

                        If round = totalRounds Then
                            x = (canvasWidth - _cardWidth) \ 2
                        ElseIf isLeftSide Then
                            x = parent1.Left + _cardWidth + _horizontalGap
                        Else
                            x = parent1.Left - _cardWidth - _horizontalGap
                        End If

                    End If

                End If

                card.Location = New Point(x, y)
                pnlBracketCanvas.Controls.Add(card)
                matchControls($"{round}_{order}") = card

            Next

        Next

        pnlBracketCanvas.Size = New Size(canvasWidth, canvasHeight)
        pnlBracketCanvas.Invalidate()

    End Sub

    ' ================================================
    ' DRAW CONNECTOR LINES BETWEEN ROUNDS
    ' ================================================

    Private Sub DrawConnectors(sender As Object, e As PaintEventArgs)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim Gap As Integer = _horizontalGap

        Using pen As New Pen(Color.FromArgb(48, 54, 61), 2)

            Dim controlsCopy As KeyValuePair(Of String, Control)()
            SyncLock matchControls
                controlsCopy = matchControls.ToArray()
            End SyncLock

            For Each kvp In controlsCopy

                Dim key As String = kvp.Key
                Dim parts = key.Split("_"c)
                Dim r As Integer = Integer.Parse(parts(0))
                Dim order As Integer = Integer.Parse(parts(1))

                If r > 1 Then

                    Dim parentKey1 = $"{r - 1}_{2 * order - 1}"
                    Dim parentKey2 = $"{r - 1}_{2 * order}"

                    Dim p1Ctrl As Control = Nothing
                    Dim p2Ctrl As Control = Nothing
                    For Each item In controlsCopy
                        If item.Key = parentKey1 Then p1Ctrl = item.Value
                        If item.Key = parentKey2 Then p2Ctrl = item.Value
                    Next

                    Dim childCtrl = kvp.Value
                    Dim childCenterY = childCtrl.Top + childCtrl.Height \ 2
                    Dim parentRef As Control = If(p1Ctrl IsNot Nothing, p1Ctrl, p2Ctrl)
                    If parentRef Is Nothing Then Continue For

                    If parentRef.Left < childCtrl.Left Then
                        ' LEFT SIDE — connectors go right
                        Dim midX As Integer = childCtrl.Left - Gap \ 2
                        g.DrawLine(pen, midX, childCenterY, childCtrl.Left, childCenterY)
                        If p1Ctrl IsNot Nothing Then
                            Dim cy = p1Ctrl.Top + p1Ctrl.Height \ 2
                            g.DrawLine(pen, p1Ctrl.Right, cy, midX, cy)
                            g.DrawLine(pen, midX, cy, midX, childCenterY)
                        End If
                        If p2Ctrl IsNot Nothing Then
                            Dim cy = p2Ctrl.Top + p2Ctrl.Height \ 2
                            g.DrawLine(pen, p2Ctrl.Right, cy, midX, cy)
                            g.DrawLine(pen, midX, cy, midX, childCenterY)
                        End If
                    Else
                        ' RIGHT SIDE — connectors go left
                        Dim midX As Integer = childCtrl.Right + Gap \ 2
                        g.DrawLine(pen, childCtrl.Right, childCenterY, midX, childCenterY)
                        If p1Ctrl IsNot Nothing Then
                            Dim cy = p1Ctrl.Top + p1Ctrl.Height \ 2
                            g.DrawLine(pen, p1Ctrl.Left, cy, midX, cy)
                            g.DrawLine(pen, midX, cy, midX, childCenterY)
                        End If
                        If p2Ctrl IsNot Nothing Then
                            Dim cy = p2Ctrl.Top + p2Ctrl.Height \ 2
                            g.DrawLine(pen, p2Ctrl.Left, cy, midX, cy)
                            g.DrawLine(pen, midX, cy, midX, childCenterY)
                        End If
                    End If

                End If

            Next

        End Using

    End Sub

    ' ================================================
    ' CREATE MATCH CARD
    ' ================================================

    Private Function CreateMatchCard(matchID As Integer, player1Name As String, player2Name As String,
                                     player1Score As String, player2Score As String, winnerPlayerID As Object,
                                     player1ID As Object, player2ID As Object, status As Byte) As Guna2Panel

        Dim pnlCard As New Guna2Panel()
        pnlCard.Size = New Size(200, 60)
        pnlCard.BorderRadius = 8
        pnlCard.BorderThickness = 1
        pnlCard.FillColor = Color.FromArgb(22, 27, 34)
        pnlCard.BorderColor = Color.FromArgb(48, 54, 61)
        pnlCard.Cursor = Cursors.Hand

        ' Hover styling
        AddHandler pnlCard.MouseEnter, Sub(s, ev)
                                           pnlCard.BorderColor = Color.FromArgb(0, 242, 254)
                                           pnlCard.FillColor = Color.FromArgb(28, 33, 40)
                                       End Sub
        AddHandler pnlCard.MouseLeave, Sub(s, ev)
                                           pnlCard.BorderColor = Color.FromArgb(48, 54, 61)
                                           pnlCard.FillColor = Color.FromArgb(22, 27, 34)
                                       End Sub

        Dim pnlScoreCol As New Guna2Panel()
        pnlScoreCol.Size = New Size(35, 60)
        pnlScoreCol.Location = New Point(165, 0)
        pnlScoreCol.FillColor = Color.FromArgb(33, 38, 45)
        pnlScoreCol.BorderColor = Color.FromArgb(48, 54, 61)
        pnlScoreCol.BorderThickness = 0
        pnlScoreCol.CustomizableEdges.TopLeft = False
        pnlScoreCol.CustomizableEdges.BottomLeft = False
        pnlScoreCol.CustomizableEdges.TopRight = True
        pnlScoreCol.CustomizableEdges.BottomRight = True
        pnlCard.Controls.Add(pnlScoreCol)

        Dim isFinished As Boolean = (status = 2)
        Dim p1Winner As Boolean = False
        Dim p2Winner As Boolean = False

        If isFinished AndAlso winnerPlayerID IsNot DBNull.Value AndAlso winnerPlayerID IsNot Nothing Then
            Dim winID As Integer = Convert.ToInt32(winnerPlayerID)
            If player1ID IsNot DBNull.Value AndAlso Convert.ToInt32(player1ID) = winID Then
                p1Winner = True
            ElseIf player2ID IsNot DBNull.Value AndAlso Convert.ToInt32(player2ID) = winID Then
                p2Winner = True
            End If
        End If

        Dim lblP1 As New Label()
        lblP1.Text = If(String.IsNullOrEmpty(player1Name), "TBD", player1Name)
        lblP1.Font = New Font("Segoe UI Semibold", 9.0!)
        lblP1.ForeColor = If(p1Winner, Color.FromArgb(0, 255, 157), If(p2Winner, Color.FromArgb(139, 148, 158), Color.White))
        lblP1.Location = New Point(8, 8)
        lblP1.Size = New Size(150, 18)
        lblP1.AutoEllipsis = True
        lblP1.BackColor = Color.Transparent
        pnlCard.Controls.Add(lblP1)

        Dim lblP2 As New Label()
        lblP2.Text = If(String.IsNullOrEmpty(player2Name), "TBD", player2Name)
        lblP2.Font = New Font("Segoe UI Semibold", 9.0!)
        lblP2.ForeColor = If(p2Winner, Color.FromArgb(0, 255, 157), If(p1Winner, Color.FromArgb(139, 148, 158), Color.White))
        lblP2.Location = New Point(8, 32)
        lblP2.Size = New Size(150, 18)
        lblP2.AutoEllipsis = True
        lblP2.BackColor = Color.Transparent
        pnlCard.Controls.Add(lblP2)

        Dim lblS1 As New Label()
        lblS1.Text = If(String.IsNullOrEmpty(player1Score), "-", player1Score)
        lblS1.Font = New Font("Segoe UI Bold", 9.0!)
        lblS1.ForeColor = If(p1Winner, Color.FromArgb(0, 255, 157), If(p2Winner, Color.FromArgb(139, 148, 158), Color.White))
        lblS1.Size = New Size(35, 18)
        lblS1.Location = New Point(0, 8)
        lblS1.TextAlign = ContentAlignment.MiddleCenter
        lblS1.BackColor = Color.Transparent

        Dim lblS2 As New Label()
        lblS2.Text = If(String.IsNullOrEmpty(player2Score), "-", player2Score)
        lblS2.Font = New Font("Segoe UI Bold", 9.0!)
        lblS2.ForeColor = If(p2Winner, Color.FromArgb(0, 255, 157), If(p1Winner, Color.FromArgb(139, 148, 158), Color.White))
        lblS2.Size = New Size(35, 18)
        lblS2.Location = New Point(0, 32)
        lblS2.TextAlign = ContentAlignment.MiddleCenter
        lblS2.BackColor = Color.Transparent

        ' Play button for upcoming matches with both players assigned
        Dim showPlayButton As Boolean = (status = 0) AndAlso
            (player1ID IsNot DBNull.Value AndAlso player1ID IsNot Nothing AndAlso Convert.ToInt32(player1ID) > 0) AndAlso
            (player2ID IsNot DBNull.Value AndAlso player2ID IsNot Nothing AndAlso Convert.ToInt32(player2ID) > 0)

        If showPlayButton Then
            Dim btnPlay As New Guna2Button()
            btnPlay.Size = New Size(35, 60)
            btnPlay.Location = New Point(0, 0)
            btnPlay.Text = "▶"
            btnPlay.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            btnPlay.FillColor = Color.FromArgb(0, 242, 254)
            btnPlay.ForeColor = Color.Black
            btnPlay.Cursor = Cursors.Hand
            btnPlay.BorderRadius = 0
            btnPlay.CustomizableEdges.TopLeft = False
            btnPlay.CustomizableEdges.BottomLeft = False
            btnPlay.CustomizableEdges.TopRight = True
            btnPlay.CustomizableEdges.BottomRight = True

            AddHandler btnPlay.Click, Sub(s, ev)
                                          Dim resultForm As New frmMatchResult(matchID)
                                          If resultForm.ShowDialog() = DialogResult.OK Then
                                              LoadTournamentMatches()
                                          End If
                                      End Sub
            pnlScoreCol.Controls.Add(btnPlay)
        Else
            pnlScoreCol.Controls.Add(lblS1)
            pnlScoreCol.Controls.Add(lblS2)
        End If

        ' Card click → open draw manager
        Dim handleCardClick As EventHandler = Sub(s, ev)
                                                  Dim drawForm As New frmGenerateDraw(_tournamentID, _tournamentName)
                                                  drawForm.ShowDialog()
                                                  LoadTournamentMatches()
                                              End Sub

        AddHandler pnlCard.Click, handleCardClick
        AddHandler lblP1.Click, Sub(s, ev) handleCardClick(pnlCard, EventArgs.Empty)
        AddHandler lblP2.Click, Sub(s, ev) handleCardClick(pnlCard, EventArgs.Empty)
        If Not showPlayButton Then
            AddHandler lblS1.Click, Sub(s, ev) handleCardClick(pnlCard, EventArgs.Empty)
            AddHandler lblS2.Click, Sub(s, ev) handleCardClick(pnlCard, EventArgs.Empty)
        End If
        AddHandler pnlScoreCol.Click, Sub(s, ev) handleCardClick(pnlCard, EventArgs.Empty)

        ' Hover propagation for nested controls
        Dim bindHover = Sub(c As Control)
                            AddHandler c.MouseEnter, Sub(s, ev)
                                                         pnlCard.BorderColor = Color.FromArgb(0, 242, 254)
                                                         pnlCard.FillColor = Color.FromArgb(28, 33, 40)
                                                     End Sub
                            AddHandler c.MouseLeave, Sub(s, ev)
                                                         pnlCard.BorderColor = Color.FromArgb(48, 54, 61)
                                                         pnlCard.FillColor = Color.FromArgb(22, 27, 34)
                                                     End Sub
                        End Sub

        bindHover(lblP1)
        bindHover(lblP2)
        If Not showPlayButton Then
            bindHover(lblS1)
            bindHover(lblS2)
        End If
        bindHover(pnlScoreCol)

        Return pnlCard
    End Function

    ' ================================================
    ' UTILITY
    ' ================================================

    Private Sub EnableDoubleBuffering(ctrl As Control)

        If ctrl Is Nothing Then
            Return
        End If

        Dim ctrlType As Type = ctrl.GetType()

        Dim prop As Reflection.PropertyInfo =
        ctrlType.GetProperty(
            "DoubleBuffered",
            Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic
        )

        If prop IsNot Nothing Then
            prop.SetValue(ctrl, True, Nothing)
        End If

    End Sub

End Class
