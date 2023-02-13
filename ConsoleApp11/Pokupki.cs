using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    public class Pokupki
    {
        private string imya;
        private string yliza;
        private string description;
        private string nomer;
        private string email;
        public Pokupki() { }
        public Pokupki(string Imya, string Yliza, string Description, string Nomer, string email)
        {
            this.imya = Imya;
            this.yliza = Yliza;
            this.description = Description;
            this.nomer = Nomer;
            this.email = email;
        }
        public string Name { get { return imya; } set { imya = value; } }
        public string Street { get { return yliza; } set { yliza = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Number { get { return nomer; } set { nomer = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Print()
        {
            Console.WriteLine($" Imya  {imya}\n  Yliza  {yliza}\n Description {description}\n Nomer {nomer}\n Email  {email}");
        }

        public override string ToString()
        {
            return $" Imya {imya}\n Yliza {yliza}\n Description  {description}\n Nomer  {nomer}\n Email {email}";
        

    }
}