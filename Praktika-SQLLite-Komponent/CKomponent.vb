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
        End If
        'Dim sqlQuery As String = "CREATE TABLE IF NOT EXISTS Students (ID INTEGER PRIMARY KEY AUTOINCREMENT,
        '                                                               Name TEXT,
        '                                                               Code INTEGER,
        '                                                               Grade INTEGER);"
    End Sub

    '                 '); DROP TABLE Students;--
    Private Function SqlUnsafeAddItem(ByVal name As String, ByVal code As String, ByVal grade As String) As Boolean Implements IInterface.SqlUnsafeAddItem
        'Write code to add items to db (unsafely)
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



    ''' <summary>
    ''' Loads an item from SQL database into our environment.
    ''' </summary>
    ''' <param name="selector">Using it to find the next item in the list</param>
    ''' <returns>Tuple returns multiple values, this returns a set of values aka all parameters we need from one item</returns>
    Private Function SqlLoadItem(ByVal selector As Integer) As String()() Implements IInterface.SqlLoadItem
        'Write code for item query
    End Function



    ''' <summary>
    ''' Clears the entire table from SQl
    ''' </summary>
    ''' <returns>Boolean whether doing so was a success or fail</returns>
    Private Function SqlRemoveSelected(ByVal hiddenID As Integer) As Boolean Implements IInterface.SqlRemoveSelected
        'Write a function to remove the item with the given ID from database
    End Function



    ''' <summary>
    ''' updates the name, code and grade fields in table Students, where the ID matches hiddenId
    ''' </summary>
    ''' <param name="hiddenId">numeric value reprecents a single existing value in the collumn ID in table Students</param>
    ''' <param name="userInfoNew">string array where userinfoNew(0) is the new name, userInfoNew(1) is the new code and userInfoNew is the new grade</param>
    ''' <returns>true if successful, false if not.</returns>
    Public Function SqlUpdate(ByVal hiddenId As Integer, ByVal userInfoNew As String()) As Boolean Implements IInterface.SqlUpdate
        'Write code that updates the name code and grade of the row that has the ID value of hiddenId.
    End Function
End Class

