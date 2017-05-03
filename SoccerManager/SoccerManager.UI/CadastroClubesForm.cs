using SoccerManager.BLL;
using SoccerManager.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManager.UI
{
    public partial class CadastroClubesForm : BaseForm
    {
        Clube _clube;

        ListaClubesForm _lista;

        public CadastroClubesForm(ListaClubesForm lista) : base(lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        public CadastroClubesForm(ListaClubesForm lista, Clube clube) : this(lista)
        {
            _clube = clube;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                pcbEscudo.Image = new Bitmap(ofdImagem.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var imagem = new Imagem
                {
                    Id = txtImagemId.Text.ToInt(),
                    bytes = ImagemBO.ImageToBytes(pcbEscudo.Image)
                };

                _clube = new Clube
                {
                    Id = txtId.Text.ToInt(),
                    Nome = txtNome.Text,
                    Sigla = txtSigla.Text,
                    FormacaoTatica_Id = ((FormacaoTatica)cbxFormacoes.SelectedItem).Id,
                    Escudo_Id = txtImagemId.Text.ToInt()
                };

                using (var bo = new ClubeBO())
                {
                    bo.Save(_clube, imagem);
                }

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pcbEscudo.Image = null;
                AtualizarGrid();
                _lista.AtualizarGrid();

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CadastroClubesForm_Load(object sender, EventArgs e)
        {
            using (var bo = new FormacaoTaticaBO())
            {
                cbxFormacoes.DataSource = bo.List();
                var formacao = bo.List();

                if (_clube != null)
                {
                    txtId.Text = _clube.Id.ToString();
                    txtNome.Text = _clube.Nome;
                    txtSigla.Text = _clube.Sigla;
                    cbxFormacoes.SelectedIndex = formacao.IndexOf(formacao.FirstOrDefault(x => x.Id == _clube.FormacaoTatica_Id));
                    txtImagemId.Text = _clube.Escudo_Id.ToString();

                    pcbEscudo.Image = ImagemBO.ByteToImage(_clube.Escudo?.bytes);

                    menuRemover.Visible = true;
                }
                else
                    menuRemover.Visible = false;
            }

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            using (var bo = new JogadorBO())
            {
                bsJogadores.DataSource = bo.List();
            }
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            using (var bo = new ClubeBO())
            {
                var id = txtId.Text.ToInt();

                if (id > 0)
                {
                    var result = MessageBox.Show($"Tem certeza que deseja remover {txtNome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        pcbEscudo.Image = null;
                        bo.Remove(id);
                    }
                    Hide();
                    _lista.AtualizarGrid();
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            pcbEscudo.Image = null;
        }
    }
}