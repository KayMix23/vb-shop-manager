Imports System.IO
Imports System.Text.Json
Imports System.Windows.Forms

Public NotInheritable Class ProductStore
    Private Sub New()
    End Sub

    Private Shared ReadOnly DataFolder As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KayShopManager")

    Private Shared ReadOnly DataFile As String = Path.Combine(DataFolder, "products.json")

    Public Shared Function LoadProducts() As List(Of Product)
        Try
            If Not File.Exists(DataFile) Then Return New List(Of Product)()
            Dim json As String = File.ReadAllText(DataFile)
            Dim items = JsonSerializer.Deserialize(Of List(Of Product))(json)
            Return If(items, New List(Of Product)())
        Catch ex As Exception
            MessageBox.Show("The saved product file could not be read." & Environment.NewLine &
                            ex.Message, "Load error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New List(Of Product)()
        End Try
    End Function

    Public Shared Sub SaveProducts(items As IEnumerable(Of Product))
        Directory.CreateDirectory(DataFolder)
        Dim options As New JsonSerializerOptions With {.WriteIndented = True}
        Dim json As String = JsonSerializer.Serialize(items, options)
        Dim tempFile As String = DataFile & ".tmp"
        File.WriteAllText(tempFile, json)
        File.Copy(tempFile, DataFile, True)
        File.Delete(tempFile)
    End Sub
End Class
