namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmListagemCliente
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
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoTableAdapter = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSetTableAdapters.VeiculoTableAdapter();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ProjetoFinalEstacionamento_DBDataSet = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSet();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.ctsDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoCarro
            // 
            this.btnNovoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCarro.Location = new System.Drawing.Point(494, 13);
            this.btnNovoCarro.Name = "btnNovoCarro";
            this.btnNovoCarro.Size = new System.Drawing.Size(107, 33);
            this.btnNovoCarro.TabIndex = 3;
            this.btnNovoCarro.Text = "Novo Carro";
            this.btnNovoCarro.UseVisualStyleBackColor = true;
            this.btnNovoCarro.Click += new System.EventHandler(this.btnNovoCarro_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // ctsDelete
            // 
            this.ctsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctsDelete.Name = "ctsDelete";
            this.ctsDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCelular});
            this.dgvCliente.Location = new System.Drawing.Point(0, 52);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(612, 316);
            this.dgvCliente.TabIndex = 77;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            this.dgvCliente.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_CellMouseUp);
            // 
            // clnId
            // 
            this.clnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnNome
            // 
            this.clnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnCelular
            // 
            this.clnCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCelular.HeaderText = "Celular";
            this.clnCelular.Name = "clnCelular";
            this.clnCelular.ReadOnly = true;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this._ProjetoFinalEstacionamento_DBDataSet;
            // 
            // _ProjetoFinalEstacionamento_DBDataSet
            // 
            this._ProjetoFinalEstacionamento_DBDataSet.DataSetName = "_ProjetoFinalEstacionamento_DBDataSet";
            this._ProjetoFinalEstacionamento_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(131, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // frmListagemCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 366);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnNovoCarro);
            this.Name = "frmListagemCliente";
            this.Text = "Listagem de Cliente";
            this.ctsDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCarro;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctsDelete;
        private System.Windows.Forms.DataGridView dgvCliente;
        private _ProjetoFinalEstacionamento_DBDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private _ProjetoFinalEstacionamento_DBDataSet _ProjetoFinalEstacionamento_DBDataSet;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCelular;
    }
}