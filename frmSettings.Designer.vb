<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(100, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Χρήστες"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 60)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Θέματα"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Name = "frmSettings"
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
