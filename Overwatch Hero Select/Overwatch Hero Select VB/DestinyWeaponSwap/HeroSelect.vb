Public Class frmOverwatchHeroSelect
    'I believe this is to be able to perform key presses
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loading the Form and putting all image boxes in the correct place
        cmdUpDown.Top = 14
        cmdUpDown.Left = 1197
        txtUpDown.Top = 42
        txtUpDown.Left = 1197
        picSwapPlate.Top = 0
        picSwapPlate.Left = 0
        'cmdUpDown clicked to push the images into their standby mode
        cmdUpDown.PerformClick()
    End Sub

    Private Sub cmdVote1_Click(sender As Object, e As EventArgs) Handles cmdVote1.Click
        'Chat sends a vote for Hero 1. Percentage bars adjust to reflect overall voting %
        txtVote1.Text = txtVote1.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub cmdVote2_Click(sender As Object, e As EventArgs) Handles cmdVote2.Click
        'Chat sends a vote for Hero 2. Percentage bars adjust to reflect overall voting %
        txtVote2.Text = txtVote2.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub cmdVote3_Click(sender As Object, e As EventArgs) Handles cmdVote3.Click
        'Chat sends a vote for Hero 3. Percentage bars adjust to reflect overall voting %
        txtVote3.Text = txtVote3.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub tmrUpDown_Tick(sender As Object, e As EventArgs) Handles tmrUpDown.Tick
        'Moving Vote options up (when starting vote) or down (when vote is over)

        If cmdUpDown.Text = "Up" Then
            'Reset everything for a blank vote
            cmdVote1.Enabled = True
            cmdVote2.Enabled = True
            cmdVote3.Enabled = True
            barVote1.Width = 0
            barVote2.Width = 0
            barVote3.Width = 0

            If txtUpDown.Text = 125 Then
                'All items are at the top, do not move them anymore. Ready everything to be pushed down.
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Down"
            Else
                'Move all items up by 1 pixel
                picHero1.Top = picHero1.Top - 1
                picHero2.Top = picHero2.Top - 1
                picHero3.Top = picHero3.Top - 1
                lblHeroName1.Top = lblHeroName1.Top - 1
                lblHeroName2.Top = lblHeroName2.Top - 1
                lblHeroName3.Top = lblHeroName3.Top - 1
                barVote1.Top = barVote1.Top - 1
                barVote2.Top = barVote2.Top - 1
                barVote3.Top = barVote3.Top - 1
                picSwapPlate.Top = picSwapPlate.Top - 1
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text = txtUpDown.Text + 1
            End If


        ElseIf cmdUpDown.Text = "Down" Then
            'Vote is over, voting is disabled
            cmdVote1.Enabled = False
            cmdVote2.Enabled = False
            cmdVote3.Enabled = False

            If txtUpDown.Text = 125 Then
                'All items are at the bottom, do not move them anymore. Ready everything to be pushed up.
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Up"
                'Reset Vote
                txtVote1.Text = "0"
                txtVote2.Text = "0"
                txtVote3.Text = "0"
                txtTotalVotes.Text = "0"

            Else
                'Move all items down by 1 pixel
                picHero1.Top = picHero1.Top + 1
                picHero2.Top = picHero2.Top + 1
                picHero3.Top = picHero3.Top + 1
                lblHeroName1.Top = lblHeroName1.Top + 1
                lblHeroName2.Top = lblHeroName2.Top + 1
                lblHeroName3.Top = lblHeroName3.Top + 1
                barVote1.Top = barVote1.Top + 1
                barVote2.Top = barVote2.Top + 1
                barVote3.Top = barVote3.Top + 1
                picSwapPlate.Top = picSwapPlate.Top + 1
                'Mark the timer up by 1 (until it reaches 125)
                txtUpDown.Text = txtUpDown.Text + 1
            End If

        End If
    End Sub

    Private Sub cmdUpDown_Click(sender As Object, e As EventArgs) Handles cmdUpDown.Click
        'Turn on the motion for voting options
        tmrUpDown.Enabled = True
    End Sub

    Private Sub cmdRandomHeroes_Click(sender As Object, e As EventArgs) Handles cmdRandomHeroes.Click

        'Select 3 Ramdom Heroes for a poll. Do not include the last played hero
Start:
        Randomize()
        txtRandomHero1.Text = Int((21 * Rnd()) + 1)
        txtRandomHero2.Text = Int((21 * Rnd()) + 1)
        txtRandomHero3.Text = Int((21 * Rnd()) + 1)
        If txtRandomHero1.Text = txtRandomHero2.Text Then
            GoTo Start
        ElseIf txtRandomHero1.Text = txtRandomHero3.Text Then
            GoTo Start
        ElseIf txtRandomHero2.Text = txtRandomHero3.Text Then
            GoTo Start
        ElseIf txtRandomHero1.Text = txtLastHero.Text Then
            GoTo Start
        ElseIf txtRandomHero2.Text = txtLastHero.Text Then
            GoTo Start
        ElseIf txtRandomHero3.Text = txtLastHero.Text Then
            GoTo Start
        End If

        'Based on number, place Hero Image and Name into picHero and lblHeroName for all 3 Heroes
        Select Case txtRandomHero1.Text
            Case 1
                picHero1.Image = pic76.Image
                lblHeroName1.Text = "Soldier 76"
            Case 2
                picHero1.Image = picBastion.Image
                lblHeroName1.Text = "Bastion"
            Case 3
                picHero1.Image = picDVa.Image
                lblHeroName1.Text = "D.Va"
            Case 4
                picHero1.Image = picGenji.Image
                lblHeroName1.Text = "Genji"
            Case 5
                picHero1.Image = picHanzo.Image
                lblHeroName1.Text = "Hanzo"
            Case 6
                picHero1.Image = picJunkrat.Image
                lblHeroName1.Text = "Junkrat"
            Case 7
                picHero1.Image = picLucio.Image
                lblHeroName1.Text = "Lucio"
            Case 8
                picHero1.Image = picMcCree.Image
                lblHeroName1.Text = "McCree"
            Case 9
                picHero1.Image = picMei.Image
                lblHeroName1.Text = "Mei"
            Case 10
                picHero1.Image = picMercy.Image
                lblHeroName1.Text = "Mercy"
            Case 11
                picHero1.Image = picPharah.Image
                lblHeroName1.Text = "Pharah"
            Case 12
                picHero1.Image = picReaper.Image
                lblHeroName1.Text = "Reaper"
            Case 13
                picHero1.Image = picReinhardt.Image
                lblHeroName1.Text = "Reinhardt"
            Case 14
                picHero1.Image = picRoadhog.Image
                lblHeroName1.Text = "Roadhog"
            Case 15
                picHero1.Image = picSymmetra.Image
                lblHeroName1.Text = "Symmetra"
            Case 16
                picHero1.Image = picTorbjorn.Image
                lblHeroName1.Text = "Torbjorn"
            Case 17
                picHero1.Image = picTracer.Image
                lblHeroName1.Text = "Tracer"
            Case 18
                picHero1.Image = picWidowmaker.Image
                lblHeroName1.Text = "Widowmakr"
            Case 19
                picHero1.Image = picWinston.Image
                lblHeroName1.Text = "Winston"
            Case 20
                picHero1.Image = picZarya.Image
                lblHeroName1.Text = "Zarya"
            Case 21
                picHero1.Image = picZenyatta.Image
                lblHeroName1.Text = "Zenyatta"
        End Select

        Select Case txtRandomHero2.Text
            Case 1
                picHero2.Image = pic76.Image
                lblHeroName2.Text = "Soldier 76"
            Case 2
                picHero2.Image = picBastion.Image
                lblHeroName2.Text = "Bastion"
            Case 3
                picHero2.Image = picDVa.Image
                lblHeroName2.Text = "D.Va"
            Case 4
                picHero2.Image = picGenji.Image
                lblHeroName2.Text = "Genji"
            Case 5
                picHero2.Image = picHanzo.Image
                lblHeroName2.Text = "Hanzo"
            Case 6
                picHero2.Image = picJunkrat.Image
                lblHeroName2.Text = "Junkrat"
            Case 7
                picHero2.Image = picLucio.Image
                lblHeroName2.Text = "Lucio"
            Case 8
                picHero2.Image = picMcCree.Image
                lblHeroName2.Text = "McCree"
            Case 9
                picHero2.Image = picMei.Image
                lblHeroName2.Text = "Mei"
            Case 10
                picHero2.Image = picMercy.Image
                lblHeroName2.Text = "Mercy"
            Case 11
                picHero2.Image = picPharah.Image
                lblHeroName2.Text = "Pharah"
            Case 12
                picHero2.Image = picReaper.Image
                lblHeroName2.Text = "Reaper"
            Case 13
                picHero2.Image = picReinhardt.Image
                lblHeroName2.Text = "Reinhardt"
            Case 14
                picHero2.Image = picRoadhog.Image
                lblHeroName2.Text = "Roadhog"
            Case 15
                picHero2.Image = picSymmetra.Image
                lblHeroName2.Text = "Symmetra"
            Case 16
                picHero2.Image = picTorbjorn.Image
                lblHeroName2.Text = "Torbjorn"
            Case 17
                picHero2.Image = picTracer.Image
                lblHeroName2.Text = "Tracer"
            Case 18
                picHero2.Image = picWidowmaker.Image
                lblHeroName2.Text = "Widowmakr"
            Case 19
                picHero2.Image = picWinston.Image
                lblHeroName2.Text = "Winston"
            Case 20
                picHero2.Image = picZarya.Image
                lblHeroName2.Text = "Zarya"
            Case 21
                picHero2.Image = picZenyatta.Image
                lblHeroName2.Text = "Zenyatta"
        End Select

        Select Case txtRandomHero3.Text
            Case 1
                picHero3.Image = pic76.Image
                lblHeroName3.Text = "Soldier 76"
            Case 2
                picHero3.Image = picBastion.Image
                lblHeroName3.Text = "Bastion"
            Case 3
                picHero3.Image = picDVa.Image
                lblHeroName3.Text = "D.Va"
            Case 4
                picHero3.Image = picGenji.Image
                lblHeroName3.Text = "Genji"
            Case 5
                picHero3.Image = picHanzo.Image
                lblHeroName3.Text = "Hanzo"
            Case 6
                picHero3.Image = picJunkrat.Image
                lblHeroName3.Text = "Junkrat"
            Case 7
                picHero3.Image = picLucio.Image
                lblHeroName3.Text = "Lucio"
            Case 8
                picHero3.Image = picMcCree.Image
                lblHeroName3.Text = "McCree"
            Case 9
                picHero3.Image = picMei.Image
                lblHeroName3.Text = "Mei"
            Case 10
                picHero3.Image = picMercy.Image
                lblHeroName3.Text = "Mercy"
            Case 11
                picHero3.Image = picPharah.Image
                lblHeroName3.Text = "Pharah"
            Case 12
                picHero3.Image = picReaper.Image
                lblHeroName3.Text = "Reaper"
            Case 13
                picHero3.Image = picReinhardt.Image
                lblHeroName3.Text = "Reinhardt"
            Case 14
                picHero3.Image = picRoadhog.Image
                lblHeroName3.Text = "Roadhog"
            Case 15
                picHero3.Image = picSymmetra.Image
                lblHeroName3.Text = "Symmetra"
            Case 16
                picHero3.Image = picTorbjorn.Image
                lblHeroName3.Text = "Torbjorn"
            Case 17
                picHero3.Image = picTracer.Image
                lblHeroName3.Text = "Tracer"
            Case 18
                picHero3.Image = picWidowmaker.Image
                lblHeroName3.Text = "Widowmakr"
            Case 19
                picHero3.Image = picWinston.Image
                lblHeroName3.Text = "Winston"
            Case 20
                picHero3.Image = picZarya.Image
                lblHeroName3.Text = "Zarya"
            Case 21
                picHero3.Image = picZenyatta.Image
                lblHeroName3.Text = "Zenyatta"
        End Select

    End Sub

    Private Sub cmdStartVote_Click(sender As Object, e As EventArgs) Handles cmdStartVote.Click
        tmrVote.Enabled = True 'Vote only lasts during this duration
        cmdRandomHeroes.PerformClick() 'Mix up all heroes
        cmdUpDown.PerformClick() 'Move up all voting options into visible field
    End Sub

    Private Sub tmrVote_Tick(sender As Object, e As EventArgs) Handles tmrVote.Tick
        If txtVoteCountdown.Text = 0 Then
            'Vote is over. Declair winner
            'Check who had the most votes. Move that to txtLastHero.text
            If txtVote1.Text >= txtVote2.Text Then
                If txtVote1.Text >= txtVote3.Text Then
                    txtLastHero.Text = txtRandomHero1.Text
                Else
                    txtLastHero.Text = txtRandomHero3.Text
                End If
            Else
                If txtVote2.Text >= txtVote3.Text Then
                    txtLastHero.Text = txtRandomHero2.Text
                Else
                    txtLastHero.Text = txtRandomHero3.Text
                End If
            End If
            cmdUpDown.PerformClick() 'send all voting options down
            txtVoteCountdown.Text = "30" 'reset voting countdown timer
            tmrVote.Enabled = False 'stop counting down
            tmrReticleCheck.Enabled = True 'start checking for death again
        Else
            txtVoteCountdown.Text = txtVoteCountdown.Text - 1 'countdown from timer by 1
        End If
    End Sub

    Private Sub cmdSwitchHeroes_Click(sender As Object, e As EventArgs) Handles cmdSwitchHeroes.Click
        'AutoHotKey Macros to switch heros in game - to be used on death screen
        'Checks what Hero was last voted for (txtLastHero.text)
        Select Case txtLastHero.Text
            Case 1
                SendKeys.Send("{F24}")
            Case 2
                SendKeys.Send("{F23}")
            Case 3
                SendKeys.Send("{F22}")
            Case 4
                SendKeys.Send("{F21}")
            Case 5
                SendKeys.Send("{F20}")
            Case 6
                SendKeys.Send("{F19}")
            Case 7
                SendKeys.Send("{F18}")
            Case 8
                SendKeys.Send("{F17}")
            Case 9
                SendKeys.Send("{F16}")
            Case 10
                SendKeys.Send("{F15}")
            Case 11
                SendKeys.Send("{F14}")
            Case 12
                SendKeys.Send("{F13}")
            Case 13
                SendKeys.Send("{F12}")
            Case 14
                SendKeys.Send("{F11}")
            Case 15
                SendKeys.Send("{F10}")
            Case 16
                SendKeys.Send("{F9}")
            Case 17
                SendKeys.Send("{F8}")
            Case 18
                SendKeys.Send("{F7}")
            Case 19
                SendKeys.Send("{F6}")
            Case 20
                SendKeys.Send("{F5}")
            Case 21
                SendKeys.Send("{F4}")
        End Select



    End Sub

    Private Sub tmrReticleCheck_Tick(sender As Object, e As EventArgs) Handles tmrReticleCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(2880, 540), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name

        'All presumptions on the characters dead/alive status are founded on the presence or absence of the reticle being visible
        If txtReticleColor.Text = "ff00ff00" Then
            If txtPlayerStatus.Text = "Alive" Then
                'NOTHING
            Else
                'Just spawned- Run spawn check
                tmrSpawnCheck.Enabled = True
                tmrReticleCheck.Enabled = False
            End If

        Else
            If txtPlayerStatus.Text = "Dead" Then
                'NOTHING
            Else
                'Just died- Run death check
                tmrDeathCheck.Enabled = True
                tmrReticleCheck.Enabled = False
            End If
        End If
    End Sub

    Private Sub tmrSpawnCheck_Tick(sender As Object, e As EventArgs) Handles tmrSpawnCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(2880, 540), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name

        If txtCheckYes.Text = 100 Then
            'Hero did respawn. Start the new vote & reset.
            cmdStartVote.PerformClick()
            tmrSpawnCheck.Enabled = False
            txtCheckNo.Text = "100"
            txtCheckYes.Text = "0"
            txtPlayerStatus.Text = "Alive"
        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Hero did not respawn. Reset & Keep waiting.
            tmrSpawnCheck.Enabled = False
            txtCheckNo.Text = "100"
            txtCheckYes.Text = "0"
            tmrReticleCheck.Enabled = True
        Else
            'expecting to see green. If we dont, return No
            If txtReticleColor.Text = "ff00ff00" Then
                txtCheckYes.Text = txtCheckYes.Text + 1
            Else
                txtCheckNo.Text = txtCheckNo.Text - 1
            End If
        End If
    End Sub

    Private Sub tmrDeathCheck_Tick(sender As Object, e As EventArgs) Handles tmrDeathCheck.Tick
        'Checking 1 pixel at the center of the right screen
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(2880, 540), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name

        If txtCheckYes.Text = 100 Then
            'Hero did die. Switch Heroes
            cmdSwitchHeroes.PerformClick()
            tmrDeathCheck.Enabled = False
            txtCheckNo.Text = "100"
            txtCheckYes.Text = "0"
            txtPlayerStatus.Text = "Dead"
            tmrReticleCheck.Enabled = True
        ElseIf txtCheckNo.Text = 0 Then
            'false positive. Hero did not die. Reset & Keep waiting.
            tmrDeathCheck.Enabled = False
            txtCheckNo.Text = "100"
            txtCheckYes.Text = "0"
            tmrReticleCheck.Enabled = True
        Else
            'expecting to see NO green. If we do, return No
            If txtReticleColor.Text = "ff00ff00" Then
                txtCheckNo.Text = txtCheckNo.Text - 1
            Else
                txtCheckYes.Text = txtCheckYes.Text + 1
            End If
        End If
    End Sub


End Class
