<System.ComponentModel.ToolboxItem(True)>
Public Class ColorTabPage
    Inherits System.Windows.Forms.TabPage

    Public Sub New()
        MyBase.New()
        BackColor = System.Drawing.Color.Red
        Padding = New System.Windows.Forms.Padding(30)
        SetDefaultColor()
    End Sub

    Public Property HeaderColor As Brush

    Public Sub SetDefaultColor()
        HeaderColor = Brushes.Wheat
    End Sub

End Class
