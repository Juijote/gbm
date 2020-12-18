﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameManager
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnWineConfig = New System.Windows.Forms.Button()
        Me.lblOS = New System.Windows.Forms.Label()
        Me.cboOS = New System.Windows.Forms.ComboBox()
        Me.chkRecurseSubFolders = New System.Windows.Forms.CheckBox()
        Me.btnGameID = New System.Windows.Forms.Button()
        Me.chkRegEx = New System.Windows.Forms.CheckBox()
        Me.txtParameter = New System.Windows.Forms.TextBox()
        Me.lblParameter = New System.Windows.Forms.Label()
        Me.chkCleanFolder = New System.Windows.Forms.CheckBox()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.nudLimit = New System.Windows.Forms.NumericUpDown()
        Me.btnExclude = New System.Windows.Forms.Button()
        Me.btnInclude = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSavePathBrowse = New System.Windows.Forms.Button()
        Me.btnProcessBrowse = New System.Windows.Forms.Button()
        Me.lblSavePath = New System.Windows.Forms.Label()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtExclude = New System.Windows.Forms.TextBox()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.chkTimeStamp = New System.Windows.Forms.CheckBox()
        Me.chkFolderSave = New System.Windows.Forms.CheckBox()
        Me.txtSavePath = New System.Windows.Forms.TextBox()
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkMonitorOnly = New System.Windows.Forms.CheckBox()
        Me.lblTags = New System.Windows.Forms.LinkLabel()
        Me.btnIconBrowse = New System.Windows.Forms.Button()
        Me.txtIcon = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkEnabled = New System.Windows.Forms.CheckBox()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.optCustom = New System.Windows.Forms.RadioButton()
        Me.optBackupData = New System.Windows.Forms.RadioButton()
        Me.optPendingRestores = New System.Windows.Forms.RadioButton()
        Me.optAllGames = New System.Windows.Forms.RadioButton()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.cmsImport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsOfficial = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsOfficialWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsOfficialLinux = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtQuickFilter = New System.Windows.Forms.TextBox()
        Me.lblQuickFilter = New System.Windows.Forms.Label()
        Me.cmsBackupData = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsDeleteOne = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsImportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdvanced = New System.Windows.Forms.Button()
        Me.ttFullPath = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsLink = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsConfiguration = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLaunchSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabGameManager = New System.Windows.Forms.TabControl()
        Me.tbConfig = New System.Windows.Forms.TabPage()
        Me.grpCoreConfig = New System.Windows.Forms.GroupBox()
        Me.btnAppPathBrowse = New System.Windows.Forms.Button()
        Me.lblGamePath = New System.Windows.Forms.Label()
        Me.txtAppPath = New System.Windows.Forms.TextBox()
        Me.tbGameInfo = New System.Windows.Forms.TabPage()
        Me.grpGameInfo = New System.Windows.Forms.GroupBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.tbBackupInfo = New System.Windows.Forms.TabPage()
        Me.grpBackupInfo = New System.Windows.Forms.GroupBox()
        Me.btnMarkAsRestored = New System.Windows.Forms.Button()
        Me.lblRemote = New System.Windows.Forms.Label()
        Me.btnBackupData = New System.Windows.Forms.Button()
        Me.lblRestorePath = New System.Windows.Forms.Label()
        Me.lblLocalBackupData = New System.Windows.Forms.Label()
        Me.btnOpenBackupFolder = New System.Windows.Forms.Button()
        Me.lblBackupFile = New System.Windows.Forms.Label()
        Me.cboRemoteBackup = New System.Windows.Forms.ComboBox()
        Me.lblBackupFileData = New System.Windows.Forms.LinkLabel()
        Me.lblLocalData = New System.Windows.Forms.Label()
        Me.lblRestorePathData = New System.Windows.Forms.LinkLabel()
        CType(Me.nudLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        Me.cmsImport.SuspendLayout()
        Me.cmsBackupData.SuspendLayout()
        Me.cmsLink.SuspendLayout()
        Me.tabGameManager.SuspendLayout()
        Me.tbConfig.SuspendLayout()
        Me.grpCoreConfig.SuspendLayout()
        Me.tbGameInfo.SuspendLayout()
        Me.grpGameInfo.SuspendLayout()
        Me.tbBackupInfo.SuspendLayout()
        Me.grpBackupInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 430)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(48, 430)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "-"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(399, 120)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "&Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnWineConfig
        '
        Me.btnWineConfig.Location = New System.Drawing.Point(190, 140)
        Me.btnWineConfig.Name = "btnWineConfig"
        Me.btnWineConfig.Size = New System.Drawing.Size(175, 23)
        Me.btnWineConfig.TabIndex = 17
        Me.btnWineConfig.Text = "&Wine Configuration..."
        Me.btnWineConfig.UseVisualStyleBackColor = True
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(6, 145)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(25, 13)
        Me.lblOS.TabIndex = 15
        Me.lblOS.Text = "OS:"
        '
        'cboOS
        '
        Me.cboOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOS.FormattingEnabled = True
        Me.cboOS.Location = New System.Drawing.Point(69, 142)
        Me.cboOS.Name = "cboOS"
        Me.cboOS.Size = New System.Drawing.Size(115, 21)
        Me.cboOS.TabIndex = 16
        '
        'chkRecurseSubFolders
        '
        Me.chkRecurseSubFolders.AutoSize = True
        Me.chkRecurseSubFolders.Location = New System.Drawing.Point(479, 145)
        Me.chkRecurseSubFolders.Name = "chkRecurseSubFolders"
        Me.chkRecurseSubFolders.Size = New System.Drawing.Size(15, 14)
        Me.chkRecurseSubFolders.TabIndex = 0
        Me.chkRecurseSubFolders.TabStop = False
        Me.chkRecurseSubFolders.UseVisualStyleBackColor = True
        Me.chkRecurseSubFolders.Visible = False
        '
        'btnGameID
        '
        Me.btnGameID.Location = New System.Drawing.Point(388, 12)
        Me.btnGameID.Name = "btnGameID"
        Me.btnGameID.Size = New System.Drawing.Size(117, 23)
        Me.btnGameID.TabIndex = 2
        Me.btnGameID.Text = "&Game ID..."
        Me.btnGameID.UseVisualStyleBackColor = True
        '
        'chkRegEx
        '
        Me.chkRegEx.AutoSize = True
        Me.chkRegEx.Location = New System.Drawing.Point(388, 42)
        Me.chkRegEx.Name = "chkRegEx"
        Me.chkRegEx.Size = New System.Drawing.Size(117, 17)
        Me.chkRegEx.TabIndex = 6
        Me.chkRegEx.Text = "Regular Expression"
        Me.chkRegEx.UseVisualStyleBackColor = True
        '
        'txtParameter
        '
        Me.txtParameter.Location = New System.Drawing.Point(78, 64)
        Me.txtParameter.Name = "txtParameter"
        Me.txtParameter.Size = New System.Drawing.Size(387, 20)
        Me.txtParameter.TabIndex = 8
        '
        'lblParameter
        '
        Me.lblParameter.AutoSize = True
        Me.lblParameter.Location = New System.Drawing.Point(6, 67)
        Me.lblParameter.Name = "lblParameter"
        Me.lblParameter.Size = New System.Drawing.Size(58, 13)
        Me.lblParameter.TabIndex = 7
        Me.lblParameter.Text = "Parameter:"
        '
        'chkCleanFolder
        '
        Me.chkCleanFolder.AutoSize = True
        Me.chkCleanFolder.Location = New System.Drawing.Point(329, 173)
        Me.chkCleanFolder.Name = "chkCleanFolder"
        Me.chkCleanFolder.Size = New System.Drawing.Size(136, 17)
        Me.chkCleanFolder.TabIndex = 20
        Me.chkCleanFolder.Text = "Delete folder on restore"
        Me.chkCleanFolder.UseVisualStyleBackColor = True
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Location = New System.Drawing.Point(374, 202)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(98, 13)
        Me.lblLimit.TabIndex = 24
        Me.lblLimit.Text = "Limit (0 = Unlimited)"
        '
        'nudLimit
        '
        Me.nudLimit.Location = New System.Drawing.Point(328, 200)
        Me.nudLimit.Name = "nudLimit"
        Me.nudLimit.Size = New System.Drawing.Size(40, 20)
        Me.nudLimit.TabIndex = 23
        '
        'btnExclude
        '
        Me.btnExclude.Location = New System.Drawing.Point(9, 197)
        Me.btnExclude.Name = "btnExclude"
        Me.btnExclude.Size = New System.Drawing.Size(175, 23)
        Me.btnExclude.TabIndex = 21
        Me.btnExclude.Text = "E&xclude Items..."
        Me.btnExclude.UseVisualStyleBackColor = True
        '
        'btnInclude
        '
        Me.btnInclude.Location = New System.Drawing.Point(9, 169)
        Me.btnInclude.Name = "btnInclude"
        Me.btnInclude.Size = New System.Drawing.Size(175, 23)
        Me.btnInclude.TabIndex = 18
        Me.btnInclude.Text = "Incl&ude Items..."
        Me.btnInclude.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(443, 142)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(30, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'btnSavePathBrowse
        '
        Me.btnSavePathBrowse.Location = New System.Drawing.Point(471, 90)
        Me.btnSavePathBrowse.Name = "btnSavePathBrowse"
        Me.btnSavePathBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnSavePathBrowse.TabIndex = 11
        Me.btnSavePathBrowse.Text = "..."
        Me.btnSavePathBrowse.UseVisualStyleBackColor = True
        '
        'btnProcessBrowse
        '
        Me.btnProcessBrowse.Location = New System.Drawing.Point(352, 39)
        Me.btnProcessBrowse.Name = "btnProcessBrowse"
        Me.btnProcessBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnProcessBrowse.TabIndex = 5
        Me.btnProcessBrowse.Text = "..."
        Me.btnProcessBrowse.UseVisualStyleBackColor = True
        '
        'lblSavePath
        '
        Me.lblSavePath.AutoSize = True
        Me.lblSavePath.Location = New System.Drawing.Point(6, 91)
        Me.lblSavePath.Name = "lblSavePath"
        Me.lblSavePath.Size = New System.Drawing.Size(60, 13)
        Me.lblSavePath.TabIndex = 9
        Me.lblSavePath.Text = "Save Path:"
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Location = New System.Drawing.Point(6, 42)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(48, 13)
        Me.lblProcess.TabIndex = 3
        Me.lblProcess.Text = "Process:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtExclude
        '
        Me.txtExclude.Location = New System.Drawing.Point(407, 142)
        Me.txtExclude.Name = "txtExclude"
        Me.txtExclude.Size = New System.Drawing.Size(30, 20)
        Me.txtExclude.TabIndex = 0
        Me.txtExclude.TabStop = False
        Me.txtExclude.Visible = False
        '
        'txtFileType
        '
        Me.txtFileType.Location = New System.Drawing.Point(371, 142)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(30, 20)
        Me.txtFileType.TabIndex = 0
        Me.txtFileType.TabStop = False
        Me.txtFileType.Visible = False
        '
        'chkTimeStamp
        '
        Me.chkTimeStamp.AutoSize = True
        Me.chkTimeStamp.Location = New System.Drawing.Point(190, 201)
        Me.chkTimeStamp.Name = "chkTimeStamp"
        Me.chkTimeStamp.Size = New System.Drawing.Size(133, 17)
        Me.chkTimeStamp.TabIndex = 22
        Me.chkTimeStamp.Text = "Save multiple backups"
        Me.chkTimeStamp.UseVisualStyleBackColor = True
        '
        'chkFolderSave
        '
        Me.chkFolderSave.AutoSize = True
        Me.chkFolderSave.Location = New System.Drawing.Point(190, 173)
        Me.chkFolderSave.Name = "chkFolderSave"
        Me.chkFolderSave.Size = New System.Drawing.Size(109, 17)
        Me.chkFolderSave.TabIndex = 19
        Me.chkFolderSave.Text = "Save entire folder"
        Me.chkFolderSave.UseVisualStyleBackColor = True
        '
        'txtSavePath
        '
        Me.txtSavePath.Location = New System.Drawing.Point(78, 90)
        Me.txtSavePath.Name = "txtSavePath"
        Me.txtSavePath.Size = New System.Drawing.Size(387, 20)
        Me.txtSavePath.TabIndex = 10
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(78, 39)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(268, 20)
        Me.txtProcess.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(78, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(304, 20)
        Me.txtName.TabIndex = 1
        '
        'chkMonitorOnly
        '
        Me.chkMonitorOnly.AutoSize = True
        Me.chkMonitorOnly.Location = New System.Drawing.Point(124, 226)
        Me.chkMonitorOnly.Name = "chkMonitorOnly"
        Me.chkMonitorOnly.Size = New System.Drawing.Size(83, 17)
        Me.chkMonitorOnly.TabIndex = 26
        Me.chkMonitorOnly.Text = "Monitor only"
        Me.chkMonitorOnly.UseVisualStyleBackColor = True
        '
        'lblTags
        '
        Me.lblTags.ActiveLinkColor = System.Drawing.SystemColors.ControlText
        Me.lblTags.AutoEllipsis = True
        Me.lblTags.LinkColor = System.Drawing.SystemColors.ControlText
        Me.lblTags.Location = New System.Drawing.Point(6, 170)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(496, 40)
        Me.lblTags.TabIndex = 11
        Me.lblTags.TabStop = True
        Me.lblTags.Text = "Manage Tags"
        '
        'btnIconBrowse
        '
        Me.btnIconBrowse.Location = New System.Drawing.Point(421, 114)
        Me.btnIconBrowse.Name = "btnIconBrowse"
        Me.btnIconBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnIconBrowse.TabIndex = 8
        Me.btnIconBrowse.Text = "..."
        Me.btnIconBrowse.UseVisualStyleBackColor = True
        '
        'txtIcon
        '
        Me.txtIcon.Location = New System.Drawing.Point(74, 114)
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(341, 20)
        Me.txtIcon.TabIndex = 7
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(6, 88)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(45, 13)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version:"
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(74, 88)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(377, 20)
        Me.txtVersion.TabIndex = 5
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(74, 62)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(377, 20)
        Me.txtCompany.TabIndex = 3
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(6, 62)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(54, 13)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "Company:"
        '
        'pbIcon
        '
        Me.pbIcon.InitialImage = Nothing
        Me.pbIcon.Location = New System.Drawing.Point(457, 114)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(48, 48)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 15
        Me.pbIcon.TabStop = False
        '
        'lblIcon
        '
        Me.lblIcon.AutoSize = True
        Me.lblIcon.Location = New System.Drawing.Point(6, 114)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.Size = New System.Drawing.Size(31, 13)
        Me.lblIcon.TabIndex = 6
        Me.lblIcon.Text = "Icon:"
        '
        'nudHours
        '
        Me.nudHours.DecimalPlaces = 1
        Me.nudHours.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudHours.Location = New System.Drawing.Point(74, 142)
        Me.nudHours.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(88, 20)
        Me.nudHours.TabIndex = 10
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(8, 141)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(38, 13)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "Hours:"
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(318, 120)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(75, 23)
        Me.btnRestore.TabIndex = 10
        Me.btnRestore.Text = "&Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(612, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstGames
        '
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.Location = New System.Drawing.Point(12, 160)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstGames.Size = New System.Drawing.Size(228, 264)
        Me.lstGames.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(693, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Location = New System.Drawing.Point(9, 226)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(109, 17)
        Me.chkEnabled.TabIndex = 25
        Me.chkEnabled.Text = "Monitor this game"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.optCustom)
        Me.grpFilter.Controls.Add(Me.optBackupData)
        Me.grpFilter.Controls.Add(Me.optPendingRestores)
        Me.grpFilter.Controls.Add(Me.optAllGames)
        Me.grpFilter.Location = New System.Drawing.Point(12, 12)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(228, 113)
        Me.grpFilter.TabIndex = 0
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Games Filter"
        '
        'optCustom
        '
        Me.optCustom.AutoSize = True
        Me.optCustom.Location = New System.Drawing.Point(6, 87)
        Me.optCustom.Name = "optCustom"
        Me.optCustom.Size = New System.Drawing.Size(60, 17)
        Me.optCustom.TabIndex = 3
        Me.optCustom.Text = "Custom"
        Me.optCustom.UseVisualStyleBackColor = True
        '
        'optBackupData
        '
        Me.optBackupData.AutoSize = True
        Me.optBackupData.Location = New System.Drawing.Point(6, 41)
        Me.optBackupData.Name = "optBackupData"
        Me.optBackupData.Size = New System.Drawing.Size(91, 17)
        Me.optBackupData.TabIndex = 1
        Me.optBackupData.Text = "Backups Only"
        Me.optBackupData.UseVisualStyleBackColor = True
        '
        'optPendingRestores
        '
        Me.optPendingRestores.AutoSize = True
        Me.optPendingRestores.Location = New System.Drawing.Point(6, 64)
        Me.optPendingRestores.Name = "optPendingRestores"
        Me.optPendingRestores.Size = New System.Drawing.Size(134, 17)
        Me.optPendingRestores.TabIndex = 2
        Me.optPendingRestores.Text = "New Backups Pending"
        Me.optPendingRestores.UseVisualStyleBackColor = True
        '
        'optAllGames
        '
        Me.optAllGames.AutoSize = True
        Me.optAllGames.Checked = True
        Me.optAllGames.Location = New System.Drawing.Point(6, 20)
        Me.optAllGames.Name = "optAllGames"
        Me.optAllGames.Size = New System.Drawing.Size(36, 17)
        Me.optAllGames.TabIndex = 0
        Me.optAllGames.TabStop = True
        Me.optAllGames.Text = "All"
        Me.optAllGames.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(84, 430)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(165, 430)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'cmsImport
        '
        Me.cmsImport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsOfficial, Me.cmsFile})
        Me.cmsImport.Name = "cmsImport"
        Me.cmsImport.ShowImageMargin = False
        Me.cmsImport.Size = New System.Drawing.Size(118, 48)
        '
        'cmsOfficial
        '
        Me.cmsOfficial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsOfficialWindows, Me.cmsOfficialLinux})
        Me.cmsOfficial.Name = "cmsOfficial"
        Me.cmsOfficial.Size = New System.Drawing.Size(117, 22)
        Me.cmsOfficial.Text = "&Official List..."
        '
        'cmsOfficialWindows
        '
        Me.cmsOfficialWindows.Name = "cmsOfficialWindows"
        Me.cmsOfficialWindows.Size = New System.Drawing.Size(132, 22)
        Me.cmsOfficialWindows.Text = "&Windows..."
        '
        'cmsOfficialLinux
        '
        Me.cmsOfficialLinux.Name = "cmsOfficialLinux"
        Me.cmsOfficialLinux.Size = New System.Drawing.Size(132, 22)
        Me.cmsOfficialLinux.Text = "&Linux..."
        '
        'cmsFile
        '
        Me.cmsFile.Name = "cmsFile"
        Me.cmsFile.Size = New System.Drawing.Size(117, 22)
        Me.cmsFile.Text = "&File..."
        '
        'txtQuickFilter
        '
        Me.txtQuickFilter.Location = New System.Drawing.Point(80, 134)
        Me.txtQuickFilter.Name = "txtQuickFilter"
        Me.txtQuickFilter.Size = New System.Drawing.Size(160, 20)
        Me.txtQuickFilter.TabIndex = 2
        '
        'lblQuickFilter
        '
        Me.lblQuickFilter.AutoSize = True
        Me.lblQuickFilter.Location = New System.Drawing.Point(12, 137)
        Me.lblQuickFilter.Name = "lblQuickFilter"
        Me.lblQuickFilter.Size = New System.Drawing.Size(63, 13)
        Me.lblQuickFilter.TabIndex = 1
        Me.lblQuickFilter.Text = "Quick Filter:"
        '
        'cmsBackupData
        '
        Me.cmsBackupData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsDeleteOne, Me.cmsDeleteAll, Me.cmsImportData})
        Me.cmsBackupData.Name = "cmsDeleteBackup"
        Me.cmsBackupData.ShowImageMargin = False
        Me.cmsBackupData.Size = New System.Drawing.Size(130, 70)
        '
        'cmsDeleteOne
        '
        Me.cmsDeleteOne.Name = "cmsDeleteOne"
        Me.cmsDeleteOne.Size = New System.Drawing.Size(129, 22)
        Me.cmsDeleteOne.Text = "Delete &Selected"
        '
        'cmsDeleteAll
        '
        Me.cmsDeleteAll.Name = "cmsDeleteAll"
        Me.cmsDeleteAll.Size = New System.Drawing.Size(129, 22)
        Me.cmsDeleteAll.Text = "Delete &All"
        '
        'cmsImportData
        '
        Me.cmsImportData.Name = "cmsImportData"
        Me.cmsImportData.Size = New System.Drawing.Size(129, 22)
        Me.cmsImportData.Text = "&Import Backup"
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Location = New System.Drawing.Point(531, 305)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(75, 23)
        Me.btnAdvanced.TabIndex = 9
        Me.btnAdvanced.Text = "&Advanced"
        Me.btnAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdvanced.UseVisualStyleBackColor = True
        '
        'ttFullPath
        '
        Me.ttFullPath.AutoPopDelay = 5000
        Me.ttFullPath.InitialDelay = 300
        Me.ttFullPath.ReshowDelay = 60
        '
        'cmsLink
        '
        Me.cmsLink.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsProcess, Me.cmsConfiguration, Me.cmsLaunchSettings})
        Me.cmsLink.Name = "cmsLinks"
        Me.cmsLink.ShowImageMargin = False
        Me.cmsLink.Size = New System.Drawing.Size(158, 70)
        '
        'cmsProcess
        '
        Me.cmsProcess.Name = "cmsProcess"
        Me.cmsProcess.Size = New System.Drawing.Size(157, 22)
        Me.cmsProcess.Text = "Link &Process..."
        '
        'cmsConfiguration
        '
        Me.cmsConfiguration.Name = "cmsConfiguration"
        Me.cmsConfiguration.Size = New System.Drawing.Size(157, 22)
        Me.cmsConfiguration.Text = "Link &Configuration..."
        '
        'cmsLaunchSettings
        '
        Me.cmsLaunchSettings.Name = "cmsLaunchSettings"
        Me.cmsLaunchSettings.Size = New System.Drawing.Size(157, 22)
        Me.cmsLaunchSettings.Text = "&Launch Settings..."
        '
        'ttHelp
        '
        Me.ttHelp.AutoPopDelay = 5000
        Me.ttHelp.InitialDelay = 300
        Me.ttHelp.ReshowDelay = 60
        '
        'tabGameManager
        '
        Me.tabGameManager.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabGameManager.Controls.Add(Me.tbConfig)
        Me.tabGameManager.Controls.Add(Me.tbGameInfo)
        Me.tabGameManager.Controls.Add(Me.tbBackupInfo)
        Me.tabGameManager.Location = New System.Drawing.Point(246, 12)
        Me.tabGameManager.Multiline = True
        Me.tabGameManager.Name = "tabGameManager"
        Me.tabGameManager.SelectedIndex = 0
        Me.tabGameManager.Size = New System.Drawing.Size(526, 291)
        Me.tabGameManager.TabIndex = 0
        '
        'tbConfig
        '
        Me.tbConfig.BackColor = System.Drawing.SystemColors.Control
        Me.tbConfig.Controls.Add(Me.grpCoreConfig)
        Me.tbConfig.Location = New System.Drawing.Point(4, 25)
        Me.tbConfig.Name = "tbConfig"
        Me.tbConfig.Size = New System.Drawing.Size(518, 262)
        Me.tbConfig.TabIndex = 0
        Me.tbConfig.Text = "Core Configuration"
        '
        'grpCoreConfig
        '
        Me.grpCoreConfig.Controls.Add(Me.btnAppPathBrowse)
        Me.grpCoreConfig.Controls.Add(Me.lblName)
        Me.grpCoreConfig.Controls.Add(Me.lblGamePath)
        Me.grpCoreConfig.Controls.Add(Me.txtFileType)
        Me.grpCoreConfig.Controls.Add(Me.txtAppPath)
        Me.grpCoreConfig.Controls.Add(Me.txtExclude)
        Me.grpCoreConfig.Controls.Add(Me.btnWineConfig)
        Me.grpCoreConfig.Controls.Add(Me.chkTimeStamp)
        Me.grpCoreConfig.Controls.Add(Me.lblOS)
        Me.grpCoreConfig.Controls.Add(Me.chkFolderSave)
        Me.grpCoreConfig.Controls.Add(Me.txtName)
        Me.grpCoreConfig.Controls.Add(Me.btnSavePathBrowse)
        Me.grpCoreConfig.Controls.Add(Me.cboOS)
        Me.grpCoreConfig.Controls.Add(Me.txtSavePath)
        Me.grpCoreConfig.Controls.Add(Me.txtID)
        Me.grpCoreConfig.Controls.Add(Me.chkRecurseSubFolders)
        Me.grpCoreConfig.Controls.Add(Me.lblSavePath)
        Me.grpCoreConfig.Controls.Add(Me.txtProcess)
        Me.grpCoreConfig.Controls.Add(Me.btnInclude)
        Me.grpCoreConfig.Controls.Add(Me.chkEnabled)
        Me.grpCoreConfig.Controls.Add(Me.btnProcessBrowse)
        Me.grpCoreConfig.Controls.Add(Me.chkMonitorOnly)
        Me.grpCoreConfig.Controls.Add(Me.btnExclude)
        Me.grpCoreConfig.Controls.Add(Me.btnGameID)
        Me.grpCoreConfig.Controls.Add(Me.chkRegEx)
        Me.grpCoreConfig.Controls.Add(Me.txtParameter)
        Me.grpCoreConfig.Controls.Add(Me.nudLimit)
        Me.grpCoreConfig.Controls.Add(Me.chkCleanFolder)
        Me.grpCoreConfig.Controls.Add(Me.lblProcess)
        Me.grpCoreConfig.Controls.Add(Me.lblParameter)
        Me.grpCoreConfig.Controls.Add(Me.lblLimit)
        Me.grpCoreConfig.Location = New System.Drawing.Point(3, 3)
        Me.grpCoreConfig.Name = "grpCoreConfig"
        Me.grpCoreConfig.Size = New System.Drawing.Size(511, 256)
        Me.grpCoreConfig.TabIndex = 0
        Me.grpCoreConfig.TabStop = False
        '
        'btnAppPathBrowse
        '
        Me.btnAppPathBrowse.Location = New System.Drawing.Point(471, 116)
        Me.btnAppPathBrowse.Name = "btnAppPathBrowse"
        Me.btnAppPathBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnAppPathBrowse.TabIndex = 14
        Me.btnAppPathBrowse.Text = "..."
        Me.btnAppPathBrowse.UseVisualStyleBackColor = True
        '
        'lblGamePath
        '
        Me.lblGamePath.AutoSize = True
        Me.lblGamePath.Location = New System.Drawing.Point(6, 116)
        Me.lblGamePath.Name = "lblGamePath"
        Me.lblGamePath.Size = New System.Drawing.Size(63, 13)
        Me.lblGamePath.TabIndex = 12
        Me.lblGamePath.Text = "Game Path:"
        '
        'txtAppPath
        '
        Me.txtAppPath.Location = New System.Drawing.Point(78, 116)
        Me.txtAppPath.Name = "txtAppPath"
        Me.txtAppPath.Size = New System.Drawing.Size(387, 20)
        Me.txtAppPath.TabIndex = 13
        '
        'tbGameInfo
        '
        Me.tbGameInfo.BackColor = System.Drawing.SystemColors.Control
        Me.tbGameInfo.Controls.Add(Me.grpGameInfo)
        Me.tbGameInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbGameInfo.Name = "tbGameInfo"
        Me.tbGameInfo.Size = New System.Drawing.Size(518, 262)
        Me.tbGameInfo.TabIndex = 1
        Me.tbGameInfo.Text = "Game Information"
        '
        'grpGameInfo
        '
        Me.grpGameInfo.Controls.Add(Me.lblComments)
        Me.grpGameInfo.Controls.Add(Me.txtComments)
        Me.grpGameInfo.Controls.Add(Me.pbIcon)
        Me.grpGameInfo.Controls.Add(Me.lblTags)
        Me.grpGameInfo.Controls.Add(Me.lblIcon)
        Me.grpGameInfo.Controls.Add(Me.btnIconBrowse)
        Me.grpGameInfo.Controls.Add(Me.nudHours)
        Me.grpGameInfo.Controls.Add(Me.txtIcon)
        Me.grpGameInfo.Controls.Add(Me.txtCompany)
        Me.grpGameInfo.Controls.Add(Me.lblVersion)
        Me.grpGameInfo.Controls.Add(Me.lblHours)
        Me.grpGameInfo.Controls.Add(Me.lblCompany)
        Me.grpGameInfo.Controls.Add(Me.txtVersion)
        Me.grpGameInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpGameInfo.Name = "grpGameInfo"
        Me.grpGameInfo.Size = New System.Drawing.Size(511, 256)
        Me.grpGameInfo.TabIndex = 0
        Me.grpGameInfo.TabStop = False
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(6, 16)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(59, 13)
        Me.lblComments.TabIndex = 0
        Me.lblComments.Text = "Comments:"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(74, 16)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(377, 40)
        Me.txtComments.TabIndex = 1
        '
        'tbBackupInfo
        '
        Me.tbBackupInfo.BackColor = System.Drawing.SystemColors.Control
        Me.tbBackupInfo.Controls.Add(Me.grpBackupInfo)
        Me.tbBackupInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbBackupInfo.Name = "tbBackupInfo"
        Me.tbBackupInfo.Size = New System.Drawing.Size(518, 262)
        Me.tbBackupInfo.TabIndex = 2
        Me.tbBackupInfo.Text = "Backup Information"
        '
        'grpBackupInfo
        '
        Me.grpBackupInfo.Controls.Add(Me.btnMarkAsRestored)
        Me.grpBackupInfo.Controls.Add(Me.lblRemote)
        Me.grpBackupInfo.Controls.Add(Me.btnBackupData)
        Me.grpBackupInfo.Controls.Add(Me.lblRestorePath)
        Me.grpBackupInfo.Controls.Add(Me.btnRestore)
        Me.grpBackupInfo.Controls.Add(Me.lblLocalBackupData)
        Me.grpBackupInfo.Controls.Add(Me.btnOpenBackupFolder)
        Me.grpBackupInfo.Controls.Add(Me.lblBackupFile)
        Me.grpBackupInfo.Controls.Add(Me.btnBackup)
        Me.grpBackupInfo.Controls.Add(Me.cboRemoteBackup)
        Me.grpBackupInfo.Controls.Add(Me.lblBackupFileData)
        Me.grpBackupInfo.Controls.Add(Me.lblLocalData)
        Me.grpBackupInfo.Controls.Add(Me.lblRestorePathData)
        Me.grpBackupInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpBackupInfo.Name = "grpBackupInfo"
        Me.grpBackupInfo.Size = New System.Drawing.Size(511, 256)
        Me.grpBackupInfo.TabIndex = 0
        Me.grpBackupInfo.TabStop = False
        '
        'btnMarkAsRestored
        '
        Me.btnMarkAsRestored.Image = Global.GBM.My.Resources.Resources.Icon_Checkmark
        Me.btnMarkAsRestored.Location = New System.Drawing.Point(480, 40)
        Me.btnMarkAsRestored.Name = "btnMarkAsRestored"
        Me.btnMarkAsRestored.Size = New System.Drawing.Size(22, 22)
        Me.btnMarkAsRestored.TabIndex = 5
        Me.btnMarkAsRestored.UseVisualStyleBackColor = True
        '
        'lblRemote
        '
        Me.lblRemote.AutoSize = True
        Me.lblRemote.Location = New System.Drawing.Point(6, 16)
        Me.lblRemote.Name = "lblRemote"
        Me.lblRemote.Size = New System.Drawing.Size(73, 13)
        Me.lblRemote.TabIndex = 0
        Me.lblRemote.Text = "Backup Data:"
        '
        'btnBackupData
        '
        Me.btnBackupData.Image = Global.GBM.My.Resources.Resources.Icon_Recycle
        Me.btnBackupData.Location = New System.Drawing.Point(480, 13)
        Me.btnBackupData.Name = "btnBackupData"
        Me.btnBackupData.Size = New System.Drawing.Size(22, 22)
        Me.btnBackupData.TabIndex = 2
        Me.btnBackupData.UseVisualStyleBackColor = True
        '
        'lblRestorePath
        '
        Me.lblRestorePath.AutoSize = True
        Me.lblRestorePath.Location = New System.Drawing.Point(6, 97)
        Me.lblRestorePath.Name = "lblRestorePath"
        Me.lblRestorePath.Size = New System.Drawing.Size(72, 13)
        Me.lblRestorePath.TabIndex = 8
        Me.lblRestorePath.Text = "Restore Path:"
        '
        'lblLocalBackupData
        '
        Me.lblLocalBackupData.AutoEllipsis = True
        Me.lblLocalBackupData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLocalBackupData.Location = New System.Drawing.Point(85, 40)
        Me.lblLocalBackupData.Name = "lblLocalBackupData"
        Me.lblLocalBackupData.Size = New System.Drawing.Size(389, 20)
        Me.lblLocalBackupData.TabIndex = 4
        Me.lblLocalBackupData.Tag = "wipe"
        Me.lblLocalBackupData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLocalBackupData.UseMnemonic = False
        '
        'btnOpenBackupFolder
        '
        Me.btnOpenBackupFolder.Image = Global.GBM.My.Resources.Resources.Icon_FolderOpen
        Me.btnOpenBackupFolder.Location = New System.Drawing.Point(480, 66)
        Me.btnOpenBackupFolder.Name = "btnOpenBackupFolder"
        Me.btnOpenBackupFolder.Size = New System.Drawing.Size(22, 22)
        Me.btnOpenBackupFolder.TabIndex = 7
        Me.btnOpenBackupFolder.UseVisualStyleBackColor = True
        '
        'lblBackupFile
        '
        Me.lblBackupFile.AutoSize = True
        Me.lblBackupFile.Location = New System.Drawing.Point(6, 71)
        Me.lblBackupFile.Name = "lblBackupFile"
        Me.lblBackupFile.Size = New System.Drawing.Size(66, 13)
        Me.lblBackupFile.TabIndex = 2
        Me.lblBackupFile.Text = "Backup File:"
        '
        'cboRemoteBackup
        '
        Me.cboRemoteBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemoteBackup.FormattingEnabled = True
        Me.cboRemoteBackup.Location = New System.Drawing.Point(85, 13)
        Me.cboRemoteBackup.Name = "cboRemoteBackup"
        Me.cboRemoteBackup.Size = New System.Drawing.Size(389, 21)
        Me.cboRemoteBackup.TabIndex = 1
        Me.cboRemoteBackup.Tag = "wipe"
        '
        'lblBackupFileData
        '
        Me.lblBackupFileData.ActiveLinkColor = System.Drawing.SystemColors.ControlText
        Me.lblBackupFileData.AutoEllipsis = True
        Me.lblBackupFileData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBackupFileData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblBackupFileData.LinkColor = System.Drawing.SystemColors.ControlText
        Me.lblBackupFileData.Location = New System.Drawing.Point(85, 67)
        Me.lblBackupFileData.Name = "lblBackupFileData"
        Me.lblBackupFileData.Size = New System.Drawing.Size(389, 20)
        Me.lblBackupFileData.TabIndex = 6
        Me.lblBackupFileData.Tag = "wipe"
        Me.lblBackupFileData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLocalData
        '
        Me.lblLocalData.AutoSize = True
        Me.lblLocalData.Location = New System.Drawing.Point(6, 44)
        Me.lblLocalData.Name = "lblLocalData"
        Me.lblLocalData.Size = New System.Drawing.Size(62, 13)
        Me.lblLocalData.TabIndex = 3
        Me.lblLocalData.Text = "Local Data:"
        '
        'lblRestorePathData
        '
        Me.lblRestorePathData.ActiveLinkColor = System.Drawing.SystemColors.ControlText
        Me.lblRestorePathData.AutoEllipsis = True
        Me.lblRestorePathData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRestorePathData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblRestorePathData.LinkColor = System.Drawing.SystemColors.ControlText
        Me.lblRestorePathData.Location = New System.Drawing.Point(85, 93)
        Me.lblRestorePathData.Name = "lblRestorePathData"
        Me.lblRestorePathData.Size = New System.Drawing.Size(389, 20)
        Me.lblRestorePathData.TabIndex = 9
        Me.lblRestorePathData.Tag = "wipe"
        Me.lblRestorePathData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmGameManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.tabGameManager)
        Me.Controls.Add(Me.btnAdvanced)
        Me.Controls.Add(Me.lblQuickFilter)
        Me.Controls.Add(Me.txtQuickFilter)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGameManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Manager"
        CType(Me.nudLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.cmsImport.ResumeLayout(False)
        Me.cmsBackupData.ResumeLayout(False)
        Me.cmsLink.ResumeLayout(False)
        Me.tabGameManager.ResumeLayout(False)
        Me.tbConfig.ResumeLayout(False)
        Me.grpCoreConfig.ResumeLayout(False)
        Me.grpCoreConfig.PerformLayout()
        Me.tbGameInfo.ResumeLayout(False)
        Me.grpGameInfo.ResumeLayout(False)
        Me.grpGameInfo.PerformLayout()
        Me.tbBackupInfo.ResumeLayout(False)
        Me.grpBackupInfo.ResumeLayout(False)
        Me.grpBackupInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents txtSavePath As System.Windows.Forms.TextBox
    Friend WithEvents txtProcess As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkTimeStamp As System.Windows.Forms.CheckBox
    Friend WithEvents chkFolderSave As System.Windows.Forms.CheckBox
    Friend WithEvents lblSavePath As System.Windows.Forms.Label
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtExclude As System.Windows.Forms.TextBox
    Friend WithEvents txtFileType As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePathBrowse As System.Windows.Forms.Button
    Friend WithEvents btnProcessBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents nudHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents chkMonitorOnly As System.Windows.Forms.CheckBox
    Friend WithEvents lstGames As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnIconBrowse As System.Windows.Forms.Button
    Friend WithEvents txtIcon As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents optPendingRestores As System.Windows.Forms.RadioButton
    Friend WithEvents optAllGames As System.Windows.Forms.RadioButton
    Friend WithEvents optBackupData As System.Windows.Forms.RadioButton
    Friend WithEvents optCustom As System.Windows.Forms.RadioButton
    Friend WithEvents btnInclude As System.Windows.Forms.Button
    Friend WithEvents btnExclude As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents cmsImport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOfficial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtQuickFilter As TextBox
    Friend WithEvents lblQuickFilter As Label
    Friend WithEvents lblLimit As Label
    Friend WithEvents nudLimit As NumericUpDown
    Friend WithEvents cmsBackupData As ContextMenuStrip
    Friend WithEvents cmsDeleteOne As ToolStripMenuItem
    Friend WithEvents cmsDeleteAll As ToolStripMenuItem
    Friend WithEvents chkCleanFolder As CheckBox
    Friend WithEvents txtParameter As TextBox
    Friend WithEvents lblParameter As Label
    Friend WithEvents chkRegEx As CheckBox
    Friend WithEvents btnGameID As Button
    Friend WithEvents btnAdvanced As Button
    Friend WithEvents ttFullPath As ToolTip
    Friend WithEvents cmsOfficialWindows As ToolStripMenuItem
    Friend WithEvents cmsOfficialLinux As ToolStripMenuItem
    Friend WithEvents chkRecurseSubFolders As CheckBox
    Friend WithEvents lblOS As Label
    Friend WithEvents cboOS As ComboBox
    Friend WithEvents btnWineConfig As Button
    Friend WithEvents cmsLink As ContextMenuStrip
    Friend WithEvents cmsProcess As ToolStripMenuItem
    Friend WithEvents cmsConfiguration As ToolStripMenuItem
    Friend WithEvents cmsImportData As ToolStripMenuItem
    Friend WithEvents ttHelp As ToolTip
    Friend WithEvents lblTags As LinkLabel
    Friend WithEvents cmsLaunchSettings As ToolStripMenuItem
    Friend WithEvents tabGameManager As TabControl
    Friend WithEvents tbConfig As TabPage
    Friend WithEvents tbGameInfo As TabPage
    Friend WithEvents tbBackupInfo As TabPage
    Friend WithEvents btnAppPathBrowse As Button
    Friend WithEvents lblGamePath As Label
    Friend WithEvents txtAppPath As TextBox
    Friend WithEvents lblComments As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents btnMarkAsRestored As Button
    Friend WithEvents btnBackupData As Button
    Friend WithEvents btnOpenBackupFolder As Button
    Friend WithEvents lblBackupFileData As LinkLabel
    Friend WithEvents lblRemote As Label
    Friend WithEvents lblRestorePathData As LinkLabel
    Friend WithEvents lblLocalData As Label
    Friend WithEvents cboRemoteBackup As ComboBox
    Friend WithEvents lblBackupFile As Label
    Friend WithEvents lblLocalBackupData As Label
    Friend WithEvents lblRestorePath As Label
    Friend WithEvents grpCoreConfig As GroupBox
    Friend WithEvents grpGameInfo As GroupBox
    Friend WithEvents grpBackupInfo As GroupBox
End Class
