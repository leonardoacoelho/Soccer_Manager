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
    public partial class MenuForm : BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaClubesForm(this);
            form.Show();
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaJogadoresForm(this);
            form.Show();
        }

        private void posiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaPosicoesForm(this);
            form.Show();
        }

        private void formaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaFormacoesForm(this);
            form.Show();
        }

        private void transferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListaTransferenciaForm();
            form.Show();
        }
    }
}
