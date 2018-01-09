<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuManagement
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
        Me.Button11 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(129, 245)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(177, 60)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Συνεδριάσεις Επιτροπής Ανασκόπισης"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'frmMenuManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.Button11)
        Me.Name = "frmMenuManagement"
        Me.Controls.SetChildIndex(Me.Button11, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button11 As System.Windows.Forms.Button

End Class
