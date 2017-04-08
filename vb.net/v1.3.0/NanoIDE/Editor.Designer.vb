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
        Me.SaveFileIcon = New System.Windows.Forms.PictureBox()
        Me.OpenFileIcon = New System.Windows.Forms.PictureBox()
        Me.NewFileIcon = New System.Windows.Forms.PictureBox()
        Me.SaveFileLabel = New System.Windows.Forms.Label()
        Me.OpenFileLabel = New System.Windows.Forms.Label()
        Me.NewFileLabel = New System.Windows.Forms.Label()
        Me.MenuIcon = New System.Windows.Forms.PictureBox()
        Me.TopLogo = New System.Windows.Forms.PictureBox()
        Me.ContextMenuLabel = New System.Windows.Forms.Label()
        Me.BottomBar = New System.Windows.Forms.Panel()
        Me.SettingsIcon = New System.Windows.Forms.PictureBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TextArea = New System.Windows.Forms.RichTextBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TopMenu.SuspendLayout()
        CType(Me.SaveFileIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenFileIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewFileIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomBar.SuspendLayout()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenu
        '
        Me.TopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TopMenu.Controls.Add(Me.SaveFileIcon)
        Me.TopMenu.Controls.Add(Me.OpenFileIcon)
        Me.TopMenu.Controls.Add(Me.NewFileIcon)
        Me.TopMenu.Controls.Add(Me.SaveFileLabel)
        Me.TopMenu.Controls.Add(Me.OpenFileLabel)
        Me.TopMenu.Controls.Add(Me.NewFileLabel)
        Me.TopMenu.Controls.Add(Me.MenuIcon)
        Me.TopMenu.Controls.Add(Me.TopLogo)
        Me.TopMenu.Controls.Add(Me.ContextMenuLabel)
        Me.TopMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.TopMenu.Location = New System.Drawing.Point(-5, -4)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(732, 59)
        Me.TopMenu.TabIndex = 1
        '
        'SaveFileIcon
        '
        Me.SaveFileIcon.Image = CType(resources.GetObject("SaveFileIcon.Image"), System.Drawing.Image)
        Me.SaveFileIcon.Location = New System.Drawing.Point(336, 20)
        Me.SaveFileIcon.Name = "SaveFileIcon"
        Me.SaveFileIcon.Size = New System.Drawing.Size(22, 22)
        Me.SaveFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SaveFileIcon.TabIndex = 13
        Me.SaveFileIcon.TabStop = False
        '
        'OpenFileIcon
        '
        Me.OpenFileIcon.Image = CType(resources.GetObject("OpenFileIcon.Image"), System.Drawing.Image)
        Me.OpenFileIcon.Location = New System.Drawing.Point(226, 20)
        Me.OpenFileIcon.Name = "OpenFileIcon"
        Me.OpenFileIcon.Size = New System.Drawing.Size(22, 22)
        Me.OpenFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OpenFileIcon.TabIndex = 12
        Me.OpenFileIcon.TabStop = False
        '
        'NewFileIcon
        '
        Me.NewFileIcon.Image = CType(resources.GetObject("NewFileIcon.Image"), System.Drawing.Image)
        Me.NewFileIcon.Location = New System.Drawing.Point(133, 20)
        Me.NewFileIcon.Name = "NewFileIcon"
        Me.NewFileIcon.Size = New System.Drawing.Size(22, 22)
        Me.NewFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NewFileIcon.TabIndex = 11
        Me.NewFileIcon.TabStop = False
        '
        'SaveFileLabel
        '
        Me.SaveFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveFileLabel.ForeColor = System.Drawing.Color.White
        Me.SaveFileLabel.Location = New System.Drawing.Point(314, 13)
        Me.SaveFileLabel.Name = "SaveFileLabel"
        Me.SaveFileLabel.Size = New System.Drawing.Size(95, 33)
        Me.SaveFileLabel.TabIndex = 10
        Me.SaveFileLabel.Text = "Save"
        Me.SaveFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileLabel
        '
        Me.OpenFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileLabel.ForeColor = System.Drawing.Color.White
        Me.OpenFileLabel.Location = New System.Drawing.Point(213, 13)
        Me.OpenFileLabel.Name = "OpenFileLabel"
        Me.OpenFileLabel.Size = New System.Drawing.Size(95, 33)
        Me.OpenFileLabel.TabIndex = 8
        Me.OpenFileLabel.Text = "Open"
        Me.OpenFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewFileLabel
        '
        Me.NewFileLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFileLabel.ForeColor = System.Drawing.Color.White
        Me.NewFileLabel.Location = New System.Drawing.Point(112, 13)
        Me.NewFileLabel.Name = "NewFileLabel"
        Me.NewFileLabel.Size = New System.Drawing.Size(95, 33)
        Me.NewFileLabel.TabIndex = 6
        Me.NewFileLabel.Text = "New"
        Me.NewFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuIcon
        '
        Me.MenuIcon.Image = CType(resources.GetObject("MenuIcon.Image"), System.Drawing.Image)
        Me.MenuIcon.Location = New System.Drawing.Point(19, 20)
        Me.MenuIcon.Name = "MenuIcon"
        Me.MenuIcon.Size = New System.Drawing.Size(22, 22)
        Me.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuIcon.TabIndex = 5
        Me.MenuIcon.TabStop = False
        '
        'TopLogo
        '
        Me.TopLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopLogo.Image = CType(resources.GetObject("TopLogo.Image"), System.Drawing.Image)
        Me.TopLogo.Location = New System.Drawing.Point(667, 13)
        Me.TopLogo.Name = "TopLogo"
        Me.TopLogo.Size = New System.Drawing.Size(42, 33)
        Me.TopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TopLogo.TabIndex = 4
        Me.TopLogo.TabStop = False
        '
        'ContextMenuLabel
        '
        Me.ContextMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuLabel.ForeColor = System.Drawing.Color.White
        Me.ContextMenuLabel.Location = New System.Drawing.Point(11, 13)
        Me.ContextMenuLabel.Name = "ContextMenuLabel"
        Me.ContextMenuLabel.Size = New System.Drawing.Size(95, 33)
        Me.ContextMenuLabel.TabIndex = 1
        Me.ContextMenuLabel.Text = "Menu"
        Me.ContextMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomBar
        '
        Me.BottomBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BottomBar.Controls.Add(Me.SettingsIcon)
        Me.BottomBar.Controls.Add(Me.Status)
        Me.BottomBar.ForeColor = System.Drawing.Color.White
        Me.BottomBar.Location = New System.Drawing.Point(-8, 407)
        Me.BottomBar.Name = "BottomBar"
        Me.BottomBar.Size = New System.Drawing.Size(732, 36)
        Me.BottomBar.TabIndex = 5
        '
        'SettingsIcon
        '
        Me.SettingsIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsIcon.Image = CType(resources.GetObject("SettingsIcon.Image"), System.Drawing.Image)
        Me.SettingsIcon.Location = New System.Drawing.Point(688, 2)
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
        Me.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextArea.EnableAutoDragDrop = True
        Me.TextArea.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextArea.HideSelection = False
        Me.TextArea.Location = New System.Drawing.Point(0, 56)
        Me.TextArea.Name = "TextArea"
        Me.TextArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.TextArea.Size = New System.Drawing.Size(716, 352)
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
        'Editor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 437)
        Me.Controls.Add(Me.TextArea)
        Me.Controls.Add(Me.BottomBar)
        Me.Controls.Add(Me.TopMenu)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(499, 384)
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nano IDE"
        Me.TopMenu.ResumeLayout(False)
        CType(Me.SaveFileIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenFileIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewFileIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomBar.ResumeLayout(False)
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MenuIcon As PictureBox
    Friend WithEvents SaveFileLabel As Label
    Friend WithEvents OpenFileLabel As Label
    Friend WithEvents NewFileLabel As Label
    Friend WithEvents SaveFileIcon As PictureBox
    Friend WithEvents OpenFileIcon As PictureBox
    Friend WithEvents NewFileIcon As PictureBox
    Friend WithEvents TextArea As RichTextBox
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
