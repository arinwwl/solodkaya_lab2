using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solodkaya_lab2
{
    internal class Rational:IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public IPair Add(IPair p)
        {
            return new Rational() { A = this.A * p.B + this.B * p.A, B = this.B * p.B };
        }

        public IPair Div(IPair p)
        {
            return new Rational() { A = this.A * p.B, B = this.B * p.A };
        }

        public IPair Mul(IPair p)
        {
            return new Rational() { A = this.A * p.B, B = this.B * p.A };
        }

        public IPair Sub(IPair p)
        {
            return new Rational() { A = this.A * p.B - this.B * p.A, B = this.B * p.B };
        }

        public bool Equ(IPair p)
        {
            return this.A == p.A && this.B == p.B;
        }
        public bool Greate(IPair p)
        {
            return Math.Sqrt(this.A * this.A + this.B * this.B) > Math.Sqrt(p.A * p.A + p.B * p.B);
        }
        public bool Less(IPair p)
        {
            return Math.Sqrt(this.A * this.A + this.B * this.B) < Math.Sqrt(p.A * p.A + p.B * p.B);
        }

        public override string? ToString()
        {
            return $"{A},{B}";
        }
    }
}
