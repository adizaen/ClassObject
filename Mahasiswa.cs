using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Mahasiswa
    {
        // properties
        public string nim { get; set; }
        public string nama { get; set; }
        public float ipk { get; set; }

        // method
        public void registrasi()
        {
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Nim  : {0}", nim);
            Console.WriteLine("IPK  : {0}", ipk);
            Console.WriteLine("Telah melakukan registrasi");
        }

        public void isikrs()
        {
            Console.WriteLine("{0} sedang melakukan proses KRS\n", nama);
        }

    }
}
