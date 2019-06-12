Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports AlunoCRUD

<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub TestConsulta1()
        Assert.AreSame(New DadosAluno().ConsultarAluno(), New DadosAluno().ConsultarAluno(), "Não são o mesmo objeto")
    End Sub

    <TestMethod()> Public Sub TestConsulta2()
        Assert.AreEqual(New DadosAluno().ConsultarAluno(), New DadosAluno().ConsultarAluno(), "Não são iguais")
    End Sub

End Class