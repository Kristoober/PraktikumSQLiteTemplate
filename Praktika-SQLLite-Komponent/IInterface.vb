Public Interface IInterface
    Sub InitDb()
    Function SqlUnsafeAddItem(ByVal name As String, ByVal code As String, ByVal grade As String) As Boolean
    Function SqlAddItem(ByVal name As String, ByVal code As Integer, ByVal grade As Integer) As Boolean
    Function SqlLoadItem(ByVal selector As Integer) As Tuple(Of String, Integer, Integer)
    Function SqlRemoveAll() As Boolean
End Interface
