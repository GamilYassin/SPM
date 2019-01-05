<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuProjects = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProjectsOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProjectsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProjects})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1000, 28)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuProjects
        '
        Me.mnuProjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProjectsOpen, Me.mnuProjectsAdd})
        Me.mnuProjects.Name = "mnuProjects"
        Me.mnuProjects.Size = New System.Drawing.Size(73, 24)
        Me.mnuProjects.Text = "Projects"
        '
        'mnuProjectsOpen
        '
        Me.mnuProjectsOpen.Name = "mnuProjectsOpen"
        Me.mnuProjectsOpen.Size = New System.Drawing.Size(216, 26)
        Me.mnuProjectsOpen.Text = "Open Project List"
        '
        'mnuProjectsAdd
        '
        Me.mnuProjectsAdd.Name = "mnuProjectsAdd"
        Me.mnuProjectsAdd.Size = New System.Drawing.Size(216, 26)
        Me.mnuProjectsAdd.Text = "Add New Project"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 703)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuProjects As ToolStripMenuItem
    Friend WithEvents mnuProjectsOpen As ToolStripMenuItem
    Friend WithEvents mnuProjectsAdd As ToolStripMenuItem
End Class
