using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAndXML
{
    [Serializable]
    public class XMLClass
    {
        public int Egesz { get; set; }
        public double Tort { get; set; }

        public override string ToString()
        {
            return $"Egesz: {Egesz}, Tort: {Tort}";
        }
    }
}
