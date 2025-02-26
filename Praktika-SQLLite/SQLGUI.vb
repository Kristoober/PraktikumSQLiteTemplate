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

        If KomponentK.SqlRemoveAll() Then
            lblResponse.Text = "Database Cleared!"
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

        If txtboxName.Text Is Nothing Or txtboxCode.Text Is Nothing Or txtboxGrade.Text Is Nothing Then
            lblResponse.Text = "Make sure all inputs are filled!"
        ElseIf Not (IsNumeric(txtboxCode.Text)) Or Not (IsNumeric(txtboxGrade.Text)) Then
            lblResponse.Text = "Invalid inputs!"
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
    ''LIIDESTUS

    ''' <summary>
    ''' Separate sub to attatch parameters from selected item in database to ListView item
    ''' </summary>
    Private Sub Refresh_Table()
        KomponentK = New Praktika_SQLLite_Komponent.CKomponent
        Dim selecteditem As Tuple(Of String, Integer, Integer)

        lvTabel.Items.Clear()

        For selector As Integer = 1 To 8
            selecteditem = KomponentK.SqlLoadItem(selector)
            If selecteditem.Item1 IsNot "" Then
                lvTabel.Items.Add(New ListViewItem({selecteditem.Item1, selecteditem.Item2, selecteditem.Item3}))
            End If
        Next

    End Sub

End Class
