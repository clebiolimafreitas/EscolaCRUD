Imports System.Configuration
Imports System.Data.SqlClient
Imports Dapper

Public Class DadosAluno
    Dim strConexao As String = ConfigurationManager.ConnectionStrings("conexaoEscola").ConnectionString
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(strConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Public Sub IncluirAluno(ByVal aluno As Aluno)
        objConexao.Open()
        strInstrucao = "INSERT INTO Aluno VALUES (@Nome, @Endereco, @Cidade, @UF, @Ativo)"
        objConexao.Execute(strInstrucao, New With {.Nome = aluno.Nome, .Endereco = aluno.Endereco, .Cidade = aluno.Cidade, .UF = aluno.Uf, .Ativo = aluno.Ativo})
        objConexao.Close()
    End Sub

    Public Sub AtualizarAluno(ByVal aluno As Aluno)
        objConexao.Open()
        strInstrucao = "UPDATE Aluno SET 
            Nome = @Nome, Endereco = @Endereco, Cidade = @Cidade, 
            UF = @UF, Ativo = @Ativo
            where Id = @Id"
        objConexao.Execute(strInstrucao, New With {.Id = aluno.Id, .Nome = aluno.Nome, .Endereco = aluno.Endereco, .Cidade = aluno.Cidade, .UF = aluno.Uf, .Ativo = aluno.Ativo})
        objConexao.Close()
    End Sub

    Public Sub ExcluirAluno(ByVal aluno As Aluno)
        objConexao.Open()
        strInstrucao = "DELETE FROM Aluno WHERE Id = @Id"
        objConexao.Execute(strInstrucao, New With {.Id = aluno.Id})
        objConexao.Close()
    End Sub

    Public Function ConsultarAluno() As IEnumerable
        strInstrucao = "SELECT * FROM Aluno"
        Dim dados As IEnumerable = objConexao.Query(Of Aluno)(strInstrucao)
        objConexao.Open()
        Dim alunos = dados
        objConexao.Close()
        Return alunos
    End Function
End Class
