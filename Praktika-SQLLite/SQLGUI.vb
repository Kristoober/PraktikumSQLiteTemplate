Imports System.CodeDom
Imports System.Data.SQLite
Imports System.IO
Imports Praktika_SQLLite_Komponent

Public Class SQLGUI

    Dim KomponentK As Praktika_SQLLite_Komponent.IInterface

    ''' <summary>
    ''' Handles the click of remove button to clear data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        KomponentK = New Praktika_SQLLite_Komponent.CKomponent

        If lvTabel.SelectedItems.Count = 0 Then
            lblResponse.Text = lblResponse.Text = "You must select an item to remove!"
            Exit Sub
        End If

        Dim selectedId As Integer = lvTabel.SelectedItems(0).Tag

        If KomponentK.SqlRemoveSelected(selectedId) Then
            lblResponse.Text = "Cleared!"
            Refresh_Table()
        Else
            lblResponse.Text = "Failed to Clear!"
        End If

    End Sub

    ''' <summary>
    ''' Handles the click of Add button to add a new item into database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        KomponentK = New Praktika_SQLLite_Komponent.CKomponent

        If Not CheckInputs() Then
            Exit Sub
        Else
            If Not KomponentK.SqlAddItem(txtboxName.Text, txtboxCode.Text, txtboxGrade.Text) Then
                lblResponse.Text = "damn didn't work"
            Else
                lblResponse.Text = "Added successfully"
                Refresh_Table()
            End If
        End If
    End Sub


    ''' <summary>
    ''' Handles the loading of our program, checks/makes our database and refreshes table for initial view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SQLGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KomponentK = New CKomponent
        KomponentK.InitDb()
        Refresh_Table()

    End Sub

    Private Sub BtnUnsafeAdd_Click(sender As Object, e As EventArgs) Handles btnUnsafeAdd.Click

        KomponentK = New Praktika_SQLLite_Komponent.CKomponent


        If Not KomponentK.SqlUnsafeAddItem(txtboxName.Text, txtboxCode.Text, txtboxGrade.Text) Then
            lblResponse.Text = "damn didn't work"
        Else
            lblResponse.Text = "Added successfully"
        End If
        Refresh_Table()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        KomponentK = New Praktika_SQLLite_Komponent.CKomponent

        If lvTabel.SelectedItems.Count = 0 Then
            lblResponse.Text = "You must select an item to update!"
            Exit Sub
        End If

        If Not CheckInputs() Then
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = lvTabel.SelectedItems(0)

        Dim selectedItemId As Integer = selectedItem.Tag

        Dim newUserInfo As String() = {txtboxName.Text, txtboxCode.Text, txtboxGrade.Text}

        If KomponentK.SqlUpdate(selectedItemId, newUserInfo) Then
            lblResponse.Text = "Updated successfully! :)"
        Else
            lblResponse.Text = "something went wrong! :("
        End If

        Refresh_Table()
    End Sub
    ''LIIDESTUS

    ''' <summary>
    ''' Separate sub to attatch parameters from selected item in database to ListView item
    ''' </summary>
    Private Sub Refresh_Table()
        KomponentK = New Praktika_SQLLite_Komponent.CKomponent
        Dim selecteditem As String()()

        lvTabel.Items.Clear()

        selecteditem = KomponentK.SqlLoadItem(8)

        If selecteditem IsNot Nothing AndAlso selecteditem.Length > 0 Then
            For Each row As String() In selecteditem
                If row IsNot Nothing And row.Length >= 4 Then
                    Dim item As New ListViewItem({row(1), row(2), row(3)})
                    item.Tag = row(0)

                    lvTabel.Items.Add(item)
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' checks if the input fields are filled and if they are filled correctly
    ''' </summary>
    ''' <returns>true if inputs are correct</returns>
    Private Function CheckInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtboxName.Text) Or String.IsNullOrWhiteSpace(txtboxCode.Text) Or String.IsNullOrWhiteSpace(txtboxGrade.Text) Then
            lblResponse.Text = "Make sure all inputs are filled!"
            Return False
        ElseIf Not (IsNumeric(txtboxCode.Text)) Or Not (IsNumeric(txtboxGrade.Text)) Then
            lblResponse.Text = "Invalid inputs!"
            Return False
        End If

        Return True
    End Function
End Class
