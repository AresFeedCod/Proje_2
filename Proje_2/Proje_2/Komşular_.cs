using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    internal class Komşular_
    {
        public void Ekrana_Yazdırma (Kişiler Komşu_1) /* Ekrana yazabilmemiz için bir Class methot'una değer döndüren köprü Class'ımızı tanımlıyoruz.*/
        {
            Console.WriteLine("{0} numaralı dairede {1} {2} adlı komşu olturmakta. " ,Komşu_1.KapıNo, Komşu_1.KomşuAdı, Komşu_1.Soyİsim);
        }



    }
}
