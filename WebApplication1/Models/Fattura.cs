using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Fattura
    {
        public DateTime Datafattura { get; set; }
        public string Nomecliente { get; set; }
        public decimal Importo { get; set; }

        public Fattura() { }
        public Fattura(DateTime datafattura, string nomecliente, decimal importo) {
        
            Datafattura = datafattura;
            Nomecliente = nomecliente;
            Importo = importo;
        }
    }
}