Imports IronPdf
Public Class Form1
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        recarregar()
    End Sub

    Private Sub recarregar()
        Try
            limpar()
            Dim dadosAluno = New DadosAluno()
            Dim dados = New List(Of Aluno)(dadosAluno.ConsultarAluno())
            grvAlunos.DataSource = dados
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub

    Private Sub limpar()
        Try
            lblId.Text = ""
            lblAguarde.Visible = False
            For Each c In Me.Controls
                Select Case c.GetType()
                    Case GetType(TextBox)
                        CType(c, TextBox).Text = String.Empty
                    Case GetType(CheckBox)
                        CType(c, CheckBox).Checked = False
                    Case GetType(MaskedTextBox)
                        CType(c, MaskedTextBox).Text = String.Empty
                    Case GetType(ProgressBar)
                        CType(c, ProgressBar).Value = 0
                End Select
            Next
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recarregar()
    End Sub

    Private Sub GrvAlunos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grvAlunos.CellContentClick
        Try
            limpar()
            lblAguarde.Visible = True
            With grvAlunos.CurrentRow
                lblId.Text = .Cells(0).Value.ToString
                txtNome.Text = .Cells(1).Value.ToString
                txtEndereco.Text = .Cells(2).Value.ToString
                txtCidade.Text = .Cells(3).Value.ToString
                txtUF.Text = .Cells(4).Value.ToString
                chkAtivo.Checked = .Cells(5).Value
            End With
            lblAguarde.Visible = False
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If Trim(lblId.Text) = "" Then
            MsgBox("Necessário carregar registro antes de excluir!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim dadosAluno = New DadosAluno
            lblAguarde.Visible = True
            dadosAluno.ExcluirAluno(New Aluno(lblId.Text))
            recarregar()
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If Trim(txtNome.Text) = "" Then
            MsgBox("Nome do Aluno é obrigatório!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Trim(txtEndereco.Text) = "" Then
            MsgBox("Endereço é obrigatório!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Trim(txtCidade.Text) = "" Then
            MsgBox("Cidade é obrigatória!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Trim(txtUF.Text) = "" Then
            MsgBox("UF é obrigatório!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim dadosAluno = New DadosAluno
            lblAguarde.Visible = True
            If lblId.Text = "" Then 'Inclusão
                dadosAluno.IncluirAluno(New Aluno(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtUF.Text, IIf(chkAtivo.Checked, 1, 0)))
            ElseIf lblId.Text <> vbEmpty Then 'Alteração
                dadosAluno.AtualizarAluno(New Aluno(lblId.Text, txtNome.Text, txtEndereco.Text, txtCidade.Text, txtUF.Text, IIf(chkAtivo.Checked, 1, 0)))
            End If
            recarregar()
        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub

    Private Sub BtnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Try
            Dim Renderer As IronPdf.HtmlToPdf = New IronPdf.HtmlToPdf()
            'Dim linha As DataGridViewRow = New DataGridViewRow()
            Dim html As String = ""
            'Cabeçalho
            html = "<table>"
            html += "<tr><td>Nome</td><td>Endereço</td><td>Cidade</td><td>UF</td><td>Ativo</td></tr>"

            For Each linha As DataGridViewRow In grvAlunos.Rows
                html += "<tr>"
                html += "   <td>" + linha.Cells(1).Value + "</td>"
                html += "   <td>" + linha.Cells(2).Value + "</td>"
                html += "   <td>" + linha.Cells(3).Value + "</td>"
                html += "   <td>" + linha.Cells(4).Value + "</td>"
                html += "   <td>" + IIf(linha.Cells(5).Value, "SIM", "NÃO") + "</td>"
                html += "</tr>"
            Next

            html += "</table>"
            Dim doc = Renderer.RenderHtmlAsPdf(html)
            Dim caminho As String
            fbd1.Description = "Selecione uma pasta para realizar o Backup"
            fbd1.RootFolder = Environment.SpecialFolder.MyComputer
            fbd1.ShowNewFolderButton = True

            'Exibe a caixa de diálogo
            If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Exibe a pasta selecionada
                caminho = fbd1.SelectedPath
                doc.SaveAs(caminho + "\aluno.pdf")
                Process.Start(caminho + "\aluno.pdf")
            End If

        Catch ex As Exception
            Throw New Exception
        End Try
    End Sub
End Class
