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
    public partial class ListaClubesForm : BaseForm
    {

        public ListaClubesForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ListaClubesForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            using (var bo = new ClubeBO())
            {
                dgvClubes.AutoGenerateColumns = false;

                bsClubes.DataSource = bo.List();
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            var form = new CadastroClubesForm(this);
            form.Show();
        }

        private void dgvClubes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var bo = new ClubeBO())
            {
                try
                {
                    var id = dgvClubes.Rows[e.RowIndex].Cells["Id"].Value.ToString().ToInt();

                    var clube = bo.Get(id);

                    var form = new CadastroClubesForm(this, clube);
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }
    }
}
