Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Globalization

Public Class MainForm
    Private ReadOnly products As New BindingList(Of Product)()
    Private selectedProductId As Integer = 0
    Private nextId As Integer = 1

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavedProducts()
        dgvProducts.DataSource = products
        UpdateTotals()
        SetStatus("Ready. Products are stored locally on this computer.")
    End Sub

    Private Sub LoadSavedProducts()
        products.Clear()
        Dim saved = ProductStore.LoadProducts()
        For Each item In saved.OrderBy(Function(p) p.Id)
            products.Add(item)
        Next
        If products.Count > 0 Then nextId = products.Max(Function(p) p.Id) + 1
    End Sub

    Private Function ReadMoney(control As TextBox, fieldName As String) As Decimal
        Dim value As Decimal
        If Not Decimal.TryParse(control.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, value) OrElse value < 0D Then
            Throw New ArgumentException(fieldName & " must be a valid number zero or greater.")
        End If
        Return value
    End Function

    Private Function BuildProduct() As Product
        If String.IsNullOrWhiteSpace(txtItemName.Text) Then
            Throw New ArgumentException("Enter the item name.")
        End If
        Dim cost As Decimal = ReadMoney(txtCost, "Wholesale cost")
        Dim price As Decimal = ReadMoney(txtPrice, "Selling price")
        If price < cost Then
            Dim answer = MessageBox.Show("The selling price is lower than the wholesale cost. Save anyway?",
                                         "Check price", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If answer = DialogResult.No Then Return Nothing
        End If

        Return New Product With {
            .Id = If(selectedProductId = 0, nextId, selectedProductId),
            .ItemName = txtItemName.Text.Trim(),
            .Description = txtDescription.Text.Trim(),
            .Color = txtColor.Text.Trim(),
            .Brand = txtBrand.Text.Trim(),
            .OtherDetails = txtOther.Text.Trim(),
            .Remarks = txtRemarks.Text.Trim(),
            .DateDelivered = dtpDate.Value.Date,
            .Barcode = txtBarcode.Text.Trim(),
            .Category = cmbCategory.Text,
            .Quantity = CInt(nudQty.Value),
            .UnitOfMeasure = cmbUnit.Text,
            .UnitCost = cost,
            .SellingPrice = price,
            .StorageLocation = txtStorage.Text.Trim()
        }
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If selectedProductId <> 0 Then
                MessageBox.Show("You are editing an existing product. Click Update, or click New to add another product.",
                                "Save product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim item = BuildProduct()
            If item Is Nothing Then Return
            If products.Any(Function(p) p.Barcode <> "" AndAlso p.Barcode = item.Barcode) AndAlso item.Barcode <> "" Then
                MessageBox.Show("That barcode already exists. Use a unique barcode.", "Duplicate barcode",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            products.Add(item)
            nextId += 1
            Persist()
            ClearInputs()
            SetStatus("Product saved successfully.")
        Catch ex As Exception
            ShowInputError(ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If selectedProductId = 0 Then
                MessageBox.Show("Select a product from the list before updating.", "Update",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim item = BuildProduct()
            If item Is Nothing Then Return
            Dim index = products.ToList().FindIndex(Function(p) p.Id = selectedProductId)
            If index < 0 Then
                MessageBox.Show("The selected product could not be found. Reload the list and try again.",
                                "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            products(index) = item
            Persist()
            dgvProducts.Refresh()
            ClearInputs()
            SetStatus("Product updated successfully.")
        Catch ex As Exception
            ShowInputError(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedProductId = 0 Then
            MessageBox.Show("Select a product from the list before deleting.", "Delete",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("Delete the selected product permanently?", "Confirm delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Dim item = products.FirstOrDefault(Function(p) p.Id = selectedProductId)
        If item IsNot Nothing Then
            products.Remove(item)
            Persist()
            ClearInputs()
            SetStatus("Product deleted.")
        End If
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.CurrentRow Is Nothing OrElse dgvProducts.CurrentRow.DataBoundItem Is Nothing Then Return
        Dim item = TryCast(dgvProducts.CurrentRow.DataBoundItem, Product)
        If item Is Nothing Then Return
        selectedProductId = item.Id
        txtItemName.Text = item.ItemName
        txtDescription.Text = item.Description
        txtColor.Text = item.Color
        txtBrand.Text = item.Brand
        txtOther.Text = item.OtherDetails
        txtRemarks.Text = item.Remarks
        dtpDate.Value = If(item.DateDelivered < dtpDate.MinDate, dtpDate.MinDate, If(item.DateDelivered > dtpDate.MaxDate, dtpDate.MaxDate, item.DateDelivered))
        txtBarcode.Text = item.Barcode
        SelectCombo(cmbCategory, item.Category)
        nudQty.Value = Math.Min(nudQty.Maximum, Math.Max(nudQty.Minimum, item.Quantity))
        SelectCombo(cmbUnit, item.UnitOfMeasure)
        txtCost.Text = item.UnitCost.ToString("0.00", CultureInfo.CurrentCulture)
        txtPrice.Text = item.SellingPrice.ToString("0.00", CultureInfo.CurrentCulture)
        txtStorage.Text = item.StorageLocation
        UpdateTotals()
    End Sub

    Private Sub SelectCombo(combo As ComboBox, value As String)
        Dim index = combo.Items.IndexOf(value)
        If index >= 0 Then combo.SelectedIndex = index Else combo.SelectedIndex = 0
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearInputs()
        txtItemName.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        selectedProductId = 0
        txtItemName.Clear()
        txtDescription.Clear()
        txtColor.Clear()
        txtBrand.Clear()
        txtOther.Clear()
        txtRemarks.Clear()
        dtpDate.Value = Date.Today
        txtBarcode.Clear()
        cmbCategory.SelectedIndex = 0
        nudQty.Value = 0
        cmbUnit.SelectedIndex = 0
        txtCost.Clear()
        txtPrice.Clear()
        txtStorage.Clear()
        dgvProducts.ClearSelection()
        UpdateTotals()
        SetStatus("Ready for a new product.")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadSavedProducts()
        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = products
        ClearInputs()
        SetStatus("Saved product list reloaded.")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim term = txtSearch.Text.Trim().ToLowerInvariant()
        If term = "" Then
            dgvProducts.DataSource = Nothing
            dgvProducts.DataSource = products
            Return
        End If
        Dim filtered = products.Where(Function(p) p.ItemName.ToLowerInvariant().Contains(term) OrElse
                                      p.Barcode.ToLowerInvariant().Contains(term) OrElse
                                      p.Category.ToLowerInvariant().Contains(term)).ToList()
        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = New BindingList(Of Product)(filtered)
    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged, txtPrice.TextChanged, nudQty.ValueChanged
        UpdateTotals()
    End Sub

    Private Sub UpdateTotals()
        Dim cost As Decimal
        Dim price As Decimal
        Decimal.TryParse(txtCost.Text, cost)
        Decimal.TryParse(txtPrice.Text, price)
        Dim qty As Decimal = nudQty.Value
        lblTotalCostValue.Text = (cost * qty).ToString("N2", CultureInfo.CurrentCulture)
        lblProfitValue.Text = (price - cost).ToString("N2", CultureInfo.CurrentCulture)
    End Sub

    Private Sub Persist()
        Try
            ProductStore.SaveProducts(products)
        Catch ex As Exception
            MessageBox.Show("The product was changed in the current session, but could not be saved to disk." &
                            Environment.NewLine & ex.Message, "Save error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowInputError(ex As Exception)
        MessageBox.Show(ex.Message, "Please check the product details",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub SetStatus(message As String)
        lblStatus.Text = message
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to exit Kay Shop Manager?", "Exit application",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
