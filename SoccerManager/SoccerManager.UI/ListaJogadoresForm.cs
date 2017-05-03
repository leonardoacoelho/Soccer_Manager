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
    public partial class ListaJogadoresForm : BaseForm
    {
        public ListaJogadoresForm(MenuForm menu) : base(menu)
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ListaJogadoresForm_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            using (var bo = new JogadorBO())
            {
                dgvJogadores.AutoGenerateColumns = false;

                bsJogadores.DataSource = bo.List();
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CadastroJogadoresForm(this);
            form.Show();
        }
    }
}
