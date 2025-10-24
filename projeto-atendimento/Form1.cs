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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            MessageBox.Show($"Senha gerada com sucesso. Id: {senhas.FilaSenhas.Count()}",
                "Senhas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lbGeracao.Items.Clear();
            foreach(Senha s in senhas.FilaSenhas)
            {
                lbGeracao.Items.Add(s.dadosParciais());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Guiche adicionarGuiche = new Guiche(id);
            guiches.adicionar(adicionarGuiche);
            lblQtdeGuiche.Text = guiches.ListaGuiches.Count().ToString();
            MessageBox.Show($"Guichê adicionado com sucesso. Id: {guiches.ListaGuiches.Count()}",
                "Guichês",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            id++;
        }
    }
}
