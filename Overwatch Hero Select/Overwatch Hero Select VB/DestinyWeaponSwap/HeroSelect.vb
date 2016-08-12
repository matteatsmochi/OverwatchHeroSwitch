Public Class frmOverwatchHeroSelect

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdUpDown.Top = 14
        cmdUpDown.Left = 1197
        txtUpDown.Top = 42
        txtUpDown.Left = 1197
        picSwapPlate.Top = 0
        picSwapPlate.Left = 0
        cmdUpDown.PerformClick()


    End Sub

    Private Sub cmdVote1_Click(sender As Object, e As EventArgs) Handles cmdVote1.Click
        txtVote1.Text = txtVote1.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub cmdVote2_Click(sender As Object, e As EventArgs) Handles cmdVote2.Click
        txtVote2.Text = txtVote2.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub cmdVote3_Click(sender As Object, e As EventArgs) Handles cmdVote3.Click
        txtVote3.Text = txtVote3.Text + 1
        txtTotalVotes.Text = txtTotalVotes.Text + 1

        barVote1.Width = (txtVote1.Text / txtTotalVotes.Text) * 200
        barVote2.Width = (txtVote2.Text / txtTotalVotes.Text) * 200
        barVote3.Width = (txtVote3.Text / txtTotalVotes.Text) * 200
    End Sub

    Private Sub tmrUpDown_Tick(sender As Object, e As EventArgs) Handles tmrUpDown.Tick
        If cmdUpDown.Text = "Up" Then
            cmdVote1.Enabled = True
            cmdVote2.Enabled = True
            cmdVote3.Enabled = True
            barVote1.Width = 0
            barVote2.Width = 0
            barVote3.Width = 0

            If txtUpDown.Text = 125 Then
                'reset
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Down"
            Else
                'move everything down
                picWeapon1.Top = picWeapon1.Top - 1
                picWeapon2.Top = picWeapon2.Top - 1
                picWeapon3.Top = picWeapon3.Top - 1
                lblWeaponName1.Top = lblWeaponName1.Top - 1
                lblWeaponName2.Top = lblWeaponName2.Top - 1
                lblWeaponName3.Top = lblWeaponName3.Top - 1
                barVote1.Top = barVote1.Top - 1
                barVote2.Top = barVote2.Top - 1
                barVote3.Top = barVote3.Top - 1
                picSwapPlate.Top = picSwapPlate.Top - 1

                txtUpDown.Text = txtUpDown.Text + 1
            End If


        ElseIf cmdUpDown.Text = "Down" Then
            cmdVote1.Enabled = False
            cmdVote2.Enabled = False
            cmdVote3.Enabled = False

            If txtUpDown.Text = 125 Then
                'reset
                tmrUpDown.Enabled = False
                txtUpDown.Text = "0"
                cmdUpDown.Text = "Up"

                txtVote1.Text = "0"
                txtVote2.Text = "0"
                txtVote3.Text = "0"
                txtTotalVotes.Text = "0"

            Else
                'move everything down
                picWeapon1.Top = picWeapon1.Top + 1
                picWeapon2.Top = picWeapon2.Top + 1
                picWeapon3.Top = picWeapon3.Top + 1
                lblWeaponName1.Top = lblWeaponName1.Top + 1
                lblWeaponName2.Top = lblWeaponName2.Top + 1
                lblWeaponName3.Top = lblWeaponName3.Top + 1
                barVote1.Top = barVote1.Top + 1
                barVote2.Top = barVote2.Top + 1
                barVote3.Top = barVote3.Top + 1
                picSwapPlate.Top = picSwapPlate.Top + 1

                txtUpDown.Text = txtUpDown.Text + 1
            End If

        End If
    End Sub

    Private Sub cmdUpDown_Click(sender As Object, e As EventArgs) Handles cmdUpDown.Click
        tmrUpDown.Enabled = True
    End Sub

    Private Sub cmdRandomHeroes_Click(sender As Object, e As EventArgs) Handles cmdRandomHeroes.Click

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

        Select Case txtRandomHero1.Text
            Case 1
                picWeapon1.Image = pic76.Image
                lblWeaponName1.Text = "Soldier 76"
            Case 2
                picWeapon1.Image = picBastion.Image
                lblWeaponName1.Text = "Bastion"
            Case 3
                picWeapon1.Image = picDVa.Image
                lblWeaponName1.Text = "D.Va"
            Case 4
                picWeapon1.Image = picGenji.Image
                lblWeaponName1.Text = "Genji"
            Case 5
                picWeapon1.Image = picHanzo.Image
                lblWeaponName1.Text = "Hanzo"
            Case 6
                picWeapon1.Image = picJunkrat.Image
                lblWeaponName1.Text = "Junkrat"
            Case 7
                picWeapon1.Image = picLucio.Image
                lblWeaponName1.Text = "Lucio"
            Case 8
                picWeapon1.Image = picMcCree.Image
                lblWeaponName1.Text = "McCree"
            Case 9
                picWeapon1.Image = picMei.Image
                lblWeaponName1.Text = "Mei"
            Case 10
                picWeapon1.Image = picMercy.Image
                lblWeaponName1.Text = "Mercy"
            Case 11
                picWeapon1.Image = picPharah.Image
                lblWeaponName1.Text = "Pharah"
            Case 12
                picWeapon1.Image = picReaper.Image
                lblWeaponName1.Text = "Reaper"
            Case 13
                picWeapon1.Image = picReinhardt.Image
                lblWeaponName1.Text = "Reinhardt"
            Case 14
                picWeapon1.Image = picRoadhog.Image
                lblWeaponName1.Text = "Roadhog"
            Case 15
                picWeapon1.Image = picSymmetra.Image
                lblWeaponName1.Text = "Symmetra"
            Case 16
                picWeapon1.Image = picTorbjorn.Image
                lblWeaponName1.Text = "Torbjorn"
            Case 17
                picWeapon1.Image = picTracer.Image
                lblWeaponName1.Text = "Tracer"
            Case 18
                picWeapon1.Image = picWidowmaker.Image
                lblWeaponName1.Text = "Widowmakr"
            Case 19
                picWeapon1.Image = picWinston.Image
                lblWeaponName1.Text = "Winston"
            Case 20
                picWeapon1.Image = picZarya.Image
                lblWeaponName1.Text = "Zarya"
            Case 21
                picWeapon1.Image = picZenyatta.Image
                lblWeaponName1.Text = "Zenyatta"
        End Select

        Select Case txtRandomHero2.Text
            Case 1
                picWeapon2.Image = pic76.Image
                lblWeaponName2.Text = "Soldier 76"
            Case 2
                picWeapon2.Image = picBastion.Image
                lblWeaponName2.Text = "Bastion"
            Case 3
                picWeapon2.Image = picDVa.Image
                lblWeaponName2.Text = "D.Va"
            Case 4
                picWeapon2.Image = picGenji.Image
                lblWeaponName2.Text = "Genji"
            Case 5
                picWeapon2.Image = picHanzo.Image
                lblWeaponName2.Text = "Hanzo"
            Case 6
                picWeapon2.Image = picJunkrat.Image
                lblWeaponName2.Text = "Junkrat"
            Case 7
                picWeapon2.Image = picLucio.Image
                lblWeaponName2.Text = "Lucio"
            Case 8
                picWeapon2.Image = picMcCree.Image
                lblWeaponName2.Text = "McCree"
            Case 9
                picWeapon2.Image = picMei.Image
                lblWeaponName2.Text = "Mei"
            Case 10
                picWeapon2.Image = picMercy.Image
                lblWeaponName2.Text = "Mercy"
            Case 11
                picWeapon2.Image = picPharah.Image
                lblWeaponName2.Text = "Pharah"
            Case 12
                picWeapon2.Image = picReaper.Image
                lblWeaponName2.Text = "Reaper"
            Case 13
                picWeapon2.Image = picReinhardt.Image
                lblWeaponName2.Text = "Reinhardt"
            Case 14
                picWeapon2.Image = picRoadhog.Image
                lblWeaponName2.Text = "Roadhog"
            Case 15
                picWeapon2.Image = picSymmetra.Image
                lblWeaponName2.Text = "Symmetra"
            Case 16
                picWeapon2.Image = picTorbjorn.Image
                lblWeaponName2.Text = "Torbjorn"
            Case 17
                picWeapon2.Image = picTracer.Image
                lblWeaponName2.Text = "Tracer"
            Case 18
                picWeapon2.Image = picWidowmaker.Image
                lblWeaponName2.Text = "Widowmakr"
            Case 19
                picWeapon2.Image = picWinston.Image
                lblWeaponName2.Text = "Winston"
            Case 20
                picWeapon2.Image = picZarya.Image
                lblWeaponName2.Text = "Zarya"
            Case 21
                picWeapon2.Image = picZenyatta.Image
                lblWeaponName2.Text = "Zenyatta"
        End Select

        Select Case txtRandomHero3.Text
            Case 1
                picWeapon3.Image = pic76.Image
                lblWeaponName3.Text = "Soldier 76"
            Case 2
                picWeapon3.Image = picBastion.Image
                lblWeaponName3.Text = "Bastion"
            Case 3
                picWeapon3.Image = picDVa.Image
                lblWeaponName3.Text = "D.Va"
            Case 4
                picWeapon3.Image = picGenji.Image
                lblWeaponName3.Text = "Genji"
            Case 5
                picWeapon3.Image = picHanzo.Image
                lblWeaponName3.Text = "Hanzo"
            Case 6
                picWeapon3.Image = picJunkrat.Image
                lblWeaponName3.Text = "Junkrat"
            Case 7
                picWeapon3.Image = picLucio.Image
                lblWeaponName3.Text = "Lucio"
            Case 8
                picWeapon3.Image = picMcCree.Image
                lblWeaponName3.Text = "McCree"
            Case 9
                picWeapon3.Image = picMei.Image
                lblWeaponName3.Text = "Mei"
            Case 10
                picWeapon3.Image = picMercy.Image
                lblWeaponName3.Text = "Mercy"
            Case 11
                picWeapon3.Image = picPharah.Image
                lblWeaponName3.Text = "Pharah"
            Case 12
                picWeapon3.Image = picReaper.Image
                lblWeaponName3.Text = "Reaper"
            Case 13
                picWeapon3.Image = picReinhardt.Image
                lblWeaponName3.Text = "Reinhardt"
            Case 14
                picWeapon3.Image = picRoadhog.Image
                lblWeaponName3.Text = "Roadhog"
            Case 15
                picWeapon3.Image = picSymmetra.Image
                lblWeaponName3.Text = "Symmetra"
            Case 16
                picWeapon3.Image = picTorbjorn.Image
                lblWeaponName3.Text = "Torbjorn"
            Case 17
                picWeapon3.Image = picTracer.Image
                lblWeaponName3.Text = "Tracer"
            Case 18
                picWeapon3.Image = picWidowmaker.Image
                lblWeaponName3.Text = "Widowmakr"
            Case 19
                picWeapon3.Image = picWinston.Image
                lblWeaponName3.Text = "Winston"
            Case 20
                picWeapon3.Image = picZarya.Image
                lblWeaponName3.Text = "Zarya"
            Case 21
                picWeapon3.Image = picZenyatta.Image
                lblWeaponName3.Text = "Zenyatta"
        End Select

    End Sub

    Private Sub cmdStartVote_Click(sender As Object, e As EventArgs) Handles cmdStartVote.Click
        tmrVote.Enabled = True
        cmdRandomHeroes.PerformClick()
        cmdUpDown.PerformClick()
    End Sub

    Private Sub tmrVote_Tick(sender As Object, e As EventArgs) Handles tmrVote.Tick
        If txtVoteCountdown.Text = 0 Then

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

            cmdUpDown.PerformClick()
            txtVoteCountdown.Text = "30"
            tmrVote.Enabled = False
        Else
            txtVoteCountdown.Text = txtVoteCountdown.Text - 1
        End If
    End Sub

    Private Sub cmdSwitchHeroes_Click(sender As Object, e As EventArgs) Handles cmdSwitchHeroes.Click

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

        cmdStartVote.PerformClick()

    End Sub

    Private Sub tmrReticleCheck_Tick(sender As Object, e As EventArgs) Handles tmrReticleCheck.Tick
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(2880, 540), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        picReticleColor.BackColor = c
        txtReticleColor.Text = picReticleColor.BackColor.Name


        If txtReticleColor.Text = "ff00ff00" Then
            'alive
            If txtPlayerStatus.Text = "Alive" Then
            Else
                'wait 5 seconds
                tmrDelayVote.Enabled = True
            End If

        Else
            'dead
            If txtPlayerStatus.Text = "Dead" Then
            Else
                'wait 5 seconds
                tmrDelayHeroSwitch.Enabled = True
            End If

        End If

    End Sub



    Private Sub tmrDelayHeroSwitch_Tick(sender As Object, e As EventArgs) Handles tmrDelayHeroSwitch.Tick
        If txtDelayHeroSwitch.Text > 5 Then
            cmdSwitchHeroes.PerformClick()
            tmrDelayHeroSwitch.Enabled = False
            txtDelayHeroSwitch.Text = "0"
            txtPlayerStatus.Text = "Alive"
        Else
            txtDelayHeroSwitch.Text = txtDelayHeroSwitch.Text + 1
        End If
    End Sub

    Private Sub tmrDelayVote_Tick(sender As Object, e As EventArgs) Handles tmrDelayVote.Tick
        If txtDelayVote.Text > 5 Then
            cmdStartVote.PerformClick()
            tmrDelayVote.Enabled = False
            txtDelayVote.Text = "0"
            txtPlayerStatus.Text = "Dead"
        Else
            txtDelayHeroSwitch.Text = txtDelayHeroSwitch.Text + 1
        End If
    End Sub
End Class
