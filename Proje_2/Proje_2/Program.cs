using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oturan_Kişi_Ekleme oturan_Kişi_Ekleme = new Oturan_Kişi_Ekleme(); /* Kullanıçıdan verilerimizi alabilmemiz için Class'ımızı ana projeye tanımlıyoruz. */
            oturan_Kişi_Ekleme.Name();
            oturan_Kişi_Ekleme.LastName();
            oturan_Kişi_Ekleme.DoorNo();

            

            Kişiler kişi = new Kişiler(); /* Verilerin değerini ekranda gözükmesi ve verileri alabilmemiz için gerekli bir Class tanımı. */
            kişi = oturan_Kişi_Ekleme.Geri_Yazdırma();

            Döngü_Oluşturma Döngü = new Döngü_Oluşturma();
            Döngü.Soru_Sorma(kişi);

            //Komşular_ komşu = new Komşular_(); /* En son ekrana sonuçun gözükmesini sağlıyoruz. */
            //komşu.Ekrana_Yazdırma(kişi);

            Console.ReadLine();
        }
    }
}
