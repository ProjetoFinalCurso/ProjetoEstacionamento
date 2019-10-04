namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmClienteVeiculo
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
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
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
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clnMarca,
            this.clnModelo,
            this.clnCor,
            this.dataGridViewTextBoxColumn3});
            this.dgvVeiculos.Location = new System.Drawing.Point(1, 122);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(664, 292);
            this.dgvVeiculos.TabIndex = 71;
            this.dgvVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(9, 90);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(131, 26);
            this.txtPesquisa.TabIndex = 70;
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
            this.cboTipoPesquisa.Location = new System.Drawing.Point(154, 90);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(121, 26);
            this.cboTipoPesquisa.TabIndex = 72;
            this.cboTipoPesquisa.Text = "Placa";
            // 
            // ctsDelete
            // 
            this.ctsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctsDelete.Name = "ctsDelete";
            this.ctsDelete.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // btnNovoCarro
            // 
            this.btnNovoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCarro.Location = new System.Drawing.Point(546, 86);
            this.btnNovoCarro.Name = "btnNovoCarro";
            this.btnNovoCarro.Size = new System.Drawing.Size(107, 33);
            this.btnNovoCarro.TabIndex = 74;
            this.btnNovoCarro.Text = "Novo Carro";
            this.btnNovoCarro.UseVisualStyleBackColor = true;
            this.btnNovoCarro.Click += new System.EventHandler(this.btnNovoCarro_Click);
            // 
            // frmClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.btnNovoCarro);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cboTipoPesquisa);
            this.Name = "frmClienteVeiculo";
            this.Text = "Cliente Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ctsDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private _ProjetoFinalEstacionamento_DBDataSet _ProjetoFinalEstacionamento_DBDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private _ProjetoFinalEstacionamento_DBDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
        private System.Windows.Forms.ContextMenuStrip ctsDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnNovoCarro;
        private System.Windows.Forms.DataGridView dgvVeiculos;
    }
}