using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solodkaya_lab2
{
    internal interface IPair
    {
        double B { get; }
        double A { get; set; }

        IPair Add(IPair p);
        IPair Sub(IPair p);
        IPair Mul(IPair p);
        IPair Div(IPair p);
    }
}
