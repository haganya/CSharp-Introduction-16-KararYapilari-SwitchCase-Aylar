using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_9Con_AyBul
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcının girdiği ay sayılarına bakarak Ocak , Şubat şekilde değer döndüren uygulamayı yazınız.

            Console.Write("Ay giriniz : ");
            string ay = Console.ReadLine();
            switch (ay)
            {
                case "1": Console.Write("Ocak"); break;
                case "2": Console.Write("Şubat"); break;
                case "3": Console.Write("Mart"); break;
                case "4": Console.Write("Nisan"); break;
                case "5": Console.Write("Mayıs"); break;
                case "6": Console.Write("Haziran"); break;
                case "7": Console.Write("Temmuz"); break;
                case "8": Console.Write("Ağustos"); break;
                case "9": Console.Write("Eylül"); break;
                case "10": Console.Write("Ekim"); break;
                case "11": Console.Write("Kasım"); break;
                case "12": Console.Write("Aralık"); break;

                default: Console.Write("öyle bir ay yok."); break;
            }
            Console.Read();
        }
    }
}
