Imports System.ComponentModel

<System.ComponentModel.ToolboxItem(True)>
Public Class ColorTabPage
    Inherits System.Windows.Forms.TabPage

    Public Sub New()
        MyBase.New()
        BackColor = System.Drawing.Color.Red
        SetDefaultColor()
    End Sub

    <Category("Appearance")>
    <Description("The color of tab header")>
    Public Property HeaderColor As Color

    Public Sub SetDefaultColor()
        HeaderColor = SystemColors.Control
    End Sub

End Class
