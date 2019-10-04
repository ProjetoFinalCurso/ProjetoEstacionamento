using ProjetoFinalEstacionamento.Contexto;
using ProjetoFinalEstacionamento.Modelo;
using ProjetoFinalEstacionamento.Negocio;
using ProjetoFinalEstacionamento.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalEstacionamento.Telas
{
    public partial class frmLogin : Form
    {
        UsuarioModel _usuarioModel;
        UsuarioNegocio _usuarioNegocio;
        public frmLogin()
        {
            InitializeComponent();
            _usuarioModel = new UsuarioModel();
            _usuarioNegocio = new UsuarioNegocio();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioNegocio.Listar()
                .FirstOrDefault(r => r.Nome == txtNome.Text && r.Senha == txtSenha.Text);
            if (usuario != null)
            {
                var form = new frmRegistrarEntradaSaida(usuario.Id);
                form.Show();                
            }
            else
            {
                lblErro.Visible = true;
            }
        }
    }
}
