using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.persistencia;

namespace WpfApp1.model
{
    class ideiainovacao
    {
        public string Area { get; set; } = "";
        public string Ideia { get; set; } = "";

        public float Custo { get; set; } = 0;

        public Boolean cadastrarideiainovacao(ideiainovacao i)
        {
            BD.SalvarBD(i);
            return true;
        }
           
    }
}
