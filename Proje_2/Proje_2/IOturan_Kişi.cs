using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    internal interface IOturan_Kişi /* İnterface tanımlıyoruz. */
    {
        void Name();
        void LastName();
        void DoorNo();

        Kişiler Geri_Yazdırma(); /* Köprü Class'ını İnterface'imiz içine aktarıp bir kalıtım oluşturmak istiyoruz. */

    }
    class Kişiler /* Class içinde Hem verileri alıp hemde transfer edebilmemiz için bir köprü Class'ı oluşturuyoruz. */
    {
        public int KapıNo { get ; set; }
        public string Soyİsim {  get; set; }
        public string KomşuAdı {  get; set; }

        
    }

    class Oturan_Kişi_Ekleme : IOturan_Kişi /* İnterface'imizin Class içinde verilerimizi kullanmak isteğimiz. */
    {
        Kişiler Kişi = new Kişiler(); /* Köprü Class'ımızı Tanımlayıp alaçağımız verileri aktarım yapmak için kullanıçaz. */
        public void DoorNo()
        {
            Console.Write("Yeni taşınan komşunun kapı numarası nedir?");
             Kişi.KapıNo= Convert.ToInt32(Console.ReadLine());
        }

        public Kişiler Geri_Yazdırma() /* Return komutu ile tüm aldığımız verileri aktarmış oluçaz. */
        {
            return Kişi;
        }

        public void LastName()
        {
            Console.Write("Yeni taşınan komşunun soyadı nedir? ");
            Kişi.Soyİsim = Console.ReadLine();
        }

        public void Name()
        {
            Console.Write("Yeni taşınan komşunun adı  nedir? ");
            Kişi.KomşuAdı = Console.ReadLine();
        }
    }

}
