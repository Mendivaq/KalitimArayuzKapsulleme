using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzmirasgetset
{
    class Program
    {
        static void Main(string[] args)
        {
            ekranPozisyonu ekrP = new ekranPozisyonu();
            ekrP.X = 1000;
            ekrP.Y = 800;
            System.Console.WriteLine("X Ekseni Üzerindeki Ekran Pozisyonu:{0}",ekrP.X);
            System.Console.WriteLine("Y Ekseni Üzerindeki Ekran Pozisyonu:{0}", ekrP.Y);
            System.Console.ReadKey();




        }
    }

    public interface IEkranPozisyonu
    {
         int X { get; set; }
         int Y{ get; set; }

    }
    struct ekranPozisyonu : IEkranPozisyonu
    {
        private int x;
        private int y;

        public int X
        {
            set { this.x = value; }
            get { return this.x; }
        }
        public int Y
        {
            set { this.y = value; }
            get { return this.y; }
        }
    }


}
