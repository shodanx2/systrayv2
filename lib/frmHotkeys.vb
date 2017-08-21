Imports System.Windows.Forms
Imports System.Threading
Partial Class frmHotkeys : Inherits Form

    Public Const MOD_CONTROL As Integer = &H11
    Public Const MOD_SHIFT As Integer = &H10
    Public Const MOD_ALT As Integer = &H1
    Public Const WM_HOTKEY As Integer = &H312

    Public Declare Function RegisterHotKey Lib "user32.dll" Alias "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Public Declare Function UnregisterHotKey Lib "user32.dll" Alias "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Private Sub InitializeHotKeys()
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.D)
        RegisterHotKey(Me.Handle, 200, MOD_ALT, Keys.F)
        RegisterHotKey(Me.Handle, 300, MOD_ALT, Keys.E)
    End Sub

    Public Sub New()
        InitializeHotKeys()
    End Sub

    Protected Overrides Sub DefWndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.DefWndProc(m)
        Dim x As Long

        If m.Msg = WM_HOTKEY Then
            Select Case CType(m.WParam, Integer)
                Case 100
                    beep
                Case 200
                    beep
                    For x = 1 To 50 : Thread.Sleep(20) : Application.DoEvents() : Next x
                    beep
                Case 300
                    beep
                    For x = 1 To 50 : Thread.Sleep(20) : Application.DoEvents() : Next x
                    beep
                    For x = 1 To 50 : Thread.Sleep(20) : Application.DoEvents() : Next x
                    beep
            End Select
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frmHotkeys
        '
        Me.ClientSize = New System.Drawing.Size(149, 107)
        Me.Name = "frmHotkeys"
        Me.ResumeLayout(False)

        InitializeHotKeys()

    End Sub
End Class