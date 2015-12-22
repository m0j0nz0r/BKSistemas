Imports System.Data.Common
Public Class DatabaseWebCommand
    Inherits DbCommand

    Private _p1 As String
    Private _conn As DatabaseWebConnection

    Sub New(p1 As String, conn As DatabaseWebConnection)
        ' TODO: Complete member initialization 
        _p1 = p1
        _conn = conn
        _CommandTimeout = 10
    End Sub

    Public Overrides Sub Cancel()

    End Sub
    Public Overrides Property CommandText As String
        Get
            Return _p1
        End Get
        Set(value As String)
            _p1 = value
        End Set
    End Property

    Public Overrides Property CommandTimeout As Integer

    Public Overrides Property CommandType As CommandType


    Protected Overrides Function CreateDbParameter() As DbParameter
        Dim param As DbParameter = MyBase.CreateParameter()
        Return param
    End Function

    Protected Overrides Property DbConnection As DbConnection
        Get
            Return _conn
        End Get
        Set(value As DbConnection)
            _conn = value
        End Set
    End Property

    Protected Overrides ReadOnly Property DbParameterCollection As DbParameterCollection
        Get
            Return MyBase.Parameters
        End Get
    End Property
    Protected Overrides Property DbTransaction As DbTransaction

    Public Overrides Property DesignTimeVisible As Boolean

    Protected Overrides Function ExecuteDbDataReader(behavior As CommandBehavior) As DbDataReader
        Return MyBase.ExecuteReader(behavior)
    End Function

    Public Overrides Function ExecuteNonQuery() As Integer
        Return 1
    End Function
    Public Overrides Function ExecuteScalar() As Object
        Return 1
    End Function
    Public Overrides Sub Prepare()

    End Sub
    Public Overrides Property UpdatedRowSource As UpdateRowSource
    'Public Overrides property Connection As 
End Class
