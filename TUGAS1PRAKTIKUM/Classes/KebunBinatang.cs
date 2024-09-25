using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS1PRAKTIKUM.Classes
{
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
