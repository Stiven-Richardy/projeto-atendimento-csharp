using projeto_atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_atendimento
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        public Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public Senhas()
        {
            proximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            FilaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento += 1;
        }
    }
}