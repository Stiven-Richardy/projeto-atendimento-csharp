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
        Senhas senhas = new Senhas();
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
    }
}
