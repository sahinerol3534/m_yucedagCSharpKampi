﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("     Lütfen Şifreyi Giriniz   :   ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("     Şifre Doğru");

            //}
            //else 
            //{
            //    Console.WriteLine("     Şifre Yanlış");
            //}


            //int number;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("     Sayıyı Giriniz. : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("     Sayı Doğru.");
            //}
            //else 
            //{
            //    Console.WriteLine("     Sayı Hatalı.");

            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //int exem1, exem2, exem3, average;
            //string result   = " --> Hata!!!";
            //Console.Write("     Birinci Sınav Notunu Giriniz.   : ");
            //exem1 = int.Parse(Console.ReadLine());
            //Console.Write("     İkinci Sınav Notunu Giriniz.    : ");
            //exem2 = int.Parse(Console.ReadLine());
            //Console.Write("     Üçüncü Sınav Notunu Giriniz.    : ");
            //exem3 = int.Parse(Console.ReadLine());

            //average = (exem1 + exem2 + exem3) / 3;
            //Console.Write("     Sınavların Ortalaması    : " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = " ---> Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = " ---> Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " ---> Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = " ---> Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("     Lütfen Şehir Adını Giriniz. : ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("     Şehir Mevcut. ");
            //}
            //else
            //{
            //    Console.WriteLine("     Şehir Mevcut Değil. ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("     Lütfen Kullanıcı Adını Giriniz. : ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("     Geçersiz Kullanıcı Adı.");
            //}
            //else
            //{
            //    Console.WriteLine("     " + username + " Hoş Geldiniz.");
            //}


            #endregion

            #region Mod İşlemleri
           //int number;
           // number = 26;
            //int result = number % 5;
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("     " + result);
            //Console.Write("     Birinci Sayıyı Giriniz  : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("     İkinci Sayıyı Giriniz   : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("     Birinci sayının İkinci sayıya bölümüden kalan   : "+result);

            //Console.Write("     Lütfen Bir sayı Giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("     Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("     Sayı Tekttir. ");
            //}
            #endregion

            #region char Değişkenleri ile Karar yapıları
            //char team;
            //Console.Write("     Lütfen Takım Sembolünü Giriniz. : ");
            //team    = char.Parse(Console.ReadLine());
            //Console.WriteLine();
            //string result = "        Hatalı Giriş";
            //if (team == 'g' | team == 'G')
            //{
            //    result ="     Galatasaray";
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    result ="     Fenerbahçe";
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    result = "     Beşiktaş";
            //}

            //Console.Write("     Tuttuğunuz Takım  : " + result);



            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("     ****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("     ---- MENÜ --------");
            //Console.WriteLine();
            //Console.WriteLine("     1- Ana Yemekler");
            //Console.WriteLine("     2- Çorbalar");
            //Console.WriteLine("     3- Pizzalar");
            //Console.WriteLine("     4- İçecekler");
            //Console.WriteLine("     5- Tatlılar");
            //Console.WriteLine("     ----------------- ");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("     Detayını Görmek İstediğiniz Menü Seçimi : ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     -- Ana Yemekler -----");
            //    Console.WriteLine("     1- Köri Soslu Tavuk");
            //    Console.WriteLine("     2- Kızartma Tabağı");
            //    Console.WriteLine("     3- Fasulye Pilav");
            //    Console.WriteLine("     4- Fırında Somon");
            //    Console.WriteLine("     5- Patlıcan Musakka");
            //    Console.WriteLine("     -------------------- ");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     -- Çorbalar -------");
            //    Console.WriteLine("     1- Mercimek Çorbası");
            //    Console.WriteLine("     2- Ezogelin Çorbası");
            //    Console.WriteLine("     -------------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     -- Pizzalar -------");
            //    Console.WriteLine("     1- Akdeniz Pizza");
            //    Console.WriteLine("     2- Margarita");
            //    Console.WriteLine("     3- Tavuklu Pizza");
            //    Console.WriteLine("     -------------------- ");
            //}
            //if (menuItem == "4") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     -- İçecekler -----");
            //    Console.WriteLine("     1- Kola");
            //    Console.WriteLine("     2- Ayran");
            //    Console.WriteLine("     3- Su");
            //    Console.WriteLine("     -------------------- ");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     -- Tatlılar -----");
            //    Console.WriteLine("     1- Triliçe");
            //    Console.WriteLine("     2- Kazandibi");
            //    Console.WriteLine("     3- Sütlaç");
            //    Console.WriteLine("     -------------------- ");
            //}

            #endregion

            #region Switch Case

            //Console.Write("     Lütfen Ay Girişi Yapınız    : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("     " + monthNumber + ". Ay ---> OCAK"); break;
            //    case 2: Console.Write("     " + monthNumber + ". Ay ---> ŞUBAT"); break;
            //    case 3: Console.Write("     " + monthNumber + ". Ay ---> MART"); break;
            //    case 4: Console.Write("     " + monthNumber + ". Ay ---> NİSAN"); break;
            //    case 5: Console.Write("     " + monthNumber + ". Ay ---> MAYIS"); break;
            //    case 6: Console.Write("     " + monthNumber + ". Ay ---> HAZİRAN");break;
            //    case 7: Console.Write("     " + monthNumber + ". Ay ---> TEMMUZ");break;
            //    case 8: Console.Write("     " + monthNumber + ". Ay ---> AĞUSTOS");break;
            //    case 9: Console.Write("     " + monthNumber + ". Ay ---> EYLÜL"); break;
            //    case 10: Console.Write("     " + monthNumber + ". Ay ---> EKİM"); break;
            //    case 11: Console.Write("     " + monthNumber + ". Ay ---> KASIM");break;
            //    case 12: Console.Write("     " + monthNumber + ". Ay ---> ARALIK");break;
            //    default: Console.Write("     Hatalı Giriş"); break;
            //} 



            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("     1. Sayıyı Giriniz   : ");
            //number1 = int.Parse(Console.ReadLine());    

            //Console.Write("     2. Sayıyı Giriniz   : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("     Lütfen Yapmak İstediğiniz İşlemi Giriniz    : ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("     Toplam  : " +  result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("     Fark  : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("     Çarpım  : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("     Bölüm   : " + result);
            //        break;
            //    default:
            //        Console.WriteLine("        hata!!!");
            //        break;
            //}

            



            #endregion

            Console.ReadLine();


        }
    }
}
