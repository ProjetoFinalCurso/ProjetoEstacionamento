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
    public partial class frmRegistrarEntradaSaida : Form
    {
        RegistroEntradaSaidaModel _registroESModel;
        RegistroEntradaSaidaNegocio _registroEntradaSaidaNegocio;
        VeiculoModel _veiculoModel;
        VeiculoNegocio _veiculoNegocio;
        TipoVeiculoNegocio _tipoVeiculoNegocio;
        int _idUsuario;
        public frmRegistrarEntradaSaida(int idUsuario)
        {
            InitializeComponent();
            _registroEntradaSaidaNegocio = new RegistroEntradaSaidaNegocio();
            _registroESModel = new RegistroEntradaSaidaModel();
            _veiculoModel = new VeiculoModel();
            _veiculoNegocio = new VeiculoNegocio();
            _tipoVeiculoNegocio = new TipoVeiculoNegocio();
            _idUsuario = idUsuario;
            LoadRegistros();
        }
        public void LoadRegistros()
        {
            if (dgvRegistroES.Rows.Count > 0)
            {
                dgvRegistroES.Rows.Clear();
            }
            var lista = _registroEntradaSaidaNegocio.Listar(r => r.Veiculo)
                .Where(r => r.Saida == null);
            foreach (var item in lista)
            {
                dgvRegistroES.Rows.Add(item.Id, item.Entrada,
                    item.Veiculo.Placa, item.Veiculo.Marca,
                    item.Veiculo.Modelo, item.Veiculo.Cor,
                    _tipoVeiculoNegocio.Selecionar(item.Veiculo.TipoVeiculoId).TipoVeiculo);
            }
        }
        private void dgvRegistroES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter Id da linha selecionado
            var id = Convert.ToInt32(dgvRegistroES.Rows[e.RowIndex].Cells[0].Value);
            //Obter o registro para editar com include de Veiculo
            var registroESEditar = _registroEntradaSaidaNegocio.Listar(r => r.Veiculo)
                .FirstOrDefault(r => r.Id == id);
            //Atribuindo a Data Hora de saida atual
            registroESEditar.Saida = DateTime.Now;
            //Atualizando no Banco o registro entrada e saida
            _registroEntradaSaidaNegocio.Atualiza(registroESEditar);
            //Obtendo a hora de Entrada e atribuindo a uma variavel
            var horaEntrada = registroESEditar.Entrada;
            //Obtendo a o tempo entre a Entrada e Saida atribuindo a uma variavel
            var tempoTotal = registroESEditar.Saida?.Subtract(horaEntrada);
            //Multiplicando o Valor hora do tipo de veiculo pelo resultado do tempo
            var valorFinal = tempoTotal?.TotalHours *
                _tipoVeiculoNegocio.Selecionar(registroESEditar.Veiculo.TipoVeiculoId).ValorHora;
            //Mensagem contendo o valor a receber
            MessageBox.Show($"valor total a receber: " +
                $"R${Convert.ToDouble(valorFinal).ToString("0.##")}"
                , "A receber", MessageBoxButtons.OK);
            //Recarrega a lista, menos o valor hora 
            LoadRegistros();
        }
        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            var form = new frmNovoRegistro(_idUsuario);
            form.ShowDialog();
            LoadRegistros();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength == 0)
            {
                LoadRegistros();
            }
            else
            {                
                string pesquisa = txtPesquisa.Text;
                IList<RegistroEntradaSaidaModel> lista = _registroEntradaSaidaNegocio
                    .Listar(r => r.Veiculo).Where(r => r.Saida == null).ToList();

                lista = lista.Where(r => r.Veiculo.Placa.Contains(pesquisa)).ToList();

                if (dgvRegistroES.Rows.Count > 0)
                {
                    dgvRegistroES.Rows.Clear();
                }
                foreach (var item in lista)
                {
                    dgvRegistroES.Rows.Add(item.Id, item.Entrada, item.Veiculo.Placa, item.Veiculo.Marca,
                    item.Veiculo.Modelo, item.Veiculo.Cor,
                    _tipoVeiculoNegocio.Selecionar(item.Veiculo.TipoVeiculoId).TipoVeiculo);
                }
            }
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroVeiculo();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroCliente();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUsuario();
            frm.ShowDialog();
        }

        private void tipoDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoVeiculo();
            frm.ShowDialog();
        }

        private void veiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmListagemVeiculo();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroVeiculo();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmListagemCliente();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new frmUsuario();
            frm.ShowDialog();
        }

        private void tipoDeVeiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoVeiculo();
            frm.ShowDialog();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _idUsuario = 0;
            var frm = new frmLogin();
            frm.Show();
        }
    }
}
