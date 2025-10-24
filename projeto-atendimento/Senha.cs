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
            DataAtend = null;
        }

        public string dadosParciais()
        {
            return $"{Id} - {DataGerac.ToString("dd/MM/yyyy")} - {DataGerac.ToString("HH:mm:ss")}";
        }

        public string dadosCompletos()
        {
            return $"{Id} - {DataGerac.ToString("dd/MM/yyyy")} - {DataGerac.ToString("HH:mm:ss")} - {DataAtend.Value.ToString("dd/MM/yyyy")} - {DataAtend.Value.ToString("HH:mm:ss")}";
        }
    }
}
