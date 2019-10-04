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
    public partial class frmListagemVeiculo : Form
    {
        VeiculoModel _veiculoModel;
        VeiculoNegocio _veiculoNegocio;
        private int _index;

        public frmListagemVeiculo()
        {
            InitializeComponent();
            _veiculoModel = new VeiculoModel();
            _veiculoNegocio = new VeiculoNegocio();
            LoadVeiculos();
        }

        public void LoadVeiculos()
        {
            if (dgvVeiculos.Rows.Count > 0)
            {
                dgvVeiculos.Rows.Clear();
            }
            var lista = _veiculoNegocio.Listar(r=>r.TipoVeiculo);
            foreach (var item in lista)
            {
                dgvVeiculos.Rows.Add(item.Id, item.Placa, item.Marca, 
                    item.Modelo, item.Cor, item.TipoVeiculo.TipoVeiculo);
            }
        }

        //private void frmListagemVeiculo_Load(object sender, EventArgs e)
        //{
        //    // TODO: esta linha de código carrega dados na tabela '_ProjetoFinalEstacionamento_DBDataSet.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
        //    this.veiculoTableAdapter.Fill(this._ProjetoFinalEstacionamento_DBDataSet.Veiculo);

        //}          

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength == 0)
            {
                LoadVeiculos();
            }
            else
            {
                IList<VeiculoModel> lista = _veiculoNegocio.Listar(r => r.TipoVeiculo);
                string pesquisa = txtPesquisa.Text;
                switch (cboTipoPesquisa.Text)
                {
                    case "Placa":
                        lista = lista.Where(r => r.Placa.Contains(pesquisa)).ToList();
                        break;
                    case "Marca":
                        lista = lista.Where(r => r.Marca.Contains(pesquisa)).ToList();
                        break;
                    case "Modelo":
                        lista = lista.Where(r => r.Modelo.Contains(pesquisa)).ToList();
                        break;
                    case "Cor":
                        lista = lista.Where(r => r.Cor.Contains(pesquisa)).ToList();
                        break;
                    case "Tipo de Veiculo":
                        lista = lista.Where(r => r.TipoVeiculo.TipoVeiculo.Contains(pesquisa)).ToList();
                        break;
                }
                if (dgvVeiculos.Rows.Count > 0)
                {
                    dgvVeiculos.Rows.Clear();
                }
                foreach (var item in lista)
                {
                    dgvVeiculos.Rows.Add(item.Id, item.Placa, item.Marca, item.Modelo, 
                        item.Cor, item.TipoVeiculo.TipoVeiculo);
                }
            }
        }
        private void dgvVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvVeiculos.Rows[e.RowIndex].Cells[0].Value);
            var veiculoEditar = _veiculoNegocio.Selecionar(id);
            var form = new frmCadastroVeiculo(veiculoEditar);
            form.ShowDialog();
            LoadVeiculos();
        }
        private void dgvTipoVeiculo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _index = e.RowIndex;
                this.dgvVeiculos.CurrentCell = this.dgvVeiculos.Rows[e.RowIndex].Cells[1];
                this.ctsDelete.Show(this.dgvVeiculos, e.Location);
                ctsDelete.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você deseja deletar " +
                "esse veiculo?", "Deletar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int idVeiculo = int.Parse(dgvVeiculos.Rows[_index].Cells[0].Value.ToString());
                _veiculoNegocio.Deletar(_veiculoNegocio.Selecionar(idVeiculo));
                MessageBox.Show("Deletado com sucesso");
                LoadVeiculos();
            }
        }

        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroVeiculo();
            frm.ShowDialog();
            LoadVeiculos();
        }
    }
}
