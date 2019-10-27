<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyTabControl1 = New Test.MyTabControl()
        Me.ColorTabPage1 = New Test.ColorTabPage()
        Me.ColorTabPage2 = New Test.ColorTabPage()
        Me.ColorTabPage3 = New Test.ColorTabPage()
        Me.ColorTabPage4 = New Test.ColorTabPage()
        Me.ColorTabPage5 = New Test.ColorTabPage()
        Me.ColorTabPage6 = New Test.ColorTabPage()
        Me.MyTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(292, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "add new tab"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyTabControl1
        '
        Me.MyTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage1)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage2)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage3)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage4)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage5)
        Me.MyTabControl1.Controls.Add(Me.ColorTabPage6)
        Me.MyTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MyTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.MyTabControl1.Name = "MyTabControl1"
        Me.MyTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MyTabControl1.RightToLeftLayout = True
        Me.MyTabControl1.SelectedIndex = 0
        Me.MyTabControl1.Size = New System.Drawing.Size(776, 351)
        Me.MyTabControl1.TabIndex = 2
        '
        'ColorTabPage1
        '
        Me.ColorTabPage1.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage1.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage1.Name = "ColorTabPage1"
        Me.ColorTabPage1.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage1.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage1.TabIndex = 0
        Me.ColorTabPage1.Text = "تست۱"
        '
        'ColorTabPage2
        '
        Me.ColorTabPage2.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage2.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage2.Name = "ColorTabPage2"
        Me.ColorTabPage2.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage2.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage2.TabIndex = 1
        Me.ColorTabPage2.Text = "تست ۲"
        '
        'ColorTabPage3
        '
        Me.ColorTabPage3.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage3.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage3.Name = "ColorTabPage3"
        Me.ColorTabPage3.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage3.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage3.TabIndex = 2
        Me.ColorTabPage3.Text = "تست تب دراز"
        '
        'ColorTabPage4
        '
        Me.ColorTabPage4.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage4.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage4.Name = "ColorTabPage4"
        Me.ColorTabPage4.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage4.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage4.TabIndex = 3
        Me.ColorTabPage4.Text = "تست تب ۴"
        '
        'ColorTabPage5
        '
        Me.ColorTabPage5.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage5.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage5.Name = "ColorTabPage5"
        Me.ColorTabPage5.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage5.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage5.TabIndex = 4
        Me.ColorTabPage5.Text = "ColorTabPage5"
        '
        'ColorTabPage6
        '
        Me.ColorTabPage6.BackColor = System.Drawing.Color.Red
        Me.ColorTabPage6.Location = New System.Drawing.Point(4, 25)
        Me.ColorTabPage6.Name = "ColorTabPage6"
        Me.ColorTabPage6.Padding = New System.Windows.Forms.Padding(30)
        Me.ColorTabPage6.Size = New System.Drawing.Size(768, 322)
        Me.ColorTabPage6.TabIndex = 5
        Me.ColorTabPage6.Text = "تست تب ۶"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyTabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MyTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents MyTabControl1 As MyTabControl
    Friend WithEvents ColorTabPage1 As ColorTabPage
    Friend WithEvents ColorTabPage2 As ColorTabPage
    Friend WithEvents ColorTabPage3 As ColorTabPage
    Friend WithEvents ColorTabPage4 As ColorTabPage
    Friend WithEvents ColorTabPage5 As ColorTabPage
    Friend WithEvents ColorTabPage6 As ColorTabPage
End Class
