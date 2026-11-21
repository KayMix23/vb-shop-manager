Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents grpItem As GroupBox
    Friend WithEvents grpStock As GroupBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents lblOther As Label
    Friend WithEvents txtOther As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblBarcode As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblQty As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents lblUnit As Label
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblStorage As Label
    Friend WithEvents txtStorage As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotalCostValue As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblProfitValue As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        grpItem = New GroupBox()
        lblItemName = New Label()
        txtItemName = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblColor = New Label()
        txtColor = New TextBox()
        lblBrand = New Label()
        txtBrand = New TextBox()
        lblOther = New Label()
        txtOther = New TextBox()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        grpStock = New GroupBox()
        lblDate = New Label()
        dtpDate = New DateTimePicker()
        lblBarcode = New Label()
        txtBarcode = New TextBox()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        lblQty = New Label()
        nudQty = New NumericUpDown()
        lblUnit = New Label()
        cmbUnit = New ComboBox()
        lblCost = New Label()
        txtCost = New TextBox()
        lblPrice = New Label()
        txtPrice = New TextBox()
        lblStorage = New Label()
        txtStorage = New TextBox()
        lblTotalCost = New Label()
        lblTotalCostValue = New Label()
        lblProfit = New Label()
        lblProfitValue = New Label()
        btnNew = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnLoad = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        dgvProducts = New DataGridView()
        statusStrip = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        pnlHeader.SuspendLayout()
        grpItem.SuspendLayout()
        grpStock.SuspendLayout()
        CType(nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        statusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(28), CByte(47), CByte(72))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(btnSave)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1349, 101)
        pnlHeader.TabIndex = 11
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(323, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "KAY SHOP MANAGER"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(220), CByte(230), CByte(240))
        lblSubtitle.Location = New Point(29, 63)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(411, 20)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Product registration • Stock control • Cost and profit tracking"
        ' 
        ' grpItem
        ' 
        grpItem.Controls.Add(lblItemName)
        grpItem.Controls.Add(txtItemName)
        grpItem.Controls.Add(lblDescription)
        grpItem.Controls.Add(txtDescription)
        grpItem.Controls.Add(lblColor)
        grpItem.Controls.Add(txtColor)
        grpItem.Controls.Add(lblBrand)
        grpItem.Controls.Add(txtBrand)
        grpItem.Controls.Add(lblOther)
        grpItem.Controls.Add(txtOther)
        grpItem.Controls.Add(lblRemarks)
        grpItem.Controls.Add(txtRemarks)
        grpItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpItem.Location = New Point(23, 121)
        grpItem.Margin = New Padding(3, 4, 3, 4)
        grpItem.Name = "grpItem"
        grpItem.Padding = New Padding(3, 4, 3, 4)
        grpItem.Size = New Size(640, 360)
        grpItem.TabIndex = 10
        grpItem.TabStop = False
        grpItem.Text = "ITEM INFORMATION"
        ' 
        ' lblItemName
        ' 
        lblItemName.Location = New Point(0, 0)
        lblItemName.Name = "lblItemName"
        lblItemName.Size = New Size(114, 31)
        lblItemName.TabIndex = 0
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(0, 0)
        txtItemName.Margin = New Padding(3, 4, 3, 4)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(114, 27)
        txtItemName.TabIndex = 1
        ' 
        ' lblDescription
        ' 
        lblDescription.Location = New Point(0, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(114, 31)
        lblDescription.TabIndex = 2
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(0, 0)
        txtDescription.Margin = New Padding(3, 4, 3, 4)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(114, 27)
        txtDescription.TabIndex = 3
        ' 
        ' lblColor
        ' 
        lblColor.Location = New Point(0, 0)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(114, 31)
        lblColor.TabIndex = 4
        ' 
        ' txtColor
        ' 
        txtColor.Location = New Point(0, 0)
        txtColor.Margin = New Padding(3, 4, 3, 4)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(114, 27)
        txtColor.TabIndex = 5
        ' 
        ' lblBrand
        ' 
        lblBrand.Location = New Point(0, 0)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(114, 31)
        lblBrand.TabIndex = 6
        ' 
        ' txtBrand
        ' 
        txtBrand.Location = New Point(0, 0)
        txtBrand.Margin = New Padding(3, 4, 3, 4)
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(114, 27)
        txtBrand.TabIndex = 7
        ' 
        ' lblOther
        ' 
        lblOther.Location = New Point(0, 0)
        lblOther.Name = "lblOther"
        lblOther.Size = New Size(114, 31)
        lblOther.TabIndex = 8
        ' 
        ' txtOther
        ' 
        txtOther.Location = New Point(0, 0)
        txtOther.Margin = New Padding(3, 4, 3, 4)
        txtOther.Name = "txtOther"
        txtOther.Size = New Size(114, 27)
        txtOther.TabIndex = 9
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Location = New Point(0, 0)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(114, 31)
        lblRemarks.TabIndex = 10
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(143, 239)
        txtRemarks.Margin = New Padding(3, 4, 3, 4)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(468, 87)
        txtRemarks.TabIndex = 11
        ' 
        ' grpStock
        ' 
        grpStock.Controls.Add(lblDate)
        grpStock.Controls.Add(dtpDate)
        grpStock.Controls.Add(lblBarcode)
        grpStock.Controls.Add(btnNew)
        grpStock.Controls.Add(txtBarcode)
        grpStock.Controls.Add(lblCategory)
        grpStock.Controls.Add(cmbCategory)
        grpStock.Controls.Add(lblQty)
        grpStock.Controls.Add(nudQty)
        grpStock.Controls.Add(lblUnit)
        grpStock.Controls.Add(cmbUnit)
        grpStock.Controls.Add(lblCost)
        grpStock.Controls.Add(txtCost)
        grpStock.Controls.Add(lblPrice)
        grpStock.Controls.Add(txtPrice)
        grpStock.Controls.Add(lblStorage)
        grpStock.Controls.Add(txtStorage)
        grpStock.Controls.Add(lblTotalCost)
        grpStock.Controls.Add(lblTotalCostValue)
        grpStock.Controls.Add(lblProfit)
        grpStock.Controls.Add(lblProfitValue)
        grpStock.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpStock.Location = New Point(680, 121)
        grpStock.Margin = New Padding(3, 4, 3, 4)
        grpStock.Name = "grpStock"
        grpStock.Padding = New Padding(3, 4, 3, 4)
        grpStock.Size = New Size(646, 360)
        grpStock.TabIndex = 9
        grpStock.TabStop = False
        grpStock.Text = "STOCK & PRICING"
        ' 
        ' lblDate
        ' 
        lblDate.Location = New Point(0, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(114, 31)
        lblDate.TabIndex = 0
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(154, 36)
        dtpDate.Margin = New Padding(3, 4, 3, 4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(211, 27)
        dtpDate.TabIndex = 1
        ' 
        ' lblBarcode
        ' 
        lblBarcode.Location = New Point(0, 0)
        lblBarcode.Name = "lblBarcode"
        lblBarcode.Size = New Size(114, 31)
        lblBarcode.TabIndex = 2
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Location = New Point(0, 0)
        txtBarcode.Margin = New Padding(3, 4, 3, 4)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.Size = New Size(114, 27)
        txtBarcode.TabIndex = 3
        ' 
        ' lblCategory
        ' 
        lblCategory.Location = New Point(0, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(114, 31)
        lblCategory.TabIndex = 4
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Location = New Point(0, 0)
        cmbCategory.Margin = New Padding(3, 4, 3, 4)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(138, 28)
        cmbCategory.TabIndex = 5
        ' 
        ' lblQty
        ' 
        lblQty.Location = New Point(0, 0)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(114, 31)
        lblQty.TabIndex = 6
        ' 
        ' nudQty
        ' 
        nudQty.Location = New Point(480, 87)
        nudQty.Margin = New Padding(3, 4, 3, 4)
        nudQty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(143, 27)
        nudQty.TabIndex = 7
        ' 
        ' lblUnit
        ' 
        lblUnit.Location = New Point(0, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(114, 31)
        lblUnit.TabIndex = 8
        ' 
        ' cmbUnit
        ' 
        cmbUnit.Location = New Point(0, 0)
        cmbUnit.Margin = New Padding(3, 4, 3, 4)
        cmbUnit.Name = "cmbUnit"
        cmbUnit.Size = New Size(138, 28)
        cmbUnit.TabIndex = 9
        ' 
        ' lblCost
        ' 
        lblCost.Location = New Point(0, 0)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(114, 31)
        lblCost.TabIndex = 10
        ' 
        ' txtCost
        ' 
        txtCost.Location = New Point(0, 0)
        txtCost.Margin = New Padding(3, 4, 3, 4)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(114, 27)
        txtCost.TabIndex = 11
        ' 
        ' lblPrice
        ' 
        lblPrice.Location = New Point(0, 0)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(114, 31)
        lblPrice.TabIndex = 12
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(0, 0)
        txtPrice.Margin = New Padding(3, 4, 3, 4)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(114, 27)
        txtPrice.TabIndex = 13
        ' 
        ' lblStorage
        ' 
        lblStorage.Location = New Point(0, 0)
        lblStorage.Name = "lblStorage"
        lblStorage.Size = New Size(114, 31)
        lblStorage.TabIndex = 14
        ' 
        ' txtStorage
        ' 
        txtStorage.Location = New Point(0, 0)
        txtStorage.Margin = New Padding(3, 4, 3, 4)
        txtStorage.Name = "txtStorage"
        txtStorage.Size = New Size(114, 27)
        txtStorage.TabIndex = 15
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.Location = New Point(0, 0)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(114, 31)
        lblTotalCost.TabIndex = 16
        ' 
        ' lblTotalCostValue
        ' 
        lblTotalCostValue.Location = New Point(0, 0)
        lblTotalCostValue.Name = "lblTotalCostValue"
        lblTotalCostValue.Size = New Size(114, 31)
        lblTotalCostValue.TabIndex = 17
        ' 
        ' lblProfit
        ' 
        lblProfit.Location = New Point(0, 0)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(114, 31)
        lblProfit.TabIndex = 18
        ' 
        ' lblProfitValue
        ' 
        lblProfitValue.Location = New Point(0, 0)
        lblProfitValue.Name = "lblProfitValue"
        lblProfitValue.Size = New Size(114, 31)
        lblProfitValue.TabIndex = 19
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(-11, 0)
        btnNew.Margin = New Padding(3, 4, 3, 4)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(86, 31)
        btnNew.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(0, 0)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(86, 31)
        btnSave.TabIndex = 4
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(0, 0)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(86, 31)
        btnUpdate.TabIndex = 5
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(0, 0)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 31)
        btnDelete.TabIndex = 6
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(0, 0)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(86, 31)
        btnClear.TabIndex = 7
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(0, 0)
        btnLoad.Margin = New Padding(3, 4, 3, 4)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(86, 31)
        btnLoad.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(960, 560)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by name, barcode or category..."
        txtSearch.Size = New Size(365, 27)
        txtSearch.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSearch.Location = New Point(23, 565)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(113, 20)
        lblSearch.TabIndex = 1
        lblSearch.Text = "PRODUCT LIST"
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.BackgroundColor = Color.White
        dgvProducts.BorderStyle = BorderStyle.Fixed3D
        dgvProducts.ColumnHeadersHeight = 34
        dgvProducts.Location = New Point(23, 603)
        dgvProducts.Margin = New Padding(3, 4, 3, 4)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersVisible = False
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(1303, 347)
        dgvProducts.TabIndex = 0
        ' 
        ' statusStrip
        ' 
        statusStrip.ImageScalingSize = New Size(20, 20)
        statusStrip.Items.AddRange(New ToolStripItem() {lblStatus})
        statusStrip.Location = New Point(0, 966)
        statusStrip.Name = "statusStrip"
        statusStrip.Padding = New Padding(1, 0, 16, 0)
        statusStrip.Size = New Size(1349, 26)
        statusStrip.TabIndex = 12
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(50, 20)
        lblStatus.Text = "Ready"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(249))
        ClientSize = New Size(1349, 992)
        Controls.Add(dgvProducts)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnLoad)
        Controls.Add(grpStock)
        Controls.Add(grpItem)
        Controls.Add(pnlHeader)
        Controls.Add(statusStrip)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1197, 918)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kay Shop Manager"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        grpItem.ResumeLayout(False)
        grpItem.PerformLayout()
        grpStock.ResumeLayout(False)
        grpStock.PerformLayout()
        CType(nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        statusStrip.ResumeLayout(False)
        statusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub SetupLabel(control As Label, caption As String, x As Integer, y As Integer)
        control.AutoSize = True
        control.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        control.Location = New System.Drawing.Point(x, y)
        control.Text = caption
    End Sub

    Private Sub SetupText(control As TextBox, x As Integer, y As Integer, width As Integer)
        control.Location = New System.Drawing.Point(x, y)
        control.Size = New System.Drawing.Size(width, 23)
    End Sub

    Private Sub SetupCombo(control As ComboBox, x As Integer, y As Integer, width As Integer, values As String())
        control.DropDownStyle = ComboBoxStyle.DropDownList
        control.Location = New System.Drawing.Point(x, y)
        control.Size = New System.Drawing.Size(width, 23)
        control.Items.AddRange(values)
        If control.Items.Count > 0 Then control.SelectedIndex = 0
    End Sub

    Private Sub SetupValueLabel(control As Label, x As Integer, y As Integer)
        control.AutoSize = True
        control.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
        control.ForeColor = System.Drawing.Color.FromArgb(25, 115, 75)
        control.Location = New System.Drawing.Point(x, y)
        control.Text = "0.00"
    End Sub

    Private Sub SetupButton(control As Button, caption As String, x As Integer, y As Integer, width As Integer, backColor As System.Drawing.Color)
        control.Location = New System.Drawing.Point(x, y)
        control.Size = New System.Drawing.Size(width, 34)
        control.Text = caption
        control.BackColor = backColor
        control.ForeColor = System.Drawing.Color.White
        control.FlatStyle = FlatStyle.Flat
        control.FlatAppearance.BorderSize = 0
        control.Cursor = Cursors.Hand
        control.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
    End Sub

    Private Sub AddGridColumn(name As String, header As String, propertyName As String, fillWeight As Single)
        Dim col As New DataGridViewTextBoxColumn With {
            .Name = name,
            .HeaderText = header,
            .DataPropertyName = propertyName,
            .FillWeight = fillWeight,
            .SortMode = DataGridViewColumnSortMode.Automatic
        }
        Me.dgvProducts.Columns.Add(col)
    End Sub
End Class
