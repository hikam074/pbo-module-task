using System;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            POLYMORPHISM
            
            :banyak bentuk

            ketika ada method yang namanya sama namun memiliki perilaku yang berbeda
            biasa digunakan pada inheritance

            polymorphism compile-time
            :mengecek ketika masih ditulis (belum di run)
            ex:overloading -> method sama, parameter beda (bisa beda jml parameterny, bis beda jenis parameternya)
            */

            Hewan hew1 = new Hewan();

            // method tanpa parameter
            hew1.Bersuara();
            // method dengan parameter
            hew1.Bersuara("Guguk");
            // method dengan parameter ganda (str int)
            hew1.Bersuara("Citcit", 10);
            // method dengan parameter ganda (str double)
            hew1.Bersuara("Mbeeek", 3.2);

            /*
            polymorphism runtime
            :mengecek ketika di run
            ex:overriding (ditimpa) ->  nama method sama, parameter sama, baik parent sm child
            di parent ada virtual, di child ada override
            mengapa masuknya runtime? akan baru tahu polynya ketika di run
            yg bs ditimpa itu yg virtual dan abstrak
             */
            
            // disinilah bedanya antara membuat objek biasa dengan polymorphism
            // dibawah ini meskipun yg dibuat adalah new Kucing tapi yang dideklar awal itu Hewan
            // sehingga Kucing ini nanti tidak bisa mengakses method/atribut dari Kucing itu sendiri, kecuali menggunakan override dan parentnya sudah di virtual
            Hewan hew2 = new Kucing();
            Hewan hew3 = new Anjing();

            hew1.Minum("ciu");
            hew2.Minum("tuak");
            hew3.Minum("teqila");

            Console.WriteLine();
        }
    }
    public class Hewan
    {
        public void Bersuara()
        {
            Console.WriteLine("Hewan bersuara");
        }
        public void Bersuara(string suara)
        {
            Console.WriteLine($"Hewan bersuara {suara}");
        }
        public void Bersuara(string nama, int lama)
        {
            Console.WriteLine($"Hewan bersuara {nama} selama {lama} sekon");
        }
        public void Bersuara(string nama, double lama)
        {
            Console.WriteLine($"Hewan bersuara {nama} selama {lama} detik");
        }
        public virtual void Minum(string minuman)
        {
            Console.WriteLine($"Glek-glek, {minuman}");
        }
    }
    public class Kucing : Hewan
    {
        public override void Minum(string minuman)
        {
            Console.WriteLine($"Si kucing sedang minum {minuman}");
        }
    }
    public class Anjing : Hewan
    {
        public override void Minum(string minuman)
        {
            Console.WriteLine($"Si Anjing sedang minum {minuman} glek gle");
        }
    }
}