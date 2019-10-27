Imports System.ComponentModel
Imports System.Drawing.Design

<ToolboxBitmapAttribute(GetType(TabControl))>
Public Class MyTabControl
    Inherits System.Windows.Forms.TabControl

    Public Sub New()
        MyBase.New()
        DrawMode = TabDrawMode.OwnerDrawFixed
    End Sub

    <Editor(GetType(Test.TabPageCollectionEditor), GetType(UITypeEditor))>
    Public Shadows ReadOnly Property TabPages() As TabPageCollection
        Get
            Return MyBase.TabPages
        End Get
    End Property


    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        Dim page As ColorTabPage = TabPages(e.Index)
        Dim rect = e.Bounds

        If RightToLeftLayout Then
            rect.Location = New Point(Width - rect.X - rect.Width, rect.Y)
        End If

        Using headerBrush = New SolidBrush(page.HeaderColor)
            e.Graphics.FillRectangle(headerBrush, rect)
            Dim sz = e.Graphics.MeasureString(TabPages(e.Index).Text, e.Font)
            e.Graphics.DrawString(TabPages(e.Index).Text, e.Font, Brushes.Black,
                                  rect.Left + (rect.Width - sz.Width) / 2,
                                  rect.Top + (rect.Height - sz.Height) / 2 + 1)

            rect.Offset(0, 1)
            rect.Inflate(0, -1)
            e.Graphics.DrawRectangle(Pens.DarkGray, rect)
            e.DrawFocusRectangle()
        End Using
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        Debug.WriteLine(SelectedIndex)

        SetAllBeforeTabs(SelectedIndex)
    End Sub

    Public Sub SetAllBeforeTabs(tabIndex As Integer)

        For i As Integer = 0 To TabPages.Count - 1
            Dim page As ColorTabPage = TabPages(i)

            ' select before tabs
            If i < tabIndex Then
                page.HeaderColor = Color.LightGreen
            ElseIf i = tabIndex Then
                ' change selected tab header color
                page.HeaderColor = Color.Green
            Else
                ' select after tabs
                page.SetDefaultColor()
            End If

            page.Enabled = (i = tabIndex)
        Next

        Invalidate()
    End Sub

End Class
