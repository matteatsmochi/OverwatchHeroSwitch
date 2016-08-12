<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverwatchHeroSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverwatchHeroSelect))
        Me.picWeapon1 = New System.Windows.Forms.PictureBox()
        Me.picWeapon2 = New System.Windows.Forms.PictureBox()
        Me.picWeapon3 = New System.Windows.Forms.PictureBox()
        Me.picSwapPlate = New System.Windows.Forms.PictureBox()
        Me.barVote3 = New System.Windows.Forms.PictureBox()
        Me.barVote2 = New System.Windows.Forms.PictureBox()
        Me.barVote1 = New System.Windows.Forms.PictureBox()
        Me.lblWeaponName1 = New System.Windows.Forms.Label()
        Me.lblWeaponName2 = New System.Windows.Forms.Label()
        Me.lblWeaponName3 = New System.Windows.Forms.Label()
        Me.cmdVote1 = New System.Windows.Forms.Button()
        Me.txtVote1 = New System.Windows.Forms.TextBox()
        Me.txtVote2 = New System.Windows.Forms.TextBox()
        Me.cmdVote2 = New System.Windows.Forms.Button()
        Me.txtVote3 = New System.Windows.Forms.TextBox()
        Me.cmdVote3 = New System.Windows.Forms.Button()
        Me.txtTotalVotes = New System.Windows.Forms.TextBox()
        Me.cmdUpDown = New System.Windows.Forms.Button()
        Me.tmrUpDown = New System.Windows.Forms.Timer(Me.components)
        Me.txtUpDown = New System.Windows.Forms.TextBox()
        Me.pic76 = New System.Windows.Forms.PictureBox()
        Me.picBastion = New System.Windows.Forms.PictureBox()
        Me.picGenji = New System.Windows.Forms.PictureBox()
        Me.picDVa = New System.Windows.Forms.PictureBox()
        Me.picMcCree = New System.Windows.Forms.PictureBox()
        Me.picLucio = New System.Windows.Forms.PictureBox()
        Me.picJunkrat = New System.Windows.Forms.PictureBox()
        Me.picHanzo = New System.Windows.Forms.PictureBox()
        Me.picTorbjorn = New System.Windows.Forms.PictureBox()
        Me.picSymmetra = New System.Windows.Forms.PictureBox()
        Me.picRoadhog = New System.Windows.Forms.PictureBox()
        Me.picReinhardt = New System.Windows.Forms.PictureBox()
        Me.picReaper = New System.Windows.Forms.PictureBox()
        Me.picPharah = New System.Windows.Forms.PictureBox()
        Me.picMercy = New System.Windows.Forms.PictureBox()
        Me.picMei = New System.Windows.Forms.PictureBox()
        Me.picNewHero2 = New System.Windows.Forms.PictureBox()
        Me.picNewHero1 = New System.Windows.Forms.PictureBox()
        Me.picAna = New System.Windows.Forms.PictureBox()
        Me.picZenyatta = New System.Windows.Forms.PictureBox()
        Me.picZarya = New System.Windows.Forms.PictureBox()
        Me.picWinston = New System.Windows.Forms.PictureBox()
        Me.picWidowmaker = New System.Windows.Forms.PictureBox()
        Me.picTracer = New System.Windows.Forms.PictureBox()
        Me.cmdRandomHeroes = New System.Windows.Forms.Button()
        Me.txtRandomHero1 = New System.Windows.Forms.TextBox()
        Me.txtRandomHero2 = New System.Windows.Forms.TextBox()
        Me.txtRandomHero3 = New System.Windows.Forms.TextBox()
        Me.txtLastHero = New System.Windows.Forms.TextBox()
        Me.cmdStartVote = New System.Windows.Forms.Button()
        Me.tmrVote = New System.Windows.Forms.Timer(Me.components)
        Me.txtVoteCountdown = New System.Windows.Forms.TextBox()
        Me.cmdSwitchHeroes = New System.Windows.Forms.Button()
        Me.tmrReticleCheck = New System.Windows.Forms.Timer(Me.components)
        Me.txtReticleColor = New System.Windows.Forms.TextBox()
        Me.picReticleColor = New System.Windows.Forms.PictureBox()
        Me.tmrHotkey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelayHeroSwitch = New System.Windows.Forms.Timer(Me.components)
        Me.txtPlayerStatus = New System.Windows.Forms.TextBox()
        Me.txtDelayHeroSwitch = New System.Windows.Forms.TextBox()
        Me.txtDelayVote = New System.Windows.Forms.TextBox()
        Me.tmrDelayVote = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picWeapon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeapon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeapon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSwapPlate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barVote1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBastion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGenji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDVa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMcCree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLucio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunkrat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHanzo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTorbjorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSymmetra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoadhog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReinhardt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPharah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMercy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewHero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewHero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZenyatta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZarya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinston, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWidowmaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTracer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReticleColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWeapon1
        '
        resources.ApplyResources(Me.picWeapon1, "picWeapon1")
        Me.picWeapon1.Name = "picWeapon1"
        Me.picWeapon1.TabStop = False
        '
        'picWeapon2
        '
        resources.ApplyResources(Me.picWeapon2, "picWeapon2")
        Me.picWeapon2.Name = "picWeapon2"
        Me.picWeapon2.TabStop = False
        '
        'picWeapon3
        '
        resources.ApplyResources(Me.picWeapon3, "picWeapon3")
        Me.picWeapon3.Name = "picWeapon3"
        Me.picWeapon3.TabStop = False
        '
        'picSwapPlate
        '
        resources.ApplyResources(Me.picSwapPlate, "picSwapPlate")
        Me.picSwapPlate.Name = "picSwapPlate"
        Me.picSwapPlate.TabStop = False
        '
        'barVote3
        '
        Me.barVote3.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.barVote3, "barVote3")
        Me.barVote3.Name = "barVote3"
        Me.barVote3.TabStop = False
        '
        'barVote2
        '
        Me.barVote2.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.barVote2, "barVote2")
        Me.barVote2.Name = "barVote2"
        Me.barVote2.TabStop = False
        '
        'barVote1
        '
        Me.barVote1.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.barVote1, "barVote1")
        Me.barVote1.Name = "barVote1"
        Me.barVote1.TabStop = False
        '
        'lblWeaponName1
        '
        Me.lblWeaponName1.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblWeaponName1, "lblWeaponName1")
        Me.lblWeaponName1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName1.Name = "lblWeaponName1"
        '
        'lblWeaponName2
        '
        Me.lblWeaponName2.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblWeaponName2, "lblWeaponName2")
        Me.lblWeaponName2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName2.Name = "lblWeaponName2"
        '
        'lblWeaponName3
        '
        Me.lblWeaponName3.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblWeaponName3, "lblWeaponName3")
        Me.lblWeaponName3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeaponName3.Name = "lblWeaponName3"
        '
        'cmdVote1
        '
        resources.ApplyResources(Me.cmdVote1, "cmdVote1")
        Me.cmdVote1.Name = "cmdVote1"
        Me.cmdVote1.UseVisualStyleBackColor = True
        '
        'txtVote1
        '
        resources.ApplyResources(Me.txtVote1, "txtVote1")
        Me.txtVote1.Name = "txtVote1"
        '
        'txtVote2
        '
        resources.ApplyResources(Me.txtVote2, "txtVote2")
        Me.txtVote2.Name = "txtVote2"
        '
        'cmdVote2
        '
        resources.ApplyResources(Me.cmdVote2, "cmdVote2")
        Me.cmdVote2.Name = "cmdVote2"
        Me.cmdVote2.UseVisualStyleBackColor = True
        '
        'txtVote3
        '
        resources.ApplyResources(Me.txtVote3, "txtVote3")
        Me.txtVote3.Name = "txtVote3"
        '
        'cmdVote3
        '
        resources.ApplyResources(Me.cmdVote3, "cmdVote3")
        Me.cmdVote3.Name = "cmdVote3"
        Me.cmdVote3.UseVisualStyleBackColor = True
        '
        'txtTotalVotes
        '
        resources.ApplyResources(Me.txtTotalVotes, "txtTotalVotes")
        Me.txtTotalVotes.Name = "txtTotalVotes"
        '
        'cmdUpDown
        '
        resources.ApplyResources(Me.cmdUpDown, "cmdUpDown")
        Me.cmdUpDown.Name = "cmdUpDown"
        Me.cmdUpDown.UseVisualStyleBackColor = True
        '
        'tmrUpDown
        '
        Me.tmrUpDown.Interval = 1
        '
        'txtUpDown
        '
        resources.ApplyResources(Me.txtUpDown, "txtUpDown")
        Me.txtUpDown.Name = "txtUpDown"
        '
        'pic76
        '
        resources.ApplyResources(Me.pic76, "pic76")
        Me.pic76.Name = "pic76"
        Me.pic76.TabStop = False
        '
        'picBastion
        '
        resources.ApplyResources(Me.picBastion, "picBastion")
        Me.picBastion.Name = "picBastion"
        Me.picBastion.TabStop = False
        '
        'picGenji
        '
        resources.ApplyResources(Me.picGenji, "picGenji")
        Me.picGenji.Name = "picGenji"
        Me.picGenji.TabStop = False
        '
        'picDVa
        '
        resources.ApplyResources(Me.picDVa, "picDVa")
        Me.picDVa.Name = "picDVa"
        Me.picDVa.TabStop = False
        '
        'picMcCree
        '
        resources.ApplyResources(Me.picMcCree, "picMcCree")
        Me.picMcCree.Name = "picMcCree"
        Me.picMcCree.TabStop = False
        '
        'picLucio
        '
        resources.ApplyResources(Me.picLucio, "picLucio")
        Me.picLucio.Name = "picLucio"
        Me.picLucio.TabStop = False
        '
        'picJunkrat
        '
        resources.ApplyResources(Me.picJunkrat, "picJunkrat")
        Me.picJunkrat.Name = "picJunkrat"
        Me.picJunkrat.TabStop = False
        '
        'picHanzo
        '
        resources.ApplyResources(Me.picHanzo, "picHanzo")
        Me.picHanzo.Name = "picHanzo"
        Me.picHanzo.TabStop = False
        '
        'picTorbjorn
        '
        resources.ApplyResources(Me.picTorbjorn, "picTorbjorn")
        Me.picTorbjorn.Name = "picTorbjorn"
        Me.picTorbjorn.TabStop = False
        '
        'picSymmetra
        '
        resources.ApplyResources(Me.picSymmetra, "picSymmetra")
        Me.picSymmetra.Name = "picSymmetra"
        Me.picSymmetra.TabStop = False
        '
        'picRoadhog
        '
        resources.ApplyResources(Me.picRoadhog, "picRoadhog")
        Me.picRoadhog.Name = "picRoadhog"
        Me.picRoadhog.TabStop = False
        '
        'picReinhardt
        '
        resources.ApplyResources(Me.picReinhardt, "picReinhardt")
        Me.picReinhardt.Name = "picReinhardt"
        Me.picReinhardt.TabStop = False
        '
        'picReaper
        '
        resources.ApplyResources(Me.picReaper, "picReaper")
        Me.picReaper.Name = "picReaper"
        Me.picReaper.TabStop = False
        '
        'picPharah
        '
        resources.ApplyResources(Me.picPharah, "picPharah")
        Me.picPharah.Name = "picPharah"
        Me.picPharah.TabStop = False
        '
        'picMercy
        '
        resources.ApplyResources(Me.picMercy, "picMercy")
        Me.picMercy.Name = "picMercy"
        Me.picMercy.TabStop = False
        '
        'picMei
        '
        resources.ApplyResources(Me.picMei, "picMei")
        Me.picMei.Name = "picMei"
        Me.picMei.TabStop = False
        '
        'picNewHero2
        '
        resources.ApplyResources(Me.picNewHero2, "picNewHero2")
        Me.picNewHero2.Name = "picNewHero2"
        Me.picNewHero2.TabStop = False
        '
        'picNewHero1
        '
        resources.ApplyResources(Me.picNewHero1, "picNewHero1")
        Me.picNewHero1.Name = "picNewHero1"
        Me.picNewHero1.TabStop = False
        '
        'picAna
        '
        resources.ApplyResources(Me.picAna, "picAna")
        Me.picAna.Name = "picAna"
        Me.picAna.TabStop = False
        '
        'picZenyatta
        '
        resources.ApplyResources(Me.picZenyatta, "picZenyatta")
        Me.picZenyatta.Name = "picZenyatta"
        Me.picZenyatta.TabStop = False
        '
        'picZarya
        '
        resources.ApplyResources(Me.picZarya, "picZarya")
        Me.picZarya.Name = "picZarya"
        Me.picZarya.TabStop = False
        '
        'picWinston
        '
        resources.ApplyResources(Me.picWinston, "picWinston")
        Me.picWinston.Name = "picWinston"
        Me.picWinston.TabStop = False
        '
        'picWidowmaker
        '
        resources.ApplyResources(Me.picWidowmaker, "picWidowmaker")
        Me.picWidowmaker.Name = "picWidowmaker"
        Me.picWidowmaker.TabStop = False
        '
        'picTracer
        '
        resources.ApplyResources(Me.picTracer, "picTracer")
        Me.picTracer.Name = "picTracer"
        Me.picTracer.TabStop = False
        '
        'cmdRandomHeroes
        '
        resources.ApplyResources(Me.cmdRandomHeroes, "cmdRandomHeroes")
        Me.cmdRandomHeroes.Name = "cmdRandomHeroes"
        Me.cmdRandomHeroes.UseVisualStyleBackColor = True
        '
        'txtRandomHero1
        '
        resources.ApplyResources(Me.txtRandomHero1, "txtRandomHero1")
        Me.txtRandomHero1.Name = "txtRandomHero1"
        '
        'txtRandomHero2
        '
        resources.ApplyResources(Me.txtRandomHero2, "txtRandomHero2")
        Me.txtRandomHero2.Name = "txtRandomHero2"
        '
        'txtRandomHero3
        '
        resources.ApplyResources(Me.txtRandomHero3, "txtRandomHero3")
        Me.txtRandomHero3.Name = "txtRandomHero3"
        '
        'txtLastHero
        '
        resources.ApplyResources(Me.txtLastHero, "txtLastHero")
        Me.txtLastHero.Name = "txtLastHero"
        '
        'cmdStartVote
        '
        resources.ApplyResources(Me.cmdStartVote, "cmdStartVote")
        Me.cmdStartVote.Name = "cmdStartVote"
        Me.cmdStartVote.UseVisualStyleBackColor = True
        '
        'tmrVote
        '
        Me.tmrVote.Interval = 1000
        '
        'txtVoteCountdown
        '
        resources.ApplyResources(Me.txtVoteCountdown, "txtVoteCountdown")
        Me.txtVoteCountdown.Name = "txtVoteCountdown"
        '
        'cmdSwitchHeroes
        '
        resources.ApplyResources(Me.cmdSwitchHeroes, "cmdSwitchHeroes")
        Me.cmdSwitchHeroes.Name = "cmdSwitchHeroes"
        Me.cmdSwitchHeroes.UseVisualStyleBackColor = True
        '
        'tmrReticleCheck
        '
        Me.tmrReticleCheck.Enabled = True
        '
        'txtReticleColor
        '
        resources.ApplyResources(Me.txtReticleColor, "txtReticleColor")
        Me.txtReticleColor.Name = "txtReticleColor"
        '
        'picReticleColor
        '
        resources.ApplyResources(Me.picReticleColor, "picReticleColor")
        Me.picReticleColor.Name = "picReticleColor"
        Me.picReticleColor.TabStop = False
        '
        'tmrHotkey
        '
        Me.tmrHotkey.Enabled = True
        '
        'tmrDelayHeroSwitch
        '
        Me.tmrDelayHeroSwitch.Interval = 1000
        '
        'txtPlayerStatus
        '
        resources.ApplyResources(Me.txtPlayerStatus, "txtPlayerStatus")
        Me.txtPlayerStatus.Name = "txtPlayerStatus"
        '
        'txtDelayHeroSwitch
        '
        resources.ApplyResources(Me.txtDelayHeroSwitch, "txtDelayHeroSwitch")
        Me.txtDelayHeroSwitch.Name = "txtDelayHeroSwitch"
        '
        'txtDelayVote
        '
        resources.ApplyResources(Me.txtDelayVote, "txtDelayVote")
        Me.txtDelayVote.Name = "txtDelayVote"
        '
        'tmrDelayVote
        '
        Me.tmrDelayVote.Interval = 1000
        '
        'frmOverwatchHeroSelect
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.Controls.Add(Me.txtDelayVote)
        Me.Controls.Add(Me.txtDelayHeroSwitch)
        Me.Controls.Add(Me.txtPlayerStatus)
        Me.Controls.Add(Me.picReticleColor)
        Me.Controls.Add(Me.txtReticleColor)
        Me.Controls.Add(Me.cmdSwitchHeroes)
        Me.Controls.Add(Me.txtVoteCountdown)
        Me.Controls.Add(Me.cmdStartVote)
        Me.Controls.Add(Me.txtLastHero)
        Me.Controls.Add(Me.txtRandomHero3)
        Me.Controls.Add(Me.txtRandomHero2)
        Me.Controls.Add(Me.txtRandomHero1)
        Me.Controls.Add(Me.cmdRandomHeroes)
        Me.Controls.Add(Me.picNewHero2)
        Me.Controls.Add(Me.picNewHero1)
        Me.Controls.Add(Me.picAna)
        Me.Controls.Add(Me.picZenyatta)
        Me.Controls.Add(Me.picZarya)
        Me.Controls.Add(Me.picWinston)
        Me.Controls.Add(Me.picWidowmaker)
        Me.Controls.Add(Me.picTracer)
        Me.Controls.Add(Me.picTorbjorn)
        Me.Controls.Add(Me.picSymmetra)
        Me.Controls.Add(Me.picRoadhog)
        Me.Controls.Add(Me.picReinhardt)
        Me.Controls.Add(Me.picReaper)
        Me.Controls.Add(Me.picPharah)
        Me.Controls.Add(Me.picMercy)
        Me.Controls.Add(Me.picMei)
        Me.Controls.Add(Me.picMcCree)
        Me.Controls.Add(Me.picLucio)
        Me.Controls.Add(Me.picJunkrat)
        Me.Controls.Add(Me.picHanzo)
        Me.Controls.Add(Me.picGenji)
        Me.Controls.Add(Me.picDVa)
        Me.Controls.Add(Me.picBastion)
        Me.Controls.Add(Me.pic76)
        Me.Controls.Add(Me.txtUpDown)
        Me.Controls.Add(Me.cmdUpDown)
        Me.Controls.Add(Me.txtTotalVotes)
        Me.Controls.Add(Me.txtVote3)
        Me.Controls.Add(Me.cmdVote3)
        Me.Controls.Add(Me.txtVote2)
        Me.Controls.Add(Me.cmdVote2)
        Me.Controls.Add(Me.txtVote1)
        Me.Controls.Add(Me.cmdVote1)
        Me.Controls.Add(Me.lblWeaponName3)
        Me.Controls.Add(Me.lblWeaponName2)
        Me.Controls.Add(Me.lblWeaponName1)
        Me.Controls.Add(Me.barVote1)
        Me.Controls.Add(Me.barVote2)
        Me.Controls.Add(Me.barVote3)
        Me.Controls.Add(Me.picWeapon3)
        Me.Controls.Add(Me.picWeapon2)
        Me.Controls.Add(Me.picWeapon1)
        Me.Controls.Add(Me.picSwapPlate)
        Me.Name = "frmOverwatchHeroSelect"
        CType(Me.picWeapon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeapon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeapon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSwapPlate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barVote1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBastion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGenji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDVa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMcCree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLucio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunkrat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHanzo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTorbjorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSymmetra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoadhog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReinhardt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPharah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMercy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewHero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewHero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZenyatta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZarya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinston, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWidowmaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTracer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReticleColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picWeapon1 As PictureBox
    Friend WithEvents picWeapon2 As PictureBox
    Friend WithEvents picWeapon3 As PictureBox
    Friend WithEvents picSwapPlate As PictureBox
    Friend WithEvents barVote3 As PictureBox
    Friend WithEvents barVote2 As PictureBox
    Friend WithEvents barVote1 As PictureBox
    Friend WithEvents lblWeaponName1 As Label
    Friend WithEvents lblWeaponName2 As Label
    Friend WithEvents lblWeaponName3 As Label
    Friend WithEvents cmdVote1 As Button
    Friend WithEvents txtVote1 As TextBox
    Friend WithEvents txtVote2 As TextBox
    Friend WithEvents cmdVote2 As Button
    Friend WithEvents txtVote3 As TextBox
    Friend WithEvents cmdVote3 As Button
    Friend WithEvents txtTotalVotes As TextBox
    Friend WithEvents cmdUpDown As Button
    Friend WithEvents tmrUpDown As Timer
    Friend WithEvents txtUpDown As TextBox
    Friend WithEvents pic76 As PictureBox
    Friend WithEvents picBastion As PictureBox
    Friend WithEvents picGenji As PictureBox
    Friend WithEvents picDVa As PictureBox
    Friend WithEvents picMcCree As PictureBox
    Friend WithEvents picLucio As PictureBox
    Friend WithEvents picJunkrat As PictureBox
    Friend WithEvents picHanzo As PictureBox
    Friend WithEvents picTorbjorn As PictureBox
    Friend WithEvents picSymmetra As PictureBox
    Friend WithEvents picRoadhog As PictureBox
    Friend WithEvents picReinhardt As PictureBox
    Friend WithEvents picReaper As PictureBox
    Friend WithEvents picPharah As PictureBox
    Friend WithEvents picMercy As PictureBox
    Friend WithEvents picMei As PictureBox
    Friend WithEvents picNewHero2 As PictureBox
    Friend WithEvents picNewHero1 As PictureBox
    Friend WithEvents picAna As PictureBox
    Friend WithEvents picZenyatta As PictureBox
    Friend WithEvents picZarya As PictureBox
    Friend WithEvents picWinston As PictureBox
    Friend WithEvents picWidowmaker As PictureBox
    Friend WithEvents picTracer As PictureBox
    Friend WithEvents cmdRandomHeroes As Button
    Friend WithEvents txtRandomHero1 As TextBox
    Friend WithEvents txtRandomHero2 As TextBox
    Friend WithEvents txtRandomHero3 As TextBox
    Friend WithEvents txtLastHero As TextBox
    Friend WithEvents cmdStartVote As Button
    Friend WithEvents tmrVote As Timer
    Friend WithEvents txtVoteCountdown As TextBox
    Friend WithEvents cmdSwitchHeroes As Button
    Friend WithEvents tmrReticleCheck As Timer
    Friend WithEvents txtReticleColor As TextBox
    Friend WithEvents picReticleColor As PictureBox
    Friend WithEvents tmrHotkey As Timer
    Friend WithEvents tmrDelayHeroSwitch As Timer
    Friend WithEvents txtPlayerStatus As TextBox
    Friend WithEvents txtDelayHeroSwitch As TextBox
    Friend WithEvents txtDelayVote As TextBox
    Friend WithEvents tmrDelayVote As Timer
End Class
