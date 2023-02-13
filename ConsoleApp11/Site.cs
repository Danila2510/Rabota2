using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Site
    {
        private string Imya;
        private string url;
        private string Descriptione;
        private string IP;

        public Site() { }
        public Site(string imya, string url, string description, string ip)
        {
            this.Imya = imya;
            this.url = url;
            this.Descriptione = description;
            this.IP = ip;
        }

        public string Name { get { return Imya; } set { Imya = value; } }
        public string Url { get { return url; } set { url = value; } }
        public string Description { get { return Description; } set { Description = value; } }
        public string Ip { get { return IP; } set { IP = value; } }

        public void Print()
        {
            Console.WriteLine($" Imya {Imya}\n URL {url}\n Description {Description}\n IP {IP}");
        }
        public override string ToString()
        {
            return $" Imya {Imya}\n URL {url}\n Description {Description}\n IP {IP}";
        }

    }
}