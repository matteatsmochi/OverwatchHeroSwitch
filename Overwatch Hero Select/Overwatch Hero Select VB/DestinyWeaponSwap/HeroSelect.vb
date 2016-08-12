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
        If txtLastHero.Text = "1" Then
            SendKeys.Send("{F24}")
        ElseIf txtLastHero.Text = "2" Then
            SendKeys.Send("{F23}")
        ElseIf txtLastHero.Text = "3" Then
            SendKeys.Send("{F22}")
        ElseIf txtLastHero.Text = "4" Then
            SendKeys.Send("{F21}")
        ElseIf txtLastHero.Text = "5" Then
            SendKeys.Send("{F20}")
        ElseIf txtLastHero.Text = "6" Then
            SendKeys.Send("{F19}")
        ElseIf txtLastHero.Text = "7" Then
            SendKeys.Send("{F18}")
        ElseIf txtLastHero.Text = "8" Then
            SendKeys.Send("{F17}")
        ElseIf txtLastHero.Text = "9" Then
            SendKeys.Send("{F16}")
        ElseIf txtLastHero.Text = "10" Then
            SendKeys.Send("{F15}")
        ElseIf txtLastHero.Text = "11" Then
            SendKeys.Send("{F14}")
        ElseIf txtLastHero.Text = "12" Then
            SendKeys.Send("{F13}")
        ElseIf txtLastHero.Text = "13" Then
            SendKeys.Send("{F12}")
        ElseIf txtLastHero.Text = "14" Then
            SendKeys.Send("{F11}")
        ElseIf txtLastHero.Text = "15" Then
            SendKeys.Send("{F10}")
        ElseIf txtLastHero.Text = "16" Then
            SendKeys.Send("{F9}")
        ElseIf txtLastHero.Text = "17" Then
            SendKeys.Send("{F8}")
        ElseIf txtLastHero.Text = "18" Then
            SendKeys.Send("{F7}")
        ElseIf txtLastHero.Text = "19" Then
            SendKeys.Send("{F6}")
        ElseIf txtLastHero.Text = "20" Then
            SendKeys.Send("{F5}")
        ElseIf txtLastHero.Text = "21" Then
            SendKeys.Send("{F4}")
        End If

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

    Private Sub tmrHotkey_Tick(sender As Object, e As EventArgs) Handles tmrHotkey.Tick
        Dim hot1 As Boolean
        Dim hot2 As Boolean
        Dim hot3 As Boolean
        Dim hot4 As Boolean
        Dim hot5 As Boolean
        Dim hot6 As Boolean
        Dim hot7 As Boolean
        Dim hot8 As Boolean
        Dim hot9 As Boolean
        Dim hot10 As Boolean
        Dim hot11 As Boolean
        Dim hot12 As Boolean
        Dim hot13 As Boolean
        Dim hot14 As Boolean
        Dim hot15 As Boolean
        Dim hot16 As Boolean
        Dim hot17 As Boolean
        Dim hot18 As Boolean
        Dim hot19 As Boolean
        Dim hot20 As Boolean
        Dim hot21 As Boolean

        hot1 = GetAsyncKeyState(Keys.A)
        hot2 = GetAsyncKeyState(Keys.B)
        hot3 = GetAsyncKeyState(Keys.C)
        hot4 = GetAsyncKeyState(Keys.D)
        hot5 = GetAsyncKeyState(Keys.E)
        hot6 = GetAsyncKeyState(Keys.F)
        hot7 = GetAsyncKeyState(Keys.G)
        hot8 = GetAsyncKeyState(Keys.H)
        hot9 = GetAsyncKeyState(Keys.I)
        hot10 = GetAsyncKeyState(Keys.J)
        hot11 = GetAsyncKeyState(Keys.K)
        hot12 = GetAsyncKeyState(Keys.L)
        hot13 = GetAsyncKeyState(Keys.M)
        hot14 = GetAsyncKeyState(Keys.N)
        hot15 = GetAsyncKeyState(Keys.O)
        hot16 = GetAsyncKeyState(Keys.P)
        hot17 = GetAsyncKeyState(Keys.Q)
        hot18 = GetAsyncKeyState(Keys.R)
        hot19 = GetAsyncKeyState(Keys.S)
        hot20 = GetAsyncKeyState(Keys.T)
        hot21 = GetAsyncKeyState(Keys.U)

        If hot1 = True Then
            If lblWeaponName1.Text = "Soldier76" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Soldier76" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Soldier76" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot2 = True Then
            If lblWeaponName1.Text = "Bastion" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Bastion" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Bastion" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot3 = True Then
            If lblWeaponName1.Text = "DVa" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "DVa" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "DVa" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot4 = True Then
            If lblWeaponName1.Text = "Genji" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Genji" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Genji" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot5 = True Then
            If lblWeaponName1.Text = "Hanzo" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Hanzo" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Hanzo" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot6 = True Then
            If lblWeaponName1.Text = "Junkrat" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Junkrat" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Junkrat" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot7 = True Then
            If lblWeaponName1.Text = "Lucio" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Lucio" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Lucio" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot8 = True Then
            If lblWeaponName1.Text = "McCree" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "McCree" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "McCree" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot9 = True Then
            If lblWeaponName1.Text = "Mei" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Mei" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Mei" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot10 = True Then
            If lblWeaponName1.Text = "Mercy" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Mercy" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Mercy" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot11 = True Then
            If lblWeaponName1.Text = "Pharah" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Pharah" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Pharah" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot12 = True Then
            If lblWeaponName1.Text = "Reaper" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Reaper" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Reaper" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot13 = True Then
            If lblWeaponName1.Text = "Reinhardt" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Reinhardt" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Reinhardt" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot14 = True Then
            If lblWeaponName1.Text = "Roadhog" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Roadhog" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Roadhog" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot15 = True Then
            If lblWeaponName1.Text = "Symmetra" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Symmetra" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Symmetra" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot16 = True Then
            If lblWeaponName1.Text = "Torbjorn" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Torbjorn" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Torbjorn" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot17 = True Then
            If lblWeaponName1.Text = "Tracer" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Tracer" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Tracer" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot18 = True Then
            If lblWeaponName1.Text = "Widowmakr" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Widowmakr" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Widowmakr" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot19 = True Then
            If lblWeaponName1.Text = "Winston" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Winston" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Winston" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot20 = True Then
            If lblWeaponName1.Text = "Zarya" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Zarya" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Zarya" Then
                cmdVote3.PerformClick()
            End If
        ElseIf hot21 = True Then
            If lblWeaponName1.Text = "Zenyatta" Then
                cmdVote1.PerformClick()
            ElseIf lblWeaponName2.Text = "Zenyatta" Then
                cmdVote2.PerformClick()
            ElseIf lblWeaponName3.Text = "Zenyatta" Then
                cmdVote3.PerformClick()
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
