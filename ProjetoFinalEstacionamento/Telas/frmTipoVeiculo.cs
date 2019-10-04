using ProjetoFinalEstacionamento.Modelo;
using ProjetoFinalEstacionamento.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalEstacionamento.Telas
{
    public partial class frmTipoVeiculo : Form
    {
        int _index = -1;
        public frmTipoVeiculo()
        {
            InitializeComponent();

            LoadTipoVeiculos();
        }

        public void LoadTipoVeiculos()
        {
            if (dgvTipoVeiculo.Rows.Count > 0)
            {
                dgvTipoVeiculo.Rows.Clear();
            }
            TipoVeiculoNegocio tipoVeiculoNegocio = new TipoVeiculoNegocio();
            var lista = tipoVeiculoNegocio.Listar();
            foreach (var item in lista)
            {                
                dgvTipoVeiculo.Rows.Add(item.Id, item.TipoVeiculo, item.ValorHora);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoVeiculoNegocio tipoVeiculoNegocio = new TipoVeiculoNegocio();
            TipoVeiculoModel tipoVeiculo = new TipoVeiculoModel();
            tipoVeiculo.TipoVeiculo = txtTipoVeiculo.Text;
            if (double.TryParse(txtValorHora.Text, out double valorHora))
            {
                tipoVeiculo.ValorHora = valorHora;
            }
            //Verifica se o textbox id não é null e se pode ser convertido para o inteiro
            if (txtId.Text != null && int.TryParse(txtId.Text, out int id))
            {
                tipoVeiculo.Id = id;
                tipoVeiculoNegocio.Atualiza(tipoVeiculo);
            }
            else
            {
                tipoVeiculoNegocio.Incluir(tipoVeiculo);
            }

            LoadTipoVeiculos();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtId.Clear();
            txtTipoVeiculo.Clear();
            txtValorHora.Clear();
        }

        private void dgvTipoVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTipoVeiculo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTipoVeiculo.Text = dgvTipoVeiculo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtValorHora.Text = dgvTipoVeiculo.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvTipoVeiculo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _index = e.RowIndex;
                this.dgvTipoVeiculo.CurrentCell = this.dgvTipoVeiculo.Rows[e.RowIndex].Cells[1];
                this.ctsDelete.Show(this.dgvTipoVeiculo, e.Location);
                ctsDelete.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você deseja deletar esse tipo veiculo?", "Deletar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var tipoNegocio = new TipoVeiculoNegocio();
                int idTipoVeiculo = int.Parse(dgvTipoVeiculo.Rows[_index].Cells[0].Value.ToString());
                tipoNegocio.Deletar(tipoNegocio.Selecionar(idTipoVeiculo));
                MessageBox.Show("Deletado com sucesso");
                LoadTipoVeiculos();                
            }
        }
    }
}
