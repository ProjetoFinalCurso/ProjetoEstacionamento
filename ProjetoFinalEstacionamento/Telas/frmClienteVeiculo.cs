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
    public partial class frmClienteVeiculo : Form
    {
        ClienteVeiculoModel _clienteVeiculoModel;
        ClienteVeiculoNegocio _clienteVeiculoNegocio;
        public frmClienteVeiculo(int idCliente)
        {
            InitializeComponent();
            _clienteVeiculoModel = new ClienteVeiculoModel();
            _clienteVeiculoModel.ClienteId = idCliente;
            _clienteVeiculoNegocio = new ClienteVeiculoNegocio();
            LoadVeiculos();
        }

        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroVeiculo();
            frm.ShowDialog();
            LoadVeiculos();
        }

        private void dgvVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvVeiculos.Rows[e.RowIndex].Cells[0].Value);
            _clienteVeiculoModel.VeiculoId = id;
            _clienteVeiculoNegocio.Incluir(_clienteVeiculoModel);
            MessageBox.Show("Veiculo adicionado com sucesso", "Adicionado", MessageBoxButtons.OK);
        }

        public void LoadVeiculos()
        {
            if (dgvVeiculos.Rows.Count > 0)
            {
                dgvVeiculos.Rows.Clear();
            }
            var lista = new VeiculoNegocio().Listar(r => r.TipoVeiculo);
            foreach (var item in lista)
            {
                dgvVeiculos.Rows.Add(item.Id, item.Placa, item.Marca,
                    item.Modelo, item.Cor, item.TipoVeiculo.TipoVeiculo);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength == 0)
            {
                LoadVeiculos();
            }
            else
            {
                IList<VeiculoModel> lista = new VeiculoNegocio().Listar(r => r.TipoVeiculo);
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
    }
}
