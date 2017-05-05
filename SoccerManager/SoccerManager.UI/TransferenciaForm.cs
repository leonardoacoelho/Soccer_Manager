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
    public partial class TransferenciaForm : BaseForm
    {
        ListaTransferenciaForm _lista;

        Transferencia _transferencia;

        public TransferenciaForm(ListaTransferenciaForm lista) : base(lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        public TransferenciaForm(ListaTransferenciaForm lista, Transferencia transferencia) : this(lista)
        {
            _transferencia = transferencia;
        }

        private void TransferenciaForm_Load(object sender, EventArgs e)
        {
            using (var clubeBo = new ClubeBO())
            {
                var clubes = clubeBo.List();

                var clubeNull = new Clube();
                clubes.Insert(0, clubeNull);

                clubeBindingSource.DataSource = clubes;
            }

            using (var jogadorBo = new JogadorBO())
            {
                jogadorBindingSource.DataSource = jogadorBo.List();
            }

            if (_transferencia != null)
            {
                menuRemover.Visible = true;
            }

            else
            {
                _transferencia = new Transferencia
                {
                    Data = DateTime.Today
                };
                menuRemover.Visible = false;
            }

            transferenciaBindingSource.DataSource = _transferencia;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new TranferenciaBO())
                {
                    bo.Save(_transferencia);
                }

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _lista.AtualizarGrid();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = idTextBox.Text.ToInt();
                var result = MessageBox.Show($"Tem certeza que deseja remover a transferência nº{idTextBox.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var bo = new TranferenciaBO())
                    {
                        bo.Remove(id);
                    }

                    _lista.AtualizarGrid();
                    Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void nomeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nomeComboBox1.SelectedItem != null)
            {
                var jogador = (Jogador)nomeComboBox1.SelectedItem;
                txtClubeAtual.Text = jogador.ClubeAtual?.ToString();
            }
        }
    }
}
