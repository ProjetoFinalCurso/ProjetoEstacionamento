namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmRegistrarEntradaSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNovoCarro = new System.Windows.Forms.Button();
            this.dgvRegistroES = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.ctsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVeiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroES)).BeginInit();
            this.ctsDelete.SuspendLayout();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoCarro
            // 
            this.btnNovoCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCarro.Location = new System.Drawing.Point(544, 75);
            this.btnNovoCarro.Name = "btnNovoCarro";
            this.btnNovoCarro.Size = new System.Drawing.Size(143, 28);
            this.btnNovoCarro.TabIndex = 78;
            this.btnNovoCarro.Text = "Novo Registro";
            this.btnNovoCarro.UseVisualStyleBackColor = true;
            this.btnNovoCarro.Click += new System.EventHandler(this.btnNovoCarro_Click);
            // 
            // dgvRegistroES
            // 
            this.dgvRegistroES.AllowUserToAddRows = false;
            this.dgvRegistroES.AllowUserToDeleteRows = false;
            this.dgvRegistroES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistroES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clnHoraEntrada,
            this.dataGridViewTextBoxColumn2,
            this.clnMarca,
            this.clnModelo,
            this.clnCor,
            this.dataGridViewTextBoxColumn3});
            this.dgvRegistroES.Location = new System.Drawing.Point(0, 109);
            this.dgvRegistroES.Name = "dgvRegistroES";
            this.dgvRegistroES.ReadOnly = true;
            this.dgvRegistroES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroES.Size = new System.Drawing.Size(700, 265);
            this.dgvRegistroES.TabIndex = 76;
            this.dgvRegistroES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroES_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // clnHoraEntrada
            // 
            this.clnHoraEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnHoraEntrada.HeaderText = "Hora de Entrada";
            this.clnHoraEntrada.Name = "clnHoraEntrada";
            this.clnHoraEntrada.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clnMarca
            // 
            this.clnMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnMarca.HeaderText = "Marca";
            this.clnMarca.Name = "clnMarca";
            this.clnMarca.ReadOnly = true;
            // 
            // clnModelo
            // 
            this.clnModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnModelo.HeaderText = "Modelo";
            this.clnModelo.Name = "clnModelo";
            this.clnModelo.ReadOnly = true;
            // 
            // clnCor
            // 
            this.clnCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCor.HeaderText = "Cor";
            this.clnCor.Name = "clnCor";
            this.clnCor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo do Veiculo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 75);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(131, 26);
            this.txtPesquisa.TabIndex = 75;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // ctsDelete
            // 
            this.ctsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctsDelete.Name = "ctsDelete";
            this.ctsDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.listagemToolStripMenuItem,
            this.deslogarToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(699, 24);
            this.mspMenu.TabIndex = 79;
            this.mspMenu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.tipoDeVeiculoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoDeVeiculoToolStripMenuItem
            // 
            this.tipoDeVeiculoToolStripMenuItem.Name = "tipoDeVeiculoToolStripMenuItem";
            this.tipoDeVeiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeVeiculoToolStripMenuItem.Text = "Tipo de Veiculo";
            this.tipoDeVeiculoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeVeiculoToolStripMenuItem_Click);
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculoToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.usuarioToolStripMenuItem2,
            this.tipoDeVeiculoToolStripMenuItem1});
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.listagemToolStripMenuItem.Text = "Listagem";
            // 
            // veiculoToolStripMenuItem1
            // 
            this.veiculoToolStripMenuItem1.Name = "veiculoToolStripMenuItem1";
            this.veiculoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.veiculoToolStripMenuItem1.Text = "Veiculo";
            this.veiculoToolStripMenuItem1.Click += new System.EventHandler(this.veiculoToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem2
            // 
            this.usuarioToolStripMenuItem2.Name = "usuarioToolStripMenuItem2";
            this.usuarioToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem2.Text = "Usuario";
            this.usuarioToolStripMenuItem2.Click += new System.EventHandler(this.usuarioToolStripMenuItem2_Click);
            // 
            // tipoDeVeiculoToolStripMenuItem1
            // 
            this.tipoDeVeiculoToolStripMenuItem1.Name = "tipoDeVeiculoToolStripMenuItem1";
            this.tipoDeVeiculoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tipoDeVeiculoToolStripMenuItem1.Text = "Tipo de Veiculo";
            this.tipoDeVeiculoToolStripMenuItem1.Click += new System.EventHandler(this.tipoDeVeiculoToolStripMenuItem1_Click);
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // frmRegistrarEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 371);
            this.Controls.Add(this.mspMenu);
            this.Controls.Add(this.btnNovoCarro);
            this.Controls.Add(this.dgvRegistroES);
            this.Controls.Add(this.txtPesquisa);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmRegistrarEntradaSaida";
            this.Text = "Registro de Entrada e Saida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroES)).EndInit();
            this.ctsDelete.ResumeLayout(false);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCarro;
        private System.Windows.Forms.DataGridView dgvRegistroES;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ContextMenuStrip ctsDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVeiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
    }
}