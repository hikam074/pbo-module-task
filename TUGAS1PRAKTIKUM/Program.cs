using System;
using TUGAS1PRAKTIKUM.Classes;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            // ins NO. 7a : membuat object KebunBinatang
            KebunBinatang Prigen = new KebunBinatang();

            // ins NO. 7b : membuat object dari tiap subkelas
            Singa singa1 = new Singa();
            singa1.nama = "Muliono";
            singa1.umur = 52;
            singa1.jumlahKaki = 4;

            Gajah gajah1 = new Gajah();
            gajah1.nama = "Budi";
            gajah1.umur = 60;
            gajah1.jumlahKaki = 3;

            Ular ular1 = new Ular();
            ular1.nama = "Wati";
            ular1.umur = 70;
            ular1.panjangTubuh = 2.8;

            Buaya buaya1 = new Buaya();
            buaya1.nama = "Yono";
            buaya1.umur = 50;
            buaya1.panjangTubuh = 2.1;

            // ins NO. 7c : menambahkan kelas ke list KebunBinantang
            Prigen.TambahHewan(buaya1);
            Prigen.TambahHewan(ular1);
            Prigen.TambahHewan(gajah1);
            Prigen.TambahHewan(singa1);

            // ins NO. 7d : menampilkan daftar hewan pada list
            Prigen.DaftarHewan();

            // ins NO. 7e : memanggil suara tiap hewan yang telah diimplementasikan polymorphism
            singa1.Suara();
            gajah1.Suara();
            ular1.Suara();
            buaya1.Suara();

            // ins No. 7f : memanggil method khusus
            singa1.Mengaum();
            ular1.Merayap();

            // BUFFER
            Console.WriteLine();
            Console.WriteLine();
            // BUFFER

            // ana NO. 1 : suara() gajah dan ular
            gajah1.Suara();
            ular1.Suara();

            Console.WriteLine(gajah1.Suara());
            Console.WriteLine(ular1.Suara());

            // ana NO. 2 : mengaum() singa
            singa1.Mengaum();

            // ana NO. 3 : informasi lengkap
            singa1.InfoHewan();

            Console.WriteLine(singa1.InfoHewan());

            // ana NO. 4 : merayap() ular
            ular1.Merayap();

            // ana NO. 5 : reptil -> buaya
            Reptil reptil = new Buaya();
            reptil.Suara();

            Console.WriteLine(reptil.Suara());
            Console.WriteLine(ular1);
        }
    }
}