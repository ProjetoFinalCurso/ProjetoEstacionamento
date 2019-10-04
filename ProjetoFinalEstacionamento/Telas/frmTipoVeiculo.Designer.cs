namespace ProjetoFinalEstacionamento.Telas
{
    partial class frmTipoVeiculo
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
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.dgvTipoVeiculo = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoVeiculo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ctsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeiculo)).BeginInit();
            this.ctsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHora.Location = new System.Drawing.Point(283, 40);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(85, 20);
            this.lblValorHora.TabIndex = 34;
            this.lblValorHora.Text = "Valor Hora";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(283, 63);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(185, 26);
            this.txtValorHora.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(393, 124);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVeiculo.Location = new System.Drawing.Point(46, 40);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(61, 20);
            this.lblTipoVeiculo.TabIndex = 29;
            this.lblTipoVeiculo.Text = "Veiculo";
            // 
            // dgvTipoVeiculo
            // 
            this.dgvTipoVeiculo.AllowUserToAddRows = false;
            this.dgvTipoVeiculo.AllowUserToDeleteRows = false;
            this.dgvTipoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnTipoVeiculo,
            this.clnValorHora});
            this.dgvTipoVeiculo.Location = new System.Drawing.Point(0, 172);
            this.dgvTipoVeiculo.Name = "dgvTipoVeiculo";
            this.dgvTipoVeiculo.ReadOnly = true;
            this.dgvTipoVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVeiculo.Size = new System.Drawing.Size(502, 228);
            this.dgvTipoVeiculo.TabIndex = 35;
            this.dgvTipoVeiculo.TabStop = false;
            this.dgvTipoVeiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoVeiculo_CellDoubleClick);
            this.dgvTipoVeiculo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoVeiculo_CellMouseUp);
            // 
            // clnId
            // 
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnTipoVeiculo
            // 
            this.clnTipoVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTipoVeiculo.HeaderText = "Tipo do Veículo";
            this.clnTipoVeiculo.Name = "clnTipoVeiculo";
            this.clnTipoVeiculo.ReadOnly = true;
            // 
            // clnValorHora
            // 
            this.clnValorHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnValorHora.HeaderText = "Valor da Hora";
            this.clnValorHora.Name = "clnValorHora";
            this.clnValorHora.ReadOnly = true;
            // 
            // txtTipoVeiculo
            // 
            this.txtTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVeiculo.Location = new System.Drawing.Point(46, 63);
            this.txtTipoVeiculo.Name = "txtTipoVeiculo";
            this.txtTipoVeiculo.Size = new System.Drawing.Size(185, 26);
            this.txtTipoVeiculo.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(50, 124);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 36;
            this.txtId.Visible = false;
            // 
            // ctsDelete
            // 
            this.ctsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctsDelete.Name = "contextMenuStrip1";
            this.ctsDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmTipoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 398);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvTipoVeiculo);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTipoVeiculo);
            this.Controls.Add(this.txtTipoVeiculo);
            this.Name = "frmTipoVeiculo";
            this.Text = "Tipo de Veículo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeiculo)).EndInit();
            this.ctsDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.DataGridView dgvTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorHora;
        private System.Windows.Forms.TextBox txtTipoVeiculo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ContextMenuStrip ctsDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}