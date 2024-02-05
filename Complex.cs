using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solodkaya_lab2
{
    internal class Complex:IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public IPair Add(IPair p)
        {
            return new Complex() { A = this.A + p.A, B = this.B + p.B };
        }

        public IPair Div(IPair p)
        {
            return new Complex() { A = (this.A * p.A + this.B * p.B) / (p.A * p.A + p.B * p.B), B = (this.B * p.A - this.A * p.B) / (p.A * p.A + p.B * p.B) };
        }

        public IPair Mul(IPair p)
        {
            return new Complex() { A = this.A * p.A - this.B * p.B, B = this.A * p.B + this.B * p.A };
        }

        public IPair Sub(IPair p)
        {
            return new Complex() { A = this.A - p.A, B = this.B - p.B };
        }
        public bool Equ(IPair p)
        {
            return this.A == p.A && this.B == p.B;
        }
        public IPair Conj(IPair p)
        {
            return new Complex() { A = this.A, B = -this.B };
        }
        public override string? ToString()
        {
            if (B > 0)
                return $"{A}+{B}i";
            else if (B < 0)
                return $"{A}-{B}i";
            else return $"{A}";

        }
    }
}
