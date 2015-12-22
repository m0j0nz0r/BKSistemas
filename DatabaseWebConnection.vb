Imports System.Data.Common

Public Class DatabaseWebConnection
    Inherits DbConnection
    Private db As String
    Private ds As String
    Private sv As String
    Public Sub New(ServerAddress As String)
        sv = ServerAddress
    End Sub
    Protected Overrides Function BeginDbTransaction(isolationLevel As IsolationLevel) As DbTransaction
        Return MyBase.BeginTransaction(isolationLevel)
    End Function
    Public Overrides Sub ChangeDatabase(databaseName As String)

    End Sub
    Public Overrides Sub Close()

    End Sub
    Public Overrides Property ConnectionString As String
        Get
            Return sv
        End Get
        Set(value As String)
            sv = value
        End Set
    End Property

    Protected Overrides Function CreateDbCommand() As DbCommand
        Return MyBase.CreateCommand()
    End Function

    Public Overrides ReadOnly Property Database As String
        Get
            Return db
        End Get
    End Property

    Public Overrides ReadOnly Property DataSource As String
        Get
            Return ds
        End Get
    End Property

    Public Overrides Sub Open()

    End Sub

    Public Overrides ReadOnly Property ServerVersion As String
        Get
            Return "1.0"
        End Get
    End Property

    Public Overrides ReadOnly Property State As ConnectionState
        Get
            Return ConnectionState.Open
        End Get
    End Property
End Class
