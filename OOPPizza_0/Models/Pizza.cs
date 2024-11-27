using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza_0.Models
{
    public class Pizza : BaseEntity
    {
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Fiyat:C2}";
        }
    }
}
