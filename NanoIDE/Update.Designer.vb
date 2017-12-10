<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewProgressBar = New System.Windows.Forms.Panel()
        Me.ProgressValue = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NewProgressBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Checking for updates..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewProgressBar
        '
        Me.NewProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.NewProgressBar.Controls.Add(Me.ProgressValue)
        Me.NewProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NewProgressBar.Location = New System.Drawing.Point(12, 75)
        Me.NewProgressBar.Name = "NewProgressBar"
        Me.NewProgressBar.Size = New System.Drawing.Size(371, 30)
        Me.NewProgressBar.TabIndex = 2
        '
        'ProgressValue
        '
        Me.ProgressValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ProgressValue.Location = New System.Drawing.Point(-1, -1)
        Me.ProgressValue.Name = "ProgressValue"
        Me.ProgressValue.Size = New System.Drawing.Size(95, 32)
        Me.ProgressValue.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 156)
        Me.Controls.Add(Me.NewProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Update"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NewProgressBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents NewProgressBar As Panel
    Friend WithEvents ProgressValue As Panel
    Friend WithEvents Timer1 As Timer
End Class
