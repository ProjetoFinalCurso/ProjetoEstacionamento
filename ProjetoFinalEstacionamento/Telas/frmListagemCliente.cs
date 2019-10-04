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
    public partial class frmListagemCliente : Form
    {
        ClienteModel _clienteModel;
        ClienteNegocio _clienteNegocio;
        private int _index;

        public frmListagemCliente()
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _clienteNegocio = new ClienteNegocio();
            LoadCliente();
        }
        public void LoadCliente()
        {
            if (dgvCliente.Rows.Count > 0)
            {
                dgvCliente.Rows.Clear();
            }
            var lista = _clienteNegocio.Listar();
            foreach (var item in lista)
            {
                dgvCliente.Rows.Add(item.Id, item.Nome, item.Celular);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength == 0)
            {
                LoadCliente();
            }
            else
            {
                IList<ClienteModel> lista = _clienteNegocio.Listar()
                    .Where(r=>r.Nome.Contains(txtPesquisa.Text)).ToList();

                if (dgvCliente.Rows.Count > 0)
                {
                    dgvCliente.Rows.Clear();
                }
                foreach (var item in lista)
                {
                    dgvCliente.Rows.Add(item.Id, item.Nome, item.Celular);
                }
            }
        }
        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            var frmCadastro = new frmCadastroCliente();
            frmCadastro.ShowDialog();
            LoadCliente();
        }
        private void dgvCliente_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _index = e.RowIndex;
                this.dgvCliente.CurrentCell = this.dgvCliente.Rows[e.RowIndex].Cells[1];
                this.ctsDelete.Show(this.dgvCliente, e.Location);
                ctsDelete.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você deseja deletar esse cliente?", 
                "Deletar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int idCliente = int.Parse(dgvCliente.Rows[_index].Cells[0].Value.ToString());
                _clienteNegocio.Deletar(_clienteNegocio.Selecionar(idCliente));
                MessageBox.Show("Deletado com sucesso");
                LoadCliente();
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
            var clienteEditar = _clienteNegocio.Selecionar(id);
            var form = new frmCadastroCliente(clienteEditar);
            form.ShowDialog();
            LoadCliente();
        }
    }
}
