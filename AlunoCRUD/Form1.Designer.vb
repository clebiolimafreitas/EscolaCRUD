<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.grvAlunos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Endereço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblAguarde = New System.Windows.Forms.Label()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.grvAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "UF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ativo"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(97, 10)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(465, 20)
        Me.txtNome.TabIndex = 5
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(97, 33)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(465, 20)
        Me.txtEndereco.TabIndex = 6
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(97, 57)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(465, 20)
        Me.txtCidade.TabIndex = 7
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(97, 81)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(37, 20)
        Me.txtUF.TabIndex = 8
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(188, 84)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(15, 14)
        Me.chkAtivo.TabIndex = 9
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'grvAlunos
        '
        Me.grvAlunos.AllowUserToAddRows = False
        Me.grvAlunos.AllowUserToOrderColumns = True
        Me.grvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nome, Me.Endereço, Me.Cidade, Me.UF, Me.Ativo})
        Me.grvAlunos.Location = New System.Drawing.Point(17, 156)
        Me.grvAlunos.Name = "grvAlunos"
        Me.grvAlunos.ReadOnly = True
        Me.grvAlunos.Size = New System.Drawing.Size(545, 288)
        Me.grvAlunos.TabIndex = 10
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 5.0!
        Me.id.HeaderText = ""
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Endereço
        '
        Me.Endereço.DataPropertyName = "endereco"
        Me.Endereço.HeaderText = "Endereço"
        Me.Endereço.Name = "Endereço"
        Me.Endereço.ReadOnly = True
        '
        'Cidade
        '
        Me.Cidade.DataPropertyName = "cidade"
        Me.Cidade.HeaderText = "Cidade"
        Me.Cidade.Name = "Cidade"
        Me.Cidade.ReadOnly = True
        '
        'UF
        '
        Me.UF.DataPropertyName = "uf"
        Me.UF.HeaderText = "UF"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        '
        'Ativo
        '
        Me.Ativo.DataPropertyName = "ativo"
        Me.Ativo.HeaderText = "Ativo"
        Me.Ativo.Name = "Ativo"
        Me.Ativo.ReadOnly = True
        Me.Ativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(97, 107)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(16, 107)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 13
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(178, 107)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(515, 83)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 15
        Me.lblId.Visible = False
        '
        'lblAguarde
        '
        Me.lblAguarde.AutoSize = True
        Me.lblAguarde.BackColor = System.Drawing.Color.Transparent
        Me.lblAguarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguarde.ForeColor = System.Drawing.Color.Red
        Me.lblAguarde.Location = New System.Drawing.Point(14, 457)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(147, 13)
        Me.lblAguarde.TabIndex = 16
        Me.lblAguarde.Text = "Aguarde. Processando..."
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Location = New System.Drawing.Point(487, 107)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorio.TabIndex = 17
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 482)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.lblAguarde)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.grvAlunos)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aluno"
        CType(Me.grvAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtUF As TextBox
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents grvAlunos As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents lblId As Label
    Friend WithEvents lblAguarde As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Endereço As DataGridViewTextBoxColumn
    Friend WithEvents Cidade As DataGridViewTextBoxColumn
    Friend WithEvents UF As DataGridViewTextBoxColumn
    Friend WithEvents Ativo As DataGridViewCheckBoxColumn
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents fbd1 As FolderBrowserDialog
End Class
