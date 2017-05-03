using SoccerManager.BLL;
using SoccerManager.Enumerators;
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
    public partial class CadastroPosicoesForm : BaseForm
    {
        ListaPosicoesForm _lista;

        Posicao _posicao;

        public CadastroPosicoesForm(ListaPosicoesForm lista) : base(lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        public CadastroPosicoesForm(ListaPosicoesForm lista, Posicao posicao) : this(lista)
        {
            _posicao = posicao;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CadastroPosicoesForm_Load(object sender, EventArgs e)
        {
            var linhas = Linhas();
            cbxLinha.DataSource = linhas;

            if (_posicao != null)
            {
                idTextBox.Text = _posicao.Id.ToString();
                descricaoTextBox.Text = _posicao.Descricao;
                cbxLinha.SelectedIndex = (int)_posicao.Linha;

                menuRemover.Visible = true;
            }
            else
                menuRemover.Visible = false;
        }

        private List<string> Linhas()
        {
            return Enum.GetNames(typeof(TipoLinha)).ToList();
        }

        private void menuSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _posicao = new Posicao
                {
                    Id = idTextBox.Text.ToInt(),
                    Descricao = descricaoTextBox.Text,
                    Linha = (TipoLinha)cbxLinha.SelectedIndex
                };

                using (var bo = new PosicaoBO())
                {
                    bo.Save(_posicao);
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
    }
}
