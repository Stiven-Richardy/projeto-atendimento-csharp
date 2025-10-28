using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_atendimento
{
    public partial class Form1 : Form
    {
        int id = 1;
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }
        void atualizaLista()
        {
            lbGeracao.Items.Clear();
            if (senhas.FilaSenhas.Count == 0)
            {
                lbGeracao.Items.Add("Nenhuma senha aguarda atendimento.");
            }
            else
            {
                foreach (Senha s in senhas.FilaSenhas)
                {
                    lbGeracao.Items.Add(s.dadosParciais());
                }
            }
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            MessageBox.Show($"Senha gerada com sucesso. Id: {senhas.ProximoAtendimento - 1}",
                "Senhas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Guiche adicionarGuiche = new Guiche(id);
            guiches.adicionar(adicionarGuiche);
            lblQtdeGuiche.Text = guiches.ListaGuiches.Count().ToString();
            MessageBox.Show($"Guichê adicionado com sucesso. Id: {id}",
                "Guichês",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            id++;
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int guicheId;
            if (!int.TryParse(nudGuiche.Text, out guicheId))
            {
                MessageBox.Show("Número do guichê inválido.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } 
            else
            {
                Guiche guicheSelecionado = guiches.ListaGuiches.FirstOrDefault(g => g.Id == guicheId);
                if (guicheSelecionado == null)
                {
                    MessageBox.Show($"Guichê {guicheId} não existe.",
                        "Guichês",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (senhas.FilaSenhas.Count() > 0)
                    {
                        Senha proximaSenha = senhas.FilaSenhas.Peek();
                        guicheSelecionado.chamar(senhas.FilaSenhas);
                        MessageBox.Show($"Senha {proximaSenha.Id} chamada no Guichê {guicheSelecionado.Id}.",
                            "Senhas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        atualizaLista();
                    }
                    else
                    {
                        MessageBox.Show($"Não há senhas na fila para chamar.",
                            "Senhas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            lbAtendimentos.Items.Clear();
            int guicheId;
            if (!int.TryParse(nudGuiche.Text, out guicheId))
            {
                MessageBox.Show("Número do guichê inválido.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Guiche guicheSelecionado = guiches.ListaGuiches.FirstOrDefault(g => g.Id == guicheId);
                if (guicheSelecionado == null)
                {
                    MessageBox.Show($"Guichê {guicheId} não existe.",
                        "Guichês",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (guicheSelecionado.Atendimentos.Count() == 0)
                    {
                        lbAtendimentos.Items.Add("Nenhum atendimento realizado para este guichê.");
                    } 
                    else
                    {
                        foreach (Senha s in guicheSelecionado.Atendimentos)
                        {
                            lbAtendimentos.Items.Add(s.dadosCompletos());
                        }
                    }
                }
            }
        }
    }
}
