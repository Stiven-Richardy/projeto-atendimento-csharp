using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_atendimento
{
    internal class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime? dataAtend;

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime? DataAtend { get => dataAtend; set => dataAtend = value; }

        public Senha(int id) 
        { 
            Id = id;
            DataGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return $"Id: {Id} - Gerado: {DataGerac}";
        }

        public string dadosCompletos()
        {
            return $"Id: {Id} - Gerado: {DataGerac} - Atendido: {DataAtend}";
        }
    }
}
