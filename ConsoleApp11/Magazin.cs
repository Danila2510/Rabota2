using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Magazin
    {
        private string imya;
        private int god;
        private string description;
        private string nomer;
        private string email;
        public Magazin() { }
        public Magazin(string Imya, int God, string Description, string Nomer, string Email)
        {
            this.imya = Imya;
            this.god = God;
            this.Description = Description;
            this.nomer = Nomer;
            this.email = Email;
        }
        public string Name { get { return imya; } set { imya = value; } }
        public int Year { get { return god; } set { god = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Number { get { return nomer; } set { nomer = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Print()
        {
            Console.WriteLine($" Imya {imya}\n God {god}\n Description: {description}\n Nomer {nomer}\n Email: {email}");
        }

        public override string ToString()
        {
            return $" Imya {imya}\n God {god}\n Description {description}\n Nomer {nomer}\n Email {email}";
        }
    }
}
