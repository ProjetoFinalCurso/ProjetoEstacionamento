namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmCadastroVeiculo
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cboTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.tipoVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ProjetoFinalEstacionamento_DBDataSet = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSet();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.tipoVeiculoTableAdapter = new ProjetoFinalEstacionamento._ProjetoFinalEstacionamento_DBDataSetTableAdapters.TipoVeiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(38, 108);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 41;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(38, 131);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(185, 26);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(385, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(275, 25);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 40;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 266);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 43;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(275, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(185, 26);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(275, 108);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 20);
            this.lblCor.TabIndex = 47;
            this.lblCor.Text = "Cor";
            this.lblCor.Click += new System.EventHandler(this.lblCor_Click);
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(275, 131);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(185, 26);
            this.txtCor.TabIndex = 4;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(38, 25);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 49;
            this.lblPlaca.Text = "Placa";
            this.lblPlaca.Click += new System.EventHandler(this.lblPlaca_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(38, 48);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(185, 26);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // cboTipoVeiculo
            // 
            this.cboTipoVeiculo.DataSource = this.tipoVeiculoBindingSource;
            this.cboTipoVeiculo.DisplayMember = "TipoVeiculo";
            this.cboTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoVeiculo.FormattingEnabled = true;
            this.cboTipoVeiculo.Location = new System.Drawing.Point(38, 211);
            this.cboTipoVeiculo.Name = "cboTipoVeiculo";
            this.cboTipoVeiculo.Size = new System.Drawing.Size(185, 28);
            this.cboTipoVeiculo.TabIndex = 5;
            this.cboTipoVeiculo.ValueMember = "Id";
            this.cboTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.cboTipoVeiculo_SelectedIndexChanged);
            // 
            // tipoVeiculoBindingSource
            // 
            this.tipoVeiculoBindingSource.DataMember = "TipoVeiculo";
            this.tipoVeiculoBindingSource.DataSource = this._ProjetoFinalEstacionamento_DBDataSet;
            // 
            // _ProjetoFinalEstacionamento_DBDataSet
            // 
            this._ProjetoFinalEstacionamento_DBDataSet.DataSetName = "_ProjetoFinalEstacionamento_DBDataSet";
            this._ProjetoFinalEstacionamento_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVeiculo.Location = new System.Drawing.Point(38, 188);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(117, 20);
            this.lblTipoVeiculo.TabIndex = 52;
            this.lblTipoVeiculo.Text = "Tipo do Veiculo";
            this.lblTipoVeiculo.Click += new System.EventHandler(this.lblTipoVeiculo_Click);
            // 
            // tipoVeiculoTableAdapter
            // 
            this.tipoVeiculoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 314);
            this.Controls.Add(this.lblTipoVeiculo);
            this.Controls.Add(this.cboTipoVeiculo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMarca);
            this.Name = "frmCadastroVeiculo";
            this.Text = "Cadastro de Veiculo";
            this.Load += new System.EventHandler(this.frmCadastroVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjetoFinalEstacionamento_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cboTipoVeiculo;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private _ProjetoFinalEstacionamento_DBDataSet _ProjetoFinalEstacionamento_DBDataSet;
        private System.Windows.Forms.BindingSource tipoVeiculoBindingSource;
        private _ProjetoFinalEstacionamento_DBDataSetTableAdapters.TipoVeiculoTableAdapter tipoVeiculoTableAdapter;
    }
}