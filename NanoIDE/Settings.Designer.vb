<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextArea = New System.Windows.Forms.RichTextBox()
        Me.NotifPanel = New System.Windows.Forms.Panel()
        Me.RestartLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NotifPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 22.2!)
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FontDialog
        '
        Me.FontDialog.AllowVerticalFonts = False
        Me.FontDialog.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.FontDialog.FontMustExist = True
        Me.FontDialog.MaxSize = 32
        Me.FontDialog.MinSize = 5
        Me.FontDialog.ScriptsOnly = True
        Me.FontDialog.ShowApply = True
        Me.FontDialog.ShowColor = True
        Me.FontDialog.ShowEffects = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(224, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Change Editor Font"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 49)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nano IDE v2.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (C) 2017 Nanomotion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Quicksand Book", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(224, 223)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(29, 29)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "  "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(259, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Use Light Theme"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(660, 43)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Appearance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(220, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Editor Preview"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextArea
        '
        Me.TextArea.AcceptsTab = True
        Me.TextArea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextArea.AutoWordSelection = True
        Me.TextArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextArea.EnableAutoDragDrop = True
        Me.TextArea.Font = New System.Drawing.Font("Menlo", 9.0!)
        Me.TextArea.ForeColor = System.Drawing.Color.White
        Me.TextArea.HideSelection = False
        Me.TextArea.Location = New System.Drawing.Point(224, 362)
        Me.TextArea.Name = "TextArea"
        Me.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TextArea.Size = New System.Drawing.Size(236, 138)
        Me.TextArea.TabIndex = 9
        Me.TextArea.TabStop = False
        Me.TextArea.Text = "Your editor should look something like this"
        '
        'NotifPanel
        '
        Me.NotifPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.NotifPanel.Controls.Add(Me.RestartLabel)
        Me.NotifPanel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifPanel.Location = New System.Drawing.Point(-1, -1)
        Me.NotifPanel.Name = "NotifPanel"
        Me.NotifPanel.Size = New System.Drawing.Size(689, 40)
        Me.NotifPanel.TabIndex = 10
        '
        'RestartLabel
        '
        Me.RestartLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestartLabel.Location = New System.Drawing.Point(3, 4)
        Me.RestartLabel.Name = "RestartLabel"
        Me.RestartLabel.Size = New System.Drawing.Size(683, 30)
        Me.RestartLabel.TabIndex = 11
        Me.RestartLabel.Text = "Restart Nano IDE to apply these settings"
        Me.RestartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(224, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 37)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Open Config File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 607)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NotifPanel)
        Me.Controls.Add(Me.TextArea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.NotifPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextArea As RichTextBox
    Friend WithEvents NotifPanel As Panel
    Friend WithEvents RestartLabel As Label
    Friend WithEvents Button2 As Button
End Class
