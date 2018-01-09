<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits diadrasisProjects.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(157, 230)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Tasks"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(157, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 60)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Έγγραφα ΣΔΠ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(157, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 60)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Εξωτερικά Έγγραφα"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "frmReports"
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
