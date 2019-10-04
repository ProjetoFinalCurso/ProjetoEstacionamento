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
    public partial class frmCadastroCliente : Form
    {
        ClienteModel _clienteModel;
        ClienteNegocio _clienteNegocio;
        ClienteVeiculoNegocio _clienteVeiculoNegocio;
        private int _index;

        public frmCadastroCliente()
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _clienteNegocio = new ClienteNegocio();
            _clienteVeiculoNegocio = new ClienteVeiculoNegocio();
        }
        public frmCadastroCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _clienteModel = cliente ?? new ClienteModel();
            _clienteNegocio = new ClienteNegocio();
            _clienteVeiculoNegocio = new ClienteVeiculoNegocio();
            Editar();
            LoadVeiculos();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _clienteModel.Nome = txtNome.Text;
            _clienteModel.RG = txtRG.Text;
            _clienteModel.CPF = txtCPF.Text;
            _clienteModel.DataNascimento = DateTime.Parse(mtbDataNascimento.Text);
            _clienteModel.Celular = txtCelular.Text;
            if (txtId.Text != null && int.TryParse(txtId.Text, out int id))
            {
                _clienteModel.Id = id;
                _clienteNegocio.Atualiza(_clienteModel);
            }
            else
            {
                _clienteNegocio.Incluir(_clienteModel);
                txtId.Text = _clienteModel.Id.ToString();
            }
            var clienteId = _clienteModel.Id;
            btnAdicionarCarro.Enabled = true;
            btnNovoCliente.Enabled = true;
        }

        public void Editar()
        {
            txtNome.Text = _clienteModel.Nome;
            txtRG.Text = _clienteModel.RG;
            txtCPF.Text = _clienteModel.CPF;
            txtCelular.Text = _clienteModel.Celular;
            txtId.Text = _clienteModel.Id.ToString();
            mtbDataNascimento.Text = _clienteModel.DataNascimento.ToString();
            btnAdicionarCarro.Enabled = true;
            btnNovoCliente.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtCelular.Clear();
            txtId.Clear();
            mtbDataNascimento.Clear();
            mtbDataNascimento.Mask = "00/00/0000";
            btnAdicionarCarro.Enabled = false;
            btnNovoCliente.Enabled = false;
        }
        public void LoadVeiculos()
        {
            if (_clienteModel.Id != 0)
            {
                TipoVeiculoNegocio tipoVeiculoNegocio = new TipoVeiculoNegocio();

                if (dgvVeiculos.Rows.Count > 0)
                {
                    dgvVeiculos.Rows.Clear();
                }
                var listaClienteVeiculo = _clienteVeiculoNegocio.Listar(r => r.Veiculo)
                    .Where(r => r.ClienteId == _clienteModel.Id);
                foreach (var item in listaClienteVeiculo)
                {
                    dgvVeiculos.Rows.Add(item.Id, item.Veiculo.Placa,
                        tipoVeiculoNegocio.Selecionar(item.Veiculo.TipoVeiculoId).TipoVeiculo);
                }
            }
        }
        private void dgvVeiculos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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
            DialogResult dr = MessageBox.Show("Você deseja deletar esse veiculo?",
                "Deletar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int idClienteVeiculo = int.Parse(dgvVeiculos.Rows[_index].Cells[0].Value.ToString());
                _clienteVeiculoNegocio.Deletar(_clienteVeiculoNegocio.Selecionar(idClienteVeiculo));
                MessageBox.Show("Deletado com sucesso");
                LoadVeiculos();
            }
        }

        private void btnAdicionarCarro_Click(object sender, EventArgs e)
        {
            var frm = new frmClienteVeiculo(_clienteModel.Id);
            frm.ShowDialog();
            LoadVeiculos();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

