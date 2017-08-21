Imports System.Windows.Forms
Public Module modMain
    
    public colMenuStrips as new collection

    Public Function Main(ByVal cmdArgs() As String) As Integer
	HideConsole()
        Application.EnableVisualStyles()
        Application.Run(New AppContext)
	return 0
    End Function 
    
    Public Sub mnuItemClick(ByVal sender As Object, ByVal e As System.EventArgs) 
        beep()
    End Sub
    
    Public Sub TrayDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Public Sub TimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        beep()
    End Sub

End Module