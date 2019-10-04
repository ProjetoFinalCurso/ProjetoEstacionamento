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
    public partial class frmCadastroVeiculo : Form
    {
        VeiculoModel _veiculoModel;
        VeiculoNegocio _veiculoNegocio;
        public frmCadastroVeiculo()
        {
            InitializeComponent();
            _veiculoModel = new VeiculoModel();
            _veiculoNegocio = new VeiculoNegocio();
        }
        public frmCadastroVeiculo(VeiculoModel veiculo)
        {
            InitializeComponent();
            _veiculoModel = veiculo;
            _veiculoNegocio = new VeiculoNegocio();
            Editar();
        }

        public void Editar()
        {
            txtPlaca.Text = _veiculoModel.Placa;
            txtCor.Text = _veiculoModel.Cor;
            txtMarca.Text = _veiculoModel.Marca;
            txtModelo.Text = _veiculoModel.Modelo;
            txtId.Text = _veiculoModel.Id.ToString();
            cboTipoVeiculo.SelectedValue = _veiculoModel.Id;
        }

        private void frmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_ProjetoFinalEstacionamento_DBDataSet.TipoVeiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoVeiculoTableAdapter.Fill(this._ProjetoFinalEstacionamento_DBDataSet.TipoVeiculo);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            _veiculoModel.Marca = txtMarca.Text;
            _veiculoModel.Modelo = txtModelo.Text;
            _veiculoModel.Placa = txtPlaca.Text;
            _veiculoModel.Cor = txtCor.Text;
            _veiculoModel.TipoVeiculoId = Convert.ToInt32(cboTipoVeiculo.SelectedValue);
            if (txtId.Text != null && int.TryParse(txtId.Text, out int id))
            {
                _veiculoModel.Id = id;
                _veiculoNegocio.Atualiza(_veiculoModel);
                this.Close();
            }
            else
            {
                _veiculoNegocio.Incluir(_veiculoModel);
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtPlaca.Clear();
            txtCor.Clear();
        }

        private void cboTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

