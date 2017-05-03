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
    public partial class ListaFormacoesForm : BaseForm
    {
        public ListaFormacoesForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ListaFormacoesForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            using (var bo = new FormacaoTaticaBO())
            {
                dgvFomacoes.AutoGenerateColumns = false;

                bsFormacoes.DataSource = bo.List();
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CadastroFormacoesForm(this);
            form.Show();
        }

        private void dgvFomacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var bo = new FormacaoTaticaBO())
                {

                    var id = dgvFomacoes.Rows[e.RowIndex].Cells["Id"].Value.ToString().ToInt();

                    var formacao = bo.Get(id);

                    var form = new CadastroFormacoesForm(this, formacao);
                    form.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}