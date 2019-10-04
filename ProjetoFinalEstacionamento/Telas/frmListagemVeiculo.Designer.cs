namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmListagemVeiculo
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ProjetoFinalEstacionamento_DBDataSet = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSetTableAdapters.VeiculoTableAdapter();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.ctsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovoCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.ctsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(13, 51);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(131, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnPlaca,
            this.clnMarca,
            this.clnModelo,
            this.clnCor,
            this.clnTipoVeiculo});
            this.dgvVeiculos.Location = new System.Drawing.Point(1, 84);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(612, 301);
            this.dgvVeiculos.TabIndex = 2;
            this.dgvVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellDoubleClick);
            this.dgvVeiculos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoVeiculo_CellMouseUp);
            // 
            // clnId
            // 
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnPlaca
            // 
            this.clnPlaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPlaca.HeaderText = "Placa";
            this.clnPlaca.Name = "clnPlaca";
            this.clnPlaca.ReadOnly = true;
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
            // clnTipoVeiculo
            // 
            this.clnTipoVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTipoVeiculo.HeaderText = "Tipo do Veiculo";
            this.clnTipoVeiculo.Name = "clnTipoVeiculo";
            this.clnTipoVeiculo.ReadOnly = true;
            // 
            // _ProjetoFinalEstacionamento_DBDataSet
            // 
            this._ProjetoFinalEstacionamento_DBDataSet.DataSetName = "_ProjetoFinalEstacionamento_DBDataSet";
            this._ProjetoFinalEstacionamento_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this._ProjetoFinalEstacionamento_DBDataSet;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // cboTipoPesquisa
            // 
            this.cboTipoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPesquisa.FormattingEnabled = true;
            this.cboTipoPesquisa.Items.AddRange(new object[] {
            "Placa",
            "Marca",
            "Modelo",
            "Cor",
            "Tipo do Veiculo"});
            this.cboTipoPesquisa.Location = new System.Drawing.Point(161, 51);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(121, 26);
            this.cboTipoPesquisa.TabIndex = 3;
            this.cboTipoPesquisa.Text = "Placa";
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
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnNovoCarro
            // 
            this.btnNovoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCarro.Location = new System.Drawing.Point(495, 45);
            this.btnNovoCarro.Name = "btnNovoCarro";
            this.btnNovoCarro.Size = new System.Drawing.Size(107, 33);
            this.btnNovoCarro.TabIndex = 75;
            this.btnNovoCarro.Text = "Novo Carro";
            this.btnNovoCarro.UseVisualStyleBackColor = true;
            this.btnNovoCarro.Click += new System.EventHandler(this.btnNovoCarro_Click);
            // 
            // frmListagemVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.btnNovoCarro);
            this.Controls.Add(this.cboTipoPesquisa);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmListagemVeiculo";
            this.Text = "Lista de Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ctsDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private _ProjetoFinalEstacionamento_DBDataSet _ProjetoFinalEstacionamento_DBDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private _ProjetoFinalEstacionamento_DBDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoVeiculo;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
        private System.Windows.Forms.ContextMenuStrip ctsDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnNovoCarro;
    }
}