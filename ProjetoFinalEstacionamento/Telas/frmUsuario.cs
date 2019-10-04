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
    public partial class frmUsuario : Form
    {
        UsuarioModel _usuarioModel;
        UsuarioNegocio _usuarioNegocio;
        int _index;
        public frmUsuario()
        {
            InitializeComponent();
            _usuarioModel = new UsuarioModel();
            _usuarioNegocio = new UsuarioNegocio();
            LoadUsuarios();
        }
        public void LoadUsuarios()
        {
            var lista = _usuarioNegocio.Listar();
            dgvUsuario.DataSource = lista;            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            _usuarioModel.Nome = txtNome.Text;
            _usuarioModel.Senha = txtSenha.Text;
            if (txtId.Text != null && int.TryParse(txtId.Text, out int id))
            {
                _usuarioModel.Id = id;
                _usuarioNegocio.Atualiza(_usuarioModel);
            }
            else
            {
                _usuarioNegocio.Incluir(_usuarioModel);
            }

            LoadUsuarios();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtId.Clear();
            txtSenha.Clear();
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvUsuario_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _index = e.RowIndex;
                this.dgvUsuario.CurrentCell = this.dgvUsuario.Rows[e.RowIndex].Cells[1];
                this.ctsDelete.Show(this.dgvUsuario, e.Location);
                ctsDelete.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você deseja deletar esse Usuário?", "Deletar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {                
                int idUsuario = int.Parse(dgvUsuario.Rows[_index].Cells[0].Value.ToString());
                _usuarioNegocio.Deletar(_usuarioNegocio.Selecionar(idUsuario));
                MessageBox.Show("Deletado com sucesso");
                LoadUsuarios();
            }
        }
    }
}
