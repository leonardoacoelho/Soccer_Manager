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
    public partial class CadastroFormacoesForm : BaseForm
    {
        FormacaoTatica _formacao;

        ListaFormacoesForm _lista;

        public CadastroFormacoesForm(ListaFormacoesForm lista) : base(lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        public CadastroFormacoesForm(ListaFormacoesForm lista, FormacaoTatica formacao) : this(lista)
        {
            _formacao = formacao;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CadastroFormacoesForm_Load(object sender, EventArgs e)
        {
            if (_formacao != null)
            {
                txtId.Text = _formacao.Id.ToString();
                txtDefesa.Text = _formacao.LinhaDefensiva.ToString();
                txtCentral.Text = _formacao.LinhaCentral.ToString();
                txtAtaque.Text = _formacao.LinhaOfensiva.ToString();
                txtFormacao.Text = _formacao.ToString();

                menuRemover.Visible = true;
            }
            else
                menuRemover.Visible = false;
        }

        private void menuSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new FormacaoTaticaBO())
                {
                    PreencherFormacao();

                    bo.Save(_formacao);

                    MessageBox.Show("Formação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (string.IsNullOrEmpty(txtId.Text))
                        LimparCampos();
                    else
                        Hide();

                    _lista.AtualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencherFormacao()
        {
            _formacao = new FormacaoTatica
            {
                Id = txtId.Text.ToInt(),
                LinhaDefensiva = txtDefesa.Text.ToInt(),
                LinhaCentral = txtCentral.Text.ToInt(),
                LinhaOfensiva = txtAtaque.Text.ToInt()
            };
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtDefesa.Text = "";
            txtCentral.Text = "";
            txtAtaque.Text = "";
            txtFormacao.Text = "";
            txtDefesa.Focus();
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new FormacaoTaticaBO())
                {
                    var id = txtId.Text.ToInt();

                    if (id > 0)
                    {
                        var result = MessageBox.Show($"Tem certeza que deseja excluir a formação {txtFormacao.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                            bo.Remove(id);
                    }
                    Hide();
                    _lista.AtualizarGrid();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PreencherFormacao_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherFormacao();

            txtFormacao.Text = _formacao.ToString();
        }
    }
}
