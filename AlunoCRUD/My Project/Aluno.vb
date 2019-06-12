Public Class Aluno
    Private _id As Integer
    Private _nome As String
    Private _endereco As String
    Private _cidade As String
    Private _uf As String
    Private _ativo As Byte

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return _endereco
        End Get
        Set(value As String)
            _endereco = value
        End Set
    End Property

    Public Property Cidade As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property

    Public Property Uf As String
        Get
            Return _uf
        End Get
        Set(value As String)
            _uf = value
        End Set
    End Property

    Public Property Ativo As Byte
        Get
            Return _ativo
        End Get
        Set(value As Byte)
            _ativo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(Id As Integer)
        _id = Id
    End Sub

    Public Sub New(Nome As String, Endereco As String, Cidade As String, UF As String, Ativo As Byte)
        _nome = Nome
        _endereco = Endereco
        _cidade = Cidade
        _uf = UF
        _ativo = Ativo
    End Sub

    Public Sub New(Id As Integer, Nome As String, Endereco As String, Cidade As String, UF As String, Ativo As Byte)
        _id = Id
        _nome = Nome
        _endereco = Endereco
        _cidade = Cidade
        _uf = UF
        _ativo = Ativo
    End Sub
End Class
