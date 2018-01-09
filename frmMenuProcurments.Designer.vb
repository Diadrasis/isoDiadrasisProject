<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuProcurments
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Image = Global.diadrasisProjects.My.Resources.Resources.user1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(585, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Εγκεκριμένοι Συνεργάτες"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Image = Global.diadrasisProjects.My.Resources.Resources.user3
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(183, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Κριτήρια Ικανοποίησης "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Image = Global.diadrasisProjects.My.Resources.Resources.user3
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(183, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Βαθμοί Αξιολόγησης"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Image = Global.diadrasisProjects.My.Resources.Resources.user1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(585, 337)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Εγκεκριμένοι Προμηθευτές"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Image = Global.diadrasisProjects.My.Resources.Resources.user3
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(183, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 60)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Προμηθευτές"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Image = Global.diadrasisProjects.My.Resources.Resources.user1
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(585, 403)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 60)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Κριτήρια Αξιολόγησης"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmMenuProcurments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmMenuProcurments"
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Controls.SetChildIndex(Me.Button5, 0)
        Me.Controls.SetChildIndex(Me.Button6, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
