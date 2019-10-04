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
    public partial class frmNovoRegistro : Form
    {
        RegistroEntradaSaidaModel _registroEntradaSaidaModel;
        RegistroEntradaSaidaNegocio _registroEntradaSaidaNegocio;
        ClienteNegocio _clienteNegocio;
        VeiculoModel _veiculoModel;        
        VeiculoNegocio _veiculoNegocio;
        int _idUsuario;
        public frmNovoRegistro(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _veiculoModel = new VeiculoModel();
            _veiculoNegocio = new VeiculoNegocio();
            _clienteNegocio = new ClienteNegocio();
            _registroEntradaSaidaNegocio = new RegistroEntradaSaidaNegocio();
            _registroEntradaSaidaModel = new RegistroEntradaSaidaModel();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _veiculoModel = _veiculoNegocio.Listar(r => r.ClienteVeiculos)
                .FirstOrDefault(r => r.Placa == txtPlaca.Text);

            foreach (var item in _veiculoModel.ClienteVeiculos)
            {
                var itemKeyValue = new KeyValuePair<int, string>(item.Id,
                    _clienteNegocio.Selecionar(item.ClienteId).Nome);
                cboCliente.Items.Add(itemKeyValue);
            }
            cboCliente.DisplayMember = "Value";
            cboCliente.ValueMember = "Key";
            cboCliente.SelectedIndex = 0;
            cboCliente.Enabled = true;
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _registroEntradaSaidaModel.Entrada = DateTime.Now;
            _registroEntradaSaidaModel.UsuarioId = _idUsuario;
            _registroEntradaSaidaModel.VeiculoId = _veiculoModel.Id;
            _registroEntradaSaidaNegocio.Incluir(_registroEntradaSaidaModel);
            this.Close();
        }
    }
}
