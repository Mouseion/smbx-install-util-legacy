﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18052
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.SMBXInstaller.Main
        End Sub
        
<<<<<<< HEAD
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = Global.SMBXInstaller.LeSplash
=======
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()> _
        Protected Overrides Sub OnCreateSplashScreen()
            Randomize()
            Dim i As Integer = LeSplash.GenerateRandomNumber(0, Int32.MaxValue)

            If i = 1 Then
                'LeSplash.BackgroundImage = Image.FromFile(".\background 1.png")
                LeSplash.BackgroundImage = Resources.background_1
            ElseIf i = 2 Then
                'LeSplash.BackgroundImage = Image.FromFile(".\background 2.png")
                LeSplash.BackgroundImage = Resources.background_2
            ElseIf i = 3 Then
                'LeSplash.BackgroundImage = Image.FromFile(".\background 3.png")
                LeSplash.BackgroundImage = Resources.background_3
            ElseIf i = 4 Then
                'LeSplash.BackgroundImage = Image.FromFile(".\background 4.png")
                LeSplash.BackgroundImage = Resources.background_4
            ElseIf i = 5 Then
                LeSplash.BackgroundImage = Resources.background_5


            End If


            Me.SplashScreen = Global.SMBXInstaller.LeSplash


>>>>>>> 1.4.1.0 Update
        End Sub
    End Class
End Namespace
