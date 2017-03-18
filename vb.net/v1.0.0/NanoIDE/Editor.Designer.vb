<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuLabel = New System.Windows.Forms.Label()
        Me.SaveFileLabel = New System.Windows.Forms.Label()
        Me.OpenFileLabel = New System.Windows.Forms.Label()
        Me.NewFileLabel = New System.Windows.Forms.Label()
        Me.TextArea = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-2, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 447)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nano IDE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.ContextMenuLabel)
        Me.Panel2.Controls.Add(Me.SaveFileLabel)
        Me.Panel2.Controls.Add(Me.OpenFileLabel)
        Me.Panel2.Controls.Add(Me.NewFileLabel)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-5, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 59)
        Me.Panel2.TabIndex = 1
        '
        'ContextMenuLabel
        '
        Me.ContextMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuLabel.Location = New System.Drawing.Point(17, 13)
        Me.ContextMenuLabel.Name = "ContextMenuLabel"
        Me.ContextMenuLabel.Size = New System.Drawing.Size(71, 33)
        Me.ContextMenuLabel.TabIndex = 3
        Me.ContextMenuLabel.Text = "Menu"
        Me.ContextMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveFileLabel
        '
        Me.SaveFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveFileLabel.Location = New System.Drawing.Point(248, 13)
        Me.SaveFileLabel.Name = "SaveFileLabel"
        Me.SaveFileLabel.Size = New System.Drawing.Size(71, 33)
        Me.SaveFileLabel.TabIndex = 2
        Me.SaveFileLabel.Text = "&Save"
        Me.SaveFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileLabel
        '
        Me.OpenFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileLabel.Location = New System.Drawing.Point(171, 13)
        Me.OpenFileLabel.Name = "OpenFileLabel"
        Me.OpenFileLabel.Size = New System.Drawing.Size(71, 33)
        Me.OpenFileLabel.TabIndex = 1
        Me.OpenFileLabel.Text = "&Open"
        Me.OpenFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewFileLabel
        '
        Me.NewFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFileLabel.Location = New System.Drawing.Point(94, 13)
        Me.NewFileLabel.Name = "NewFileLabel"
        Me.NewFileLabel.Size = New System.Drawing.Size(71, 33)
        Me.NewFileLabel.TabIndex = 0
        Me.NewFileLabel.Text = "&New"
        Me.NewFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextArea
        '
        Me.TextArea.AcceptsReturn = True
        Me.TextArea.AcceptsTab = True
        Me.TextArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextArea.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextArea.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextArea.Location = New System.Drawing.Point(200, 55)
        Me.TextArea.Multiline = True
        Me.TextArea.Name = "TextArea"
        Me.TextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextArea.Size = New System.Drawing.Size(457, 382)
        Me.TextArea.TabIndex = 2
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.InitialDirectory = "C:\"
        Me.OpenFileDialog.SupportMultiDottedExtensions = True
        Me.OpenFileDialog.Title = "Open File"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.SupportMultiDottedExtensions = True
        Me.SaveFileDialog.Title = "Save as"
        '
        'Editor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 437)
        Me.Controls.Add(Me.TextArea)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(345, 220)
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nano IDE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NewFileLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuLabel As Label
    Friend WithEvents SaveFileLabel As Label
    Friend WithEvents OpenFileLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextArea As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
