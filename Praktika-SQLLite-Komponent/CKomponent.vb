Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing

Public Class CKomponent
    Implements IInterface

    ''' <summary>
    ''' Path to where your database file will be stored and accessed from
    ''' </summary>
    Dim dbPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "App.db")

    ''' <summary>
    ''' Handles initializing process. This includes making the database file if it is missing.
    ''' </summary>
    Private Sub InitDb() Implements IInterface.InitDb
        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
            Dim sql As String = "CREATE TABLE IF NOT EXISTS Students (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Code INTEGER, Grade INTEGER);"
            Try
                Using connection As New SQLiteConnection($"Data Source={dbPath};Version=3;")
                    connection.Open()
                    Dim cmd As New SQLiteCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Loads an item from SQL database into our environment.
    ''' </summary>
    ''' <param name="selector">Using it to find the next item in the list</param>
    ''' <returns>Tuple returns multiple values, this returns a set of values aka all parameters we need from one item</returns>
    Public Function SqlLoadItem(ByVal selector As Integer) As Tuple(Of String, Integer, Integer) Implements IInterface.SqlLoadItem
        Dim tabeli_asukoht As String = $"Data Source={dbPath};Version=3;"
        Try
            Using connection As New SQLiteConnection(tabeli_asukoht)
                connection.Open()
                Dim insertDataSql As String = "SELECT Name, Code, Grade FROM Students LIMIT 1 OFFSET @Offset"
                Using cmd As New SQLiteCommand(insertDataSql, connection)
                    cmd.Parameters.AddWithValue("@Offset", selector - 1)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim result As Tuple(Of String, Integer, Integer) = Tuple.Create(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2))
                            Return result
                        Else
                            Return Tuple.Create("", 0, 0)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Tuple.Create("", 0, 0)
        End Try
    End Function

    ''' <summary>
    ''' Clears the entire table from SQl
    ''' </summary>
    ''' <returns>Boolean whether doing so was a success or fail</returns>
    Private Function SqlRemoveAll() As Boolean Implements IInterface.SqlRemoveAll
        Dim tabeli_asukoht As String = $"Data Source={dbPath};Version=3;"
        Try
            Using connection As New SQLiteConnection(tabeli_asukoht)
                connection.Open()
                Dim deleteDataSql As String = "DELETE FROM Students"
                Using cmd As New SQLiteCommand(deleteDataSql, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Adds an item with our parameters into our existing database
    ''' </summary>
    ''' <param name="name">Name of student</param>
    ''' <param name="code">Code of student</param>
    ''' <param name="grade">Grade of student</param>
    ''' <returns>Returns whether adding was a success or fail</returns>
    Private Function SqlAddItem(ByVal name As String, ByVal code As Integer, ByVal grade As Integer) As Boolean Implements IInterface.SqlAddItem

        Dim tabeli_asukoht As String = $"Data Source={dbPath};Version=3;"
        Try
            Using connection As New SQLiteConnection(tabeli_asukoht)
                connection.Open()
                Dim insertDataSql As String = "INSERT INTO Students (Name, Code, Grade) VALUES (@Name, @Code, @Grade)"
                Using cmd As New SQLiteCommand(insertDataSql, connection)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Code", code)
                    cmd.Parameters.AddWithValue("@Grade", grade)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    '                 '); DROP TABLE Students;--
    Private Function SqlUnsafeAddItem(ByVal name As String, ByVal code As String, ByVal grade As String) As Boolean Implements IInterface.SqlUnsafeAddItem

        Dim tabeli_asukoht As String = $"Data Source={dbPath};Version=3;"
        Try
            Using connection As New SQLiteConnection(tabeli_asukoht)
                connection.Open()
                ''This is unsafe injection SQL solution, try "; DROP TABLE Students; --"
                Dim insertDataSql As String = $"INSERT INTO Students (Name, Code, Grade) VALUES ('{name}', '{code}', '{grade}')"
                Using cmd As New SQLiteCommand(insertDataSql, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function
End Class

