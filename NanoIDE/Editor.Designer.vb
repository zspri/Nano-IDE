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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.TopMenu = New System.Windows.Forms.Panel()
        Me.TopLogo = New System.Windows.Forms.PictureBox()
        Me.ContextMenuLabel = New System.Windows.Forms.Label()
        Me.BottomBar = New System.Windows.Forms.Panel()
        Me.SettingsIcon = New System.Windows.Forms.PictureBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TextArea = New System.Windows.Forms.RichTextBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifMenuLabel = New System.Windows.Forms.Label()
        Me.NotifLabel = New System.Windows.Forms.Label()
        Me.TopMenu.SuspendLayout()
        CType(Me.TopLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomBar.SuspendLayout()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotifPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenu
        '
        Me.TopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TopMenu.Controls.Add(Me.TopLogo)
        Me.TopMenu.Controls.Add(Me.ContextMenuLabel)
        Me.TopMenu.ForeColor = System.Drawing.Color.White
        Me.TopMenu.Location = New System.Drawing.Point(-5, -4)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(929, 59)
        Me.TopMenu.TabIndex = 1
        '
        'TopLogo
        '
        Me.TopLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopLogo.Image = CType(resources.GetObject("TopLogo.Image"), System.Drawing.Image)
        Me.TopLogo.Location = New System.Drawing.Point(864, 3)
        Me.TopLogo.Name = "TopLogo"
        Me.TopLogo.Size = New System.Drawing.Size(42, 56)
        Me.TopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TopLogo.TabIndex = 4
        Me.TopLogo.TabStop = False
        '
        'ContextMenuLabel
        '
        Me.ContextMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuLabel.ForeColor = System.Drawing.Color.White
        Me.ContextMenuLabel.Location = New System.Drawing.Point(6, 3)
        Me.ContextMenuLabel.Name = "ContextMenuLabel"
        Me.ContextMenuLabel.Size = New System.Drawing.Size(54, 54)
        Me.ContextMenuLabel.TabIndex = 1
        Me.ContextMenuLabel.Text = "☰"
        Me.ContextMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BottomBar
        '
        Me.BottomBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BottomBar.Controls.Add(Me.SettingsIcon)
        Me.BottomBar.Controls.Add(Me.Status)
        Me.BottomBar.ForeColor = System.Drawing.Color.White
        Me.BottomBar.Location = New System.Drawing.Point(-8, 570)
        Me.BottomBar.Name = "BottomBar"
        Me.BottomBar.Size = New System.Drawing.Size(929, 36)
        Me.BottomBar.TabIndex = 5
        '
        'SettingsIcon
        '
        Me.SettingsIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsIcon.Image = CType(resources.GetObject("SettingsIcon.Image"), System.Drawing.Image)
        Me.SettingsIcon.Location = New System.Drawing.Point(885, 2)
        Me.SettingsIcon.Name = "SettingsIcon"
        Me.SettingsIcon.Size = New System.Drawing.Size(32, 25)
        Me.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsIcon.TabIndex = 5
        Me.SettingsIcon.TabStop = False
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.Status.Location = New System.Drawing.Point(10, 4)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(613, 21)
        Me.Status.TabIndex = 5
        Me.Status.Text = "Loading..."
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.InitialDirectory = "C:\Users\zspri"
        Me.OpenFileDialog.SupportMultiDottedExtensions = True
        Me.OpenFileDialog.Title = "Open File"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.SupportMultiDottedExtensions = True
        Me.SaveFileDialog.Title = "Save As"
        '
        'TextArea
        '
        Me.TextArea.AcceptsTab = True
        Me.TextArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextArea.AutoWordSelection = True
        Me.TextArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextArea.EnableAutoDragDrop = True
        Me.TextArea.Font = New System.Drawing.Font("Menlo", 9.0!)
        Me.TextArea.ForeColor = System.Drawing.Color.White
        Me.TextArea.HideSelection = False
        Me.TextArea.Location = New System.Drawing.Point(0, 56)
        Me.TextArea.Name = "TextArea"
        Me.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.TextArea.Size = New System.Drawing.Size(913, 515)
        Me.TextArea.TabIndex = 6
        Me.TextArea.TabStop = False
        Me.TextArea.Text = ""
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NanoIDE"
        Me.NotifyIcon.Visible = True
        '
        'NotifPanel
        '
        Me.NotifPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotifPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.NotifPanel.Controls.Add(Me.Label1)
        Me.NotifPanel.Controls.Add(Me.NotifMenuLabel)
        Me.NotifPanel.Controls.Add(Me.NotifLabel)
        Me.NotifPanel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifPanel.Location = New System.Drawing.Point(0, -1)
        Me.NotifPanel.Name = "NotifPanel"
        Me.NotifPanel.Size = New System.Drawing.Size(921, 56)
        Me.NotifPanel.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(859, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 57)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "×"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifMenuLabel
        '
        Me.NotifMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifMenuLabel.ForeColor = System.Drawing.Color.White
        Me.NotifMenuLabel.Location = New System.Drawing.Point(3, 0)
        Me.NotifMenuLabel.Name = "NotifMenuLabel"
        Me.NotifMenuLabel.Size = New System.Drawing.Size(54, 54)
        Me.NotifMenuLabel.TabIndex = 5
        Me.NotifMenuLabel.Text = "☰"
        Me.NotifMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifLabel
        '
        Me.NotifLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotifLabel.Location = New System.Drawing.Point(3, 4)
        Me.NotifLabel.Name = "NotifLabel"
        Me.NotifLabel.Size = New System.Drawing.Size(915, 50)
        Me.NotifLabel.TabIndex = 11
        Me.NotifLabel.Text = "Loading... Please wait"
        Me.NotifLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Editor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 600)
        Me.Controls.Add(Me.NotifPanel)
        Me.Controls.Add(Me.TextArea)
        Me.Controls.Add(Me.BottomBar)
        Me.Controls.Add(Me.TopMenu)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(499, 384)
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nano IDE"
        Me.TopMenu.ResumeLayout(False)
        CType(Me.TopLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomBar.ResumeLayout(False)
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotifPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopMenu As Panel
    Friend WithEvents ContextMenuLabel As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents TopLogo As PictureBox
    Friend WithEvents BottomBar As Panel
    Friend WithEvents Status As Label
    Friend WithEvents SettingsIcon As PictureBox
    Friend WithEvents TextArea As RichTextBox
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifPanel As Panel
    Friend WithEvents NotifLabel As Label
    Friend WithEvents NotifMenuLabel As Label
    Friend WithEvents Label1 As Label
End Class
