﻿Imports GBM.My.Resources

Public Class frmLudusaviConfig
    Private oImportOptions As clsLudusaviOptions

    Property ImportOptions As clsLudusaviOptions
        Get
            Return oImportOptions
        End Get
        Set(value As clsLudusaviOptions)
            oImportOptions = value
        End Set
    End Property

    Private Sub SetForm()
        'Set Form Name
        Me.Text = frmLudusaviConfig_FormName
        Me.Icon = GBM_Icon

        'Set Form Text
        grpSearch.Text = frmLudusaviConfig_grpSearch
        grpProfileTypes.Text = frmLudusaviConfig_grpProfileTypes
        chkSavedGames.Text = frmLudusaviConfig_chkSavedGames
        chkConfigurationFiles.Text = frmLudusaviConfig_chkConfigurationFiles
        grpOperatingSystems.Text = frmLudusaviConfig_grpOperatingSystems
        chkWindows.Text = frmLudusaviConfig_chkWindows
        chkLinux.Text = frmLudusaviConfig_chkLinux
        btnOK.Text = frmLudusaviConfig_btnOK
        btnOK.Image = Multi_Ok
        btnCancel.Text = frmLudusaviConfig_btnCancel
        btnCancel.Image = Multi_Cancel

        'Set Defaults
        chkSavedGames.Checked = True

        If Not mgrCommon.IsUnix Then
            chkWindows.Checked = True
            grpOperatingSystems.Enabled = False
        Else
            chkLinux.Checked = True
        End If
    End Sub

    Private Function ValidateOptions() As Boolean
        If Not chkSavedGames.Checked And Not chkConfigurationFiles.Checked Then
            mgrCommon.ShowMessage(frmLudusaviConfig_ErrorProfileType, MsgBoxStyle.Information)
            Return False
        End If
        If Not chkWindows.Checked And Not chkLinux.Checked Then
            mgrCommon.ShowMessage(frmLudusaviConfig_ErrorOperatingSystem, MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub BuildOptions()
        oImportOptions = New clsLudusaviOptions()
        oImportOptions.Query = txtQuery.Text
        oImportOptions.IncludeSaves = chkSavedGames.Checked
        oImportOptions.IncludeConfigs = chkConfigurationFiles.Checked
        If chkWindows.Checked Then oImportOptions.IncludeOS = oImportOptions.IncludeOS Or clsLudusaviOptions.eSupportedOS.Windows
        If chkLinux.Checked Then oImportOptions.IncludeOS = oImportOptions.IncludeOS Or clsLudusaviOptions.eSupportedOS.Linux
    End Sub

    Private Sub frmConfigLudusavi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetForm()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If ValidateOptions() Then
            BuildOptions()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class