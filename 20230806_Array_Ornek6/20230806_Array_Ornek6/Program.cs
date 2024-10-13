using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array_Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ornek 6
            //Kullanıcıya kaç adet öğrenci gireceğini soralım
            //Bu öğrencilerin ismini ,öğrenci numarasını , telefon bilgilerini kayıt edelim
            //Kayıt işlemi bittikten sonra  kullanıcıya öğrenci numarası ile listede o numarada mevcut kişinin olup olmadığını gösterelim
            int adet;
            Console.WriteLine("Kaç adet öğrenci girişi yapılacak :");
            adet = int.Parse(Console.ReadLine());

            string[] ogrenciNo = new string[adet];
            string[] isim = new string[adet];
            string[] telefonNo = new string[adet];

            for (int i = 0; i < isim.Length; i++)
            {
                Console.Clear();
                Console.Write("Öğrencinin Numarasını Giriniz :");
                ogrenciNo[i] = Console.ReadLine();
                Console.Write("Öğrencinin İsmini Giriniz : ");
                isim[i] = Console.ReadLine();
                Console.Write("Öğrencinin Telefon Numarasını Giriniz :");
                telefonNo[i] = Console.ReadLine();
            }
            int indexNo;
            do
            {
                Console.Clear();
                Console.Write("Aramak İstediğiniz Öğrencinin Okul No Girin :");
                string arananNo = Console.ReadLine();
                indexNo = Array.IndexOf(ogrenciNo, arananNo);
                if (indexNo == -1)
                {
                    Console.WriteLine("Bu numarada kayıtlı öğrenci bulunamadı");
                }
                else
                {
                    Console.WriteLine("Aranan Kişi : " + ogrenciNo[indexNo] + " " + isim[indexNo] + " " + telefonNo[indexNo]);
                }
            } while (indexNo == -1);

            Console.ReadKey();
        }
    }
}
