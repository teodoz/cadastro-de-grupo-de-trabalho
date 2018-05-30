namespace EquipeDesenvolvedores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lista = new System.Windows.Forms.DataGridView();
            this.nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.funcao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelNome = new MaterialSkin.Controls.MaterialLabel();
            this.labelRA = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.labelFuncao = new MaterialSkin.Controls.MaterialLabel();
            this.inserir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.excluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.atualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.campoBusca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buscar = new MaterialSkin.Controls.MaterialFlatButton();
            this.listarTodos = new MaterialSkin.Controls.MaterialFlatButton();
            this.cancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelBusca = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.lista.Location = new System.Drawing.Point(403, 165);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.Size = new System.Drawing.Size(453, 210);
            this.lista.TabIndex = 10;
            this.lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellContentClick);
            // 
            // nome
            // 
            this.nome.Depth = 0;
            this.nome.Hint = "";
            this.nome.Location = new System.Drawing.Point(43, 136);
            this.nome.MaxLength = 32767;
            this.nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.SelectedText = "";
            this.nome.SelectionLength = 0;
            this.nome.SelectionStart = 0;
            this.nome.Size = new System.Drawing.Size(335, 23);
            this.nome.TabIndex = 13;
            this.nome.TabStop = false;
            this.nome.UseSystemPasswordChar = false;
            // 
            // ra
            // 
            this.ra.Depth = 0;
            this.ra.Hint = "";
            this.ra.Location = new System.Drawing.Point(43, 187);
            this.ra.MaxLength = 32767;
            this.ra.MouseState = MaterialSkin.MouseState.HOVER;
            this.ra.Name = "ra";
            this.ra.PasswordChar = '\0';
            this.ra.SelectedText = "";
            this.ra.SelectionLength = 0;
            this.ra.SelectionStart = 0;
            this.ra.Size = new System.Drawing.Size(335, 23);
            this.ra.TabIndex = 14;
            this.ra.TabStop = false;
            this.ra.UseSystemPasswordChar = false;
            // 
            // email
            // 
            this.email.Depth = 0;
            this.email.Hint = "";
            this.email.Location = new System.Drawing.Point(43, 239);
            this.email.MaxLength = 32767;
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(335, 23);
            this.email.TabIndex = 15;
            this.email.TabStop = false;
            this.email.UseSystemPasswordChar = false;
            // 
            // funcao
            // 
            this.funcao.Depth = 0;
            this.funcao.Hint = "";
            this.funcao.Location = new System.Drawing.Point(43, 291);
            this.funcao.MaxLength = 32767;
            this.funcao.MouseState = MaterialSkin.MouseState.HOVER;
            this.funcao.Name = "funcao";
            this.funcao.PasswordChar = '\0';
            this.funcao.SelectedText = "";
            this.funcao.SelectionLength = 0;
            this.funcao.SelectionStart = 0;
            this.funcao.Size = new System.Drawing.Size(335, 23);
            this.funcao.TabIndex = 16;
            this.funcao.TabStop = false;
            this.funcao.UseSystemPasswordChar = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Depth = 0;
            this.labelNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNome.Location = new System.Drawing.Point(39, 114);
            this.labelNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 19);
            this.labelNome.TabIndex = 17;
            this.labelNome.Text = "Nome";
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.BackColor = System.Drawing.Color.Transparent;
            this.labelRA.Depth = 0;
            this.labelRA.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRA.Location = new System.Drawing.Point(39, 165);
            this.labelRA.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(28, 19);
            this.labelRA.TabIndex = 18;
            this.labelRA.Text = "RA";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Depth = 0;
            this.labelEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.Location = new System.Drawing.Point(39, 217);
            this.labelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 19);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "E-mail";
            // 
            // labelFuncao
            // 
            this.labelFuncao.AutoSize = true;
            this.labelFuncao.BackColor = System.Drawing.Color.Transparent;
            this.labelFuncao.Depth = 0;
            this.labelFuncao.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFuncao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFuncao.Location = new System.Drawing.Point(39, 269);
            this.labelFuncao.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFuncao.Name = "labelFuncao";
            this.labelFuncao.Size = new System.Drawing.Size(58, 19);
            this.labelFuncao.TabIndex = 20;
            this.labelFuncao.Text = "Função";
            // 
            // inserir
            // 
            this.inserir.AutoSize = true;
            this.inserir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inserir.BackColor = System.Drawing.SystemColors.Control;
            this.inserir.Depth = 0;
            this.inserir.Icon = ((System.Drawing.Image)(resources.GetObject("inserir.Icon")));
            this.inserir.Location = new System.Drawing.Point(278, 339);
            this.inserir.MouseState = MaterialSkin.MouseState.HOVER;
            this.inserir.Name = "inserir";
            this.inserir.Primary = true;
            this.inserir.Size = new System.Drawing.Size(100, 36);
            this.inserir.TabIndex = 21;
            this.inserir.Text = "Inserir";
            this.inserir.UseVisualStyleBackColor = false;
            this.inserir.Click += new System.EventHandler(this.inserir_Click_1);
            // 
            // excluir
            // 
            this.excluir.AutoSize = true;
            this.excluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.excluir.Depth = 0;
            this.excluir.Icon = ((System.Drawing.Image)(resources.GetObject("excluir.Icon")));
            this.excluir.Location = new System.Drawing.Point(168, 339);
            this.excluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.excluir.Name = "excluir";
            this.excluir.Primary = true;
            this.excluir.Size = new System.Drawing.Size(103, 36);
            this.excluir.TabIndex = 22;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click_1);
            // 
            // atualizar
            // 
            this.atualizar.AutoSize = true;
            this.atualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.atualizar.Depth = 0;
            this.atualizar.Icon = ((System.Drawing.Image)(resources.GetObject("atualizar.Icon")));
            this.atualizar.Location = new System.Drawing.Point(278, 339);
            this.atualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.atualizar.Name = "atualizar";
            this.atualizar.Primary = true;
            this.atualizar.Size = new System.Drawing.Size(100, 36);
            this.atualizar.TabIndex = 23;
            this.atualizar.Text = "Salvar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // campoBusca
            // 
            this.campoBusca.Depth = 0;
            this.campoBusca.Hint = "Digite o RA";
            this.campoBusca.Location = new System.Drawing.Point(404, 133);
            this.campoBusca.MaxLength = 32767;
            this.campoBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.campoBusca.Name = "campoBusca";
            this.campoBusca.PasswordChar = '\0';
            this.campoBusca.SelectedText = "";
            this.campoBusca.SelectionLength = 0;
            this.campoBusca.SelectionStart = 0;
            this.campoBusca.Size = new System.Drawing.Size(192, 23);
            this.campoBusca.TabIndex = 24;
            this.campoBusca.TabStop = false;
            this.campoBusca.UseSystemPasswordChar = false;
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscar.Depth = 0;
            this.buscar.Icon = ((System.Drawing.Image)(resources.GetObject("buscar.Icon")));
            this.buscar.Location = new System.Drawing.Point(603, 120);
            this.buscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscar.Name = "buscar";
            this.buscar.Primary = false;
            this.buscar.Size = new System.Drawing.Size(102, 36);
            this.buscar.TabIndex = 25;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // listarTodos
            // 
            this.listarTodos.AutoSize = true;
            this.listarTodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listarTodos.Depth = 0;
            this.listarTodos.Icon = ((System.Drawing.Image)(resources.GetObject("listarTodos.Icon")));
            this.listarTodos.Location = new System.Drawing.Point(713, 120);
            this.listarTodos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listarTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.listarTodos.Name = "listarTodos";
            this.listarTodos.Primary = false;
            this.listarTodos.Size = new System.Drawing.Size(143, 36);
            this.listarTodos.TabIndex = 26;
            this.listarTodos.Text = "Listar Todos";
            this.listarTodos.UseVisualStyleBackColor = true;
            this.listarTodos.Click += new System.EventHandler(this.listarTodos_Click);
            // 
            // cancelar
            // 
            this.cancelar.AutoSize = true;
            this.cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cancelar.Depth = 0;
            this.cancelar.Icon = ((System.Drawing.Image)(resources.GetObject("cancelar.Icon")));
            this.cancelar.Location = new System.Drawing.Point(43, 339);
            this.cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelar.Name = "cancelar";
            this.cancelar.Primary = true;
            this.cancelar.Size = new System.Drawing.Size(119, 36);
            this.cancelar.TabIndex = 27;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // labelBusca
            // 
            this.labelBusca.AutoSize = true;
            this.labelBusca.BackColor = System.Drawing.Color.Transparent;
            this.labelBusca.Depth = 0;
            this.labelBusca.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBusca.Location = new System.Drawing.Point(400, 91);
            this.labelBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBusca.Name = "labelBusca";
            this.labelBusca.Size = new System.Drawing.Size(195, 19);
            this.labelBusca.TabIndex = 28;
            this.labelBusca.Text = "Lista de Membros do Grupo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 399);
            this.Controls.Add(this.labelBusca);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.listarTodos);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.campoBusca);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.labelFuncao);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelRA);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.funcao);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lista);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cadastro de Grupo de Trabalho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView lista;
        private MaterialSkin.Controls.MaterialSingleLineTextField nome;
        private MaterialSkin.Controls.MaterialSingleLineTextField ra;
        private MaterialSkin.Controls.MaterialSingleLineTextField email;
        private MaterialSkin.Controls.MaterialSingleLineTextField funcao;
        private MaterialSkin.Controls.MaterialLabel labelNome;
        private MaterialSkin.Controls.MaterialLabel labelRA;
        private MaterialSkin.Controls.MaterialLabel labelEmail;
        private MaterialSkin.Controls.MaterialLabel labelFuncao;
        private MaterialSkin.Controls.MaterialRaisedButton inserir;
        private MaterialSkin.Controls.MaterialRaisedButton excluir;
        private MaterialSkin.Controls.MaterialRaisedButton atualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField campoBusca;
        private MaterialSkin.Controls.MaterialFlatButton buscar;
        private MaterialSkin.Controls.MaterialFlatButton listarTodos;
        private MaterialSkin.Controls.MaterialRaisedButton cancelar;
        private MaterialSkin.Controls.MaterialLabel labelBusca;
    }
}

