using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cecchini.Andrea.Banca
{
    public class Versamento : Movimento
    {
        public Versamento(double importo,string id,DateTime DataMovimento) : base(importo, id, DataMovimento)
        {
          
        }
            
    }
}