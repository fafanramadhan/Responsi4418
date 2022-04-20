using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4418
{
    class Karyawan
    {
        //property karyawan

        public string Nik { get; set; }
        public string Name { get; set; }
        public float Gajibulanan { get;  set;}
        
        //constructor
        public Karyawan(string nik, string name, float gajibulanan)
        {
            Nik = nik;
            Name = name;
            Gajibulanan = gajibulanan;
        }

        //Tambah gaji 10%
        public void NaikGaji()
        {
            Gajibulanan = Gajibulanan + (Gajibulanan * 0.10f);
        }
    }
}
