using SoccerManager.BLL;
using SoccerManager.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManager.UI
{
    public partial class ListaPosicoesForm : BaseForm
    {
        public ListaPosicoesForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ListaPosicoesForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            using (var bo = new PosicaoBO())
            {
                dgvPosicoes.AutoGenerateColumns = false;

                bsPosicoes.DataSource = bo.List();
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CadastroPosicoesForm(this);
            form.Show();
        }

        private void dgvPosicoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var bo = new PosicaoBO())
            {
                var id = dgvPosicoes.Rows[e.RowIndex].Cells["Id"].Value.ToString().ToInt();

                var posicao = bo.Get(id);

                var form = new CadastroPosicoesForm(this, posicao);
                form.Show();
            }
        }
    }
}
