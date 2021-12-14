using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
     public class Bar
    {
        public int BarID { get; set; }
        public int cnpj { get; set; }

        public  string nome{ get; set; }
        public  string CEP{ get; set; }

        public string  restricao { get; set; }

        public DateTime horario { get; set; }

        public int capacidade { get; set; }

        public string localizacao { get; set; }

        public string numero { get; set; }
    }
}
