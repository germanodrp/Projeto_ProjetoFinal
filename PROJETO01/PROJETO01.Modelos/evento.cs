using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class evento
    {
        public int EventoID { get; set; }
        public string nome { get; set; }

        public decimal taxa { get; set; }

        public DateTime horario { get; set; }
    }
}
