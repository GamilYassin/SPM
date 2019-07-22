<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProject
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnPlantSelect = New System.Windows.Forms.Button()
        Me.cboSubcon = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboEpc = New System.Windows.Forms.ComboBox()
        Me.txtSAPDef = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboDcs = New System.Windows.Forms.ComboBox()
        Me.cboMechnical = New System.Windows.Forms.ComboBox()
        Me.cboElectrical = New System.Windows.Forms.ComboBox()
        Me.cboControls = New System.Windows.Forms.ComboBox()
        Me.cboHMI = New System.Windows.Forms.ComboBox()
        Me.cboPE = New System.Windows.Forms.ComboBox()
        Me.cboPM = New System.Windows.Forms.ComboBox()
        Me.cboComOps = New System.Windows.Forms.ComboBox()
        Me.cboSales = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SAP Def:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Plant Info:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "EPC (Customer):"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 412)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnPlantSelect)
        Me.TabPage1.Controls.Add(Me.cboSubcon)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.cboEpc)
        Me.TabPage1.Controls.Add(Me.txtSAPDef)
        Me.TabPage1.Controls.Add(Me.txtTitle)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Basic Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnPlantSelect
        '
        Me.btnPlantSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlantSelect.Location = New System.Drawing.Point(160, 91)
        Me.btnPlantSelect.Name = "btnPlantSelect"
        Me.btnPlantSelect.Size = New System.Drawing.Size(245, 35)
        Me.btnPlantSelect.TabIndex = 3
        Me.btnPlantSelect.Text = "Select Plant"
        Me.btnPlantSelect.UseVisualStyleBackColor = True
        '
        'cboSubcon
        '
        Me.cboSubcon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubcon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubcon.FormattingEnabled = True
        Me.cboSubcon.Location = New System.Drawing.Point(160, 210)
        Me.cboSubcon.Name = "cboSubcon"
        Me.cboSubcon.Size = New System.Drawing.Size(604, 33)
        Me.cboSubcon.TabIndex = 2
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(160, 174)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(604, 33)
        Me.cboStatus.TabIndex = 2
        '
        'cboEpc
        '
        Me.cboEpc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEpc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEpc.FormattingEnabled = True
        Me.cboEpc.Location = New System.Drawing.Point(160, 132)
        Me.cboEpc.Name = "cboEpc"
        Me.cboEpc.Size = New System.Drawing.Size(604, 33)
        Me.cboEpc.TabIndex = 2
        '
        'txtSAPDef
        '
        Me.txtSAPDef.Location = New System.Drawing.Point(160, 50)
        Me.txtSAPDef.Name = "txtSAPDef"
        Me.txtSAPDef.Size = New System.Drawing.Size(604, 31)
        Me.txtSAPDef.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(160, 13)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(604, 31)
        Me.txtTitle.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SubCon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Status:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cboDcs)
        Me.TabPage2.Controls.Add(Me.cboMechnical)
        Me.TabPage2.Controls.Add(Me.cboElectrical)
        Me.TabPage2.Controls.Add(Me.cboControls)
        Me.TabPage2.Controls.Add(Me.cboHMI)
        Me.TabPage2.Controls.Add(Me.cboPE)
        Me.TabPage2.Controls.Add(Me.cboPM)
        Me.TabPage2.Controls.Add(Me.cboComOps)
        Me.TabPage2.Controls.Add(Me.cboSales)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Team"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboDcs
        '
        Me.cboDcs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDcs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDcs.FormattingEnabled = True
        Me.cboDcs.Location = New System.Drawing.Point(200, 327)
        Me.cboDcs.Name = "cboDcs"
        Me.cboDcs.Size = New System.Drawing.Size(552, 33)
        Me.cboDcs.TabIndex = 5
        '
        'cboMechnical
        '
        Me.cboMechnical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMechnical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMechnical.FormattingEnabled = True
        Me.cboMechnical.Location = New System.Drawing.Point(200, 288)
        Me.cboMechnical.Name = "cboMechnical"
        Me.cboMechnical.Size = New System.Drawing.Size(552, 33)
        Me.cboMechnical.TabIndex = 5
        '
        'cboElectrical
        '
        Me.cboElectrical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboElectrical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboElectrical.FormattingEnabled = True
        Me.cboElectrical.Location = New System.Drawing.Point(200, 249)
        Me.cboElectrical.Name = "cboElectrical"
        Me.cboElectrical.Size = New System.Drawing.Size(552, 33)
        Me.cboElectrical.TabIndex = 5
        '
        'cboControls
        '
        Me.cboControls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboControls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboControls.FormattingEnabled = True
        Me.cboControls.Location = New System.Drawing.Point(200, 210)
        Me.cboControls.Name = "cboControls"
        Me.cboControls.Size = New System.Drawing.Size(552, 33)
        Me.cboControls.TabIndex = 5
        '
        'cboHMI
        '
        Me.cboHMI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHMI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHMI.FormattingEnabled = True
        Me.cboHMI.Location = New System.Drawing.Point(200, 171)
        Me.cboHMI.Name = "cboHMI"
        Me.cboHMI.Size = New System.Drawing.Size(552, 33)
        Me.cboHMI.TabIndex = 5
        '
        'cboPE
        '
        Me.cboPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPE.FormattingEnabled = True
        Me.cboPE.Location = New System.Drawing.Point(200, 132)
        Me.cboPE.Name = "cboPE"
        Me.cboPE.Size = New System.Drawing.Size(552, 33)
        Me.cboPE.TabIndex = 5
        '
        'cboPM
        '
        Me.cboPM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPM.FormattingEnabled = True
        Me.cboPM.Location = New System.Drawing.Point(200, 93)
        Me.cboPM.Name = "cboPM"
        Me.cboPM.Size = New System.Drawing.Size(552, 33)
        Me.cboPM.TabIndex = 5
        '
        'cboComOps
        '
        Me.cboComOps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboComOps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboComOps.FormattingEnabled = True
        Me.cboComOps.Location = New System.Drawing.Point(200, 54)
        Me.cboComOps.Name = "cboComOps"
        Me.cboComOps.Size = New System.Drawing.Size(552, 33)
        Me.cboComOps.TabIndex = 5
        '
        'cboSales
        '
        Me.cboSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSales.FormattingEnabled = True
        Me.cboSales.Location = New System.Drawing.Point(200, 15)
        Me.cboSales.Name = "cboSales"
        Me.cboSales.Size = New System.Drawing.Size(552, 33)
        Me.cboSales.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "DCS Engineer:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 25)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Mechnical Engineer:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Electrical Engineer:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Controls Engineer:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "HMI Engineer:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Project Engineer:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Project Mgr:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ComOps Mgr:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sales Mgr:"
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Location = New System.Drawing.Point(84, 442)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(245, 35)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create Project"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(407, 442)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(245, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 492)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNewProject"
        Me.Text = "Create New Project"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnPlantSelect As Button
    Friend WithEvents cboSubcon As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboEpc As ComboBox
    Friend WithEvents txtSAPDef As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboDcs As ComboBox
    Friend WithEvents cboMechnical As ComboBox
    Friend WithEvents cboElectrical As ComboBox
    Friend WithEvents cboControls As ComboBox
    Friend WithEvents cboHMI As ComboBox
    Friend WithEvents cboPE As ComboBox
    Friend WithEvents cboPM As ComboBox
    Friend WithEvents cboComOps As ComboBox
    Friend WithEvents cboSales As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
End Class
