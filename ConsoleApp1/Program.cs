using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp11;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Site site = new Site();
            site.Imya = "Гит хаб";
            site.Url = "https://github.com";
            site.Description = "Repositories/Hosting";
            site.Ip = "192.30.252.154";
            Console.WriteLine(site);

            Magazin magazin = new Magazin();
            magazin.Imya = "Журнал";
            magazin.Description = "Война";
            magazin.God = 2010;
            magazin.Nomer = "+380-99-254-34-14";
            magazin.Email = "WAR3@mail.com";
            Console.WriteLine(magazine);

            Pokupki shop = new Pokupki();
            shop.Name = "Таврия";
            shop.Description = "Продуктовый магазин";
            shop.Yliza = "Николаеская дорога";
            shop.Nomer = "+067-254-96-17";
            shop.Email = "TavriyaV@mail.com";
            Console.WriteLine(shop);
        }
    }
}