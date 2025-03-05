Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class CKomponent
    Implements IInterface

    ''' <summary>
    ''' Path to where your database file will be stored and accessed from
    ''' </summary>
    Dim dbPath As String = Path.Combine(Directory.GetCurrentDirectory(), "App.db")
    Dim sqlConnectionString As String = $"Data Source={dbPath};Version=3;"

    ''' <summary>
    ''' Handles initializing process. This includes making the database file if it is missing.
    ''' </summary>
    Private Sub InitDb() Implements IInterface.InitDb
        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
            'Write code to initialize db
        End If
    End Sub

    ''' <summary>
    ''' Loads an item from SQL database into our environment.
    ''' </summary>
    ''' <param name="selector">Using it to find the next item in the list</param>
    ''' <returns>Tuple returns multiple values, this returns a set of values aka all parameters we need from one item</returns>
    Public Function SqlLoadItem(ByVal selector As Integer) As Tuple(Of String, Integer, Integer) Implements IInterface.SqlLoadItem
        'Write code for item query
    End Function

    ''' <summary>
    ''' Clears the entire table from SQl
    ''' </summary>
    ''' <returns>Boolean whether doing so was a success or fail</returns>
    Private Function SqlRemoveAll() As Boolean Implements IInterface.SqlRemoveAll
        'Write a function to remove all items from database (not the table of db itself!!)
        'HINT:
    End Function

    ''' <summary>
    ''' Adds an item with our parameters into our existing database
    ''' </summary>
    ''' <param name="name">Name of student</param>
    ''' <param name="code">Code of student</param>
    ''' <param name="grade">Grade of student</param>
    ''' <returns>Returns whether adding was a success or fail</returns>
    Private Function SqlAddItem(ByVal name As String, ByVal code As Integer, ByVal grade As Integer) As Boolean Implements IInterface.SqlAddItem
        'Write code to safely add items to db
    End Function

    '                 '); DROP TABLE Students;--
    Private Function SqlUnsafeAddItem(ByVal name As String, ByVal code As String, ByVal grade As String) As Boolean Implements IInterface.SqlUnsafeAddItem
        'Write code to add items to db (unsafely)
    End Function
End Class

