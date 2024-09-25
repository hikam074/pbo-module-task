using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TUGAS1PRAKTIKUM.Classes
{
    // ins NO. 2a : membuat class Hewan
    public class Hewan
    {
        public string nama;
        public int umur;

        // ins method NO. 3a : suara Hewan
        public virtual string Suara()
        {
            return "Hewan ini bersuara";
        }
        // ins method NO. 3b : menampilkan informasi hewan
        public virtual string InfoHewan()
        {
            return $"INFO | Nama : {this.nama}, umur : {this.umur}";
        }
    }

    // ins NO. 2b  : membuat derived class Mamalia dari Hewan
    public class Mamalia : Hewan
    {
        public int jumlahKaki;

        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return $"mamalia ini bersuara dengan keras!";
        }
        public override string InfoHewan()
        {
            return $"INFO | Nama : {this.nama}, umur : {this.umur}, jumlah kaki : {this.jumlahKaki}";
        }
    }

    // ins NO. 2c : membuat derived class Reptil dari Hewan
    public class Reptil : Hewan
    {
        public double panjangTubuh;

        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return $"reptil ini bersuara dengan keras!";
        }
    }

    // ins NO. 2d : membuat derived class Singa dari Mamalia
    public class Singa : Mamalia
    {
        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return "Singa ini bersuara 'Aummm!'";
        }
        // ins method NO. 5.1 : method khusus Singa
        public void Mengaum()
        {
            Console.WriteLine("RAWRR!! AUUMMM!");
        }
    }

    // ins NO. 2d : membuat derived class Gajah dari Mamalia
    public class Gajah : Mamalia
    {
        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return "Gajah ini bersuara  'treet'";
        }
    }

    // ins NO. 2e : membuat derived class Ular dari Reptil
    public class Ular : Reptil
    {
        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return "Ular ini bersuara 'Sssss'";
        }
        // ins method NO. 5b : method khusus Ular
        public void Merayap()
        {
            Console.WriteLine("Ular ini merayap di tanah...");
        }
    }

    // ins NO. 2e : membuat derived class Buaya dari Reptil
    public class Buaya : Reptil
    {
        // ins method NO. 4 : override suara Hewan
        public override string Suara()
        {
            return "Buaya ini bersuara 'grrrr'";
        }
    }
    // ins NO. 2f : membuat class KebunBinatang
    public class KebunBinatang
    {
        public List<Hewan> koleksiHewan = new List<Hewan>();
        // ins method NO. 6a : menambahkan Hewan ke list
        public void TambahHewan(Hewan hewan)
        {
            this.koleksiHewan.Add(hewan);
        }
        // ins method NO. 6b : menampilkan seluruh hewan yang ada di list
        public void DaftarHewan()
        {
            foreach (Hewan animal in this.koleksiHewan)
            {
                Console.WriteLine(animal.InfoHewan());
            }
        }
    }
}
