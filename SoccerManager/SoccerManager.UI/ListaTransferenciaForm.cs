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
    public partial class ListaTransferenciaForm : BaseForm
    {
        public ListaTransferenciaForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TransferenciaForm(this);
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ListaTransferenciaForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            dgvTransf.AutoGenerateColumns = false;
            using (var bo = new TranferenciaBO())
            {
                bsTransferencias.DataSource = bo.List();
            }
        }

        private void dgvTransf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var bo = new TranferenciaBO())
                {
                    var id = dgvTransf.Rows[e.RowIndex].Cells["Id"].Value.ToString().ToInt();

                    var transferencia = bo.Get(id);

                    var form = new TransferenciaForm(this, transferencia);
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
