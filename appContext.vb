Imports System.Windows.Forms
Imports System.Drawing
Public Class AppContext
    Inherits ApplicationContext
 
    Private WithEvents Tray As NotifyIcon
    Private WithEvents MainMenu As ContextMenuStrip
    Private WithEvents mnuDisplayForm As ToolStripMenuItem
    Private WithEvents mnuSep1 As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem
    Private WithEvents Timer1 As Timer
    Private WithEvents myHotkeys As New frmHotkeys


    Public Sub New()
        'Initialize the menus
        mnuDisplayForm = New ToolStripMenuItem("Beep")
        mnuSep1 = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem("Exit")
        MainMenu = New ContextMenuStrip
        MainMenu.Items.AddRange(New ToolStripItem() {mnuDisplayForm, mnuSep1, mnuExit})
        Timer1 = new timer()
        Timer1.interval = 50000
        Timer1.enabled = true

        'Initialize the tray
        Tray = New NotifyIcon
        Tray.Icon = My.Res.beakerIcon
        'Tray.Icon = New Icon("res\audio-spectrum-8x.ico")
        'Tray.Icon = New Icon("appicon.ico")
        Tray.ContextMenuStrip = MainMenu
        Tray.Text = "Formless tray application"
        
        addhandler mnuDisplayForm.Click, addressof mnuItemClick
        addhandler mnuExit.Click, addressof mnuItemClick
        addhandler Tray.DoubleClick, addressof TrayDoubleClick
        addhandler Timer1.Tick, addressof TimerTick

        'Display
        Tray.Visible = True

    End Sub
 
    Private Sub AppContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.ThreadExit
        'Guarantees that the icon will not linger.
        Tray.Visible = False
    End Sub

End Class