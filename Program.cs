using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Class & Object";
            // membuat objek dari class mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.nim = "18.11.2269";
            saya.nama = "Adi Zaenul Mustaqim";
            saya.ipk = 3.95f;

            kamu.nim = "18.22.2290";
            kamu.nama = "Kaesang";
            kamu.ipk = 3.70f;

            // memanggil method registrasi dan isi krs
            saya.registrasi();
            saya.isikrs();

            kamu.registrasi();
            kamu.isikrs();

            Console.ReadKey();
        }
    }
}
