using projeto_atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_atendimento
{
    internal class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        public Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche() 
        {
            Id = 0;
            Atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filasSenhas) 
        {
            return true;
        }
    }
}