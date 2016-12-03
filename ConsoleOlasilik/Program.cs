using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOlasilik
{
    class Program
    {

        static void Main(string[] args)
        {
            int elemanSay;
            int classRange = 5;
            
            Console.Write("Seri kaç elamanlı olacak : ");
            elemanSay = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınıf aralıgı kaç olacak : ");
            classRange = Convert.ToInt16(Console.ReadLine());
            //int[] dizi = new int[elemanSay];
            for (int i = 0; i < elemanSay; i++)
            {
                //Console.Write("{0} . Elamanı Giriniz : ",(i+1));
                //dizi[i] = Convert.ToInt16(Console.ReadLine());
            }
            //int[] dizi = {4,5,3,4,5,4,5,6,6,6,7,7,8,9,9,8,10,10,11 };
            int[] dizi = { 18, 12, 1, 5, 5, 10, 24, 12, 14, 27, 10, 3, 23, 6, 18, 13, 14, 21, 16, 14, 12, 24, 14, 19, 13, 7, 23, 14, 17, 14, 22, 9, 11, 19, 22, 8, 19, 11, 12, 23, 18, 16, 20, 24, 15, 29, 20, 21, 15, 20 };
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " \t");
            }
            Console.WriteLine("\n----------------------------------------------------------------------------");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(dizi[i] + " \t");
                }
                else if (dizi[i] != dizi[i - 1])
                {
                    Console.Write(dizi[i] + " \t");
                }
            }
            Console.WriteLine("\n----------------------------------------------------------------------------");
            int say = 1;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] != dizi[i + 1])
                {
                    Console.Write(say + " \t");
                    say = 1;
                }
                else
                {
                    say++;
                }
                if (i == dizi.Length - 2)
                {
                    Console.Write(say + " \t");
                }
            }
            /* ----------------------------------------------------------------------------------------------- */
            int c = 0;
            float m = 0;
            int d = c + classRange;
            say = 0;
            int f = 0;
            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > c && dizi[i] <= d)
                {
                    //
                }
                else
                {
                    f += say;
                    sayac++;
                    c = d;
                    d += classRange;
                    say = 1;
                }
                if (i == (dizi.Length - 1))
                {
                    sayac++;
                }
            }
            Console.WriteLine("\n----------------------------------------------------------------------------");
            float[,] degerler = new float[sayac, 5];
            sayac = 0;
            c = 0;
            m = 0;
            d = c + classRange;
            say = 0;
            f = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > c && dizi[i] <= d)
                {
                    say++;
                }
                else
                {
                    f += say;
                    m = (float)(c + d) / 2;
                    degerler[sayac, 0] = (float)say;
                    degerler[sayac, 1] = (float)f;
                    degerler[sayac, 2] = (float)m;
                    degerler[sayac, 3] = c;
                    degerler[sayac, 4] = d;
                    sayac++;
                    c = d;
                    d += classRange;
                    say = 1;
                }
                if (i == (dizi.Length - 1))
                {
                    f += say;
                    m = (float)(c + d) / 2;
                    degerler[sayac, 0] = (float)say;
                    degerler[sayac, 1] = (float)f;
                    degerler[sayac, 2] = (float)m;
                    degerler[sayac, 3] = c;
                    degerler[sayac, 4] = d;
                }
            }
            for (int i = 0; i < degerler.GetLength(0); i++)
            {
                Console.Write(degerler[i, 3] + " - " + degerler[i, 4] + "\tF: " + degerler[i, 0] + "\tArt. F : " + degerler[i, 1] + " \tMi :  " + degerler[i, 2] + "\tOrs. F : " + (degerler[i, 0] / degerler[degerler.GetLength(0)-1,1] ) + "\n");
            }
            Console.WriteLine("\n----------------------------------------------------------------------------");
            float enBuyukF = degerler[0, 0];
            float l = 0;
            float d1 = 0;
            float d2 = 0;
            float mod = 0;
            float medyan, n = 0;
            float medyanFrekansTop = 0;
            float ortalama, toplam = 0;
            float sigma = 0;
            float degisimKat = 0,m3 = 0,m4 = 0,alpha3 = 0,alpha4 = 0;
            for (int i = 0; i < degerler.GetLength(0); i++)
            {
                if (degerler[i, 0] > enBuyukF)
                {
                    enBuyukF = degerler[i, 0];
                    medyanFrekansTop += degerler[i - 1, 0];
                    d1 = enBuyukF - degerler[i - 1, 0];
                    d2 = enBuyukF - degerler[i + 1, 0];
                    l = degerler[i, 3];
                }
                else if (i == degerler.GetLength(0) - 1)
                {
                    n = degerler[i, 1] / 2;
                }
            }
            for (int i = 0; i < degerler.GetLength(0); i++)
            {
                toplam += (degerler[i, 2] * degerler[i, 0]);
            }
            ortalama = toplam / degerler[degerler.GetLength(0) - 1, 1];
            ortalama = (float)Math.Ceiling(ortalama);
            mod = l + (d1 / (d1 + d2)) * classRange;
            medyan = l + ((n - medyanFrekansTop) / enBuyukF) * classRange;
            for (int i = 0; i < degerler.GetLength(0); i++)
            {
                sigma += degerler[i, 0] * ((float)Math.Pow(ortalama - degerler[i, 2], 2));
                m3 += degerler[i, 0] * ((float)Math.Pow((degerler[i, 2] - ortalama), 3));
                m4 += degerler[i, 0] * ((float)Math.Pow((degerler[i, 2] - ortalama), 4));
            }
            sigma /= degerler[degerler.GetLength(0) - 1, 1];
            m3 /= degerler[degerler.GetLength(0) - 1, 1];
            m4 /= degerler[degerler.GetLength(0) - 1, 1];
            sigma = (float)Math.Sqrt(sigma);
            alpha3 = m3 / ((float)Math.Pow(sigma, 3));
            alpha4 = m4 / ((float)Math.Pow(sigma, 4));
            degisimKat = sigma * 100 / ortalama;
            Console.WriteLine("Ortalama : " + ortalama + "\tMedyan : " + medyan + "\tMod : " + mod + "\n" + "Sdandart Sapma : " + sigma + "\tDegişim Katsayısı : " + degisimKat);
            if (alpha3 < 0)
            {
                Console.WriteLine("Seri sola çarpık : "+ alpha3 );
            }
            else if (alpha3 > 0)
            {
                Console.WriteLine("Seri saga çarpık : " + alpha3);
            }
            else
            {
                Console.WriteLine("Seri simetrik : " + alpha3);
            }
            if (alpha4 < 3)
            {
                Console.WriteLine("Seri basık : " + alpha4);
            }
            else if (alpha4 > 3)
            {
                Console.WriteLine("Seri sivri : " + alpha4);
            }
            else if( alpha4 == 3)
            {
                Console.WriteLine("Seri normal : " + alpha4);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------");
            

            List<float> BinList = new List<float>();
            for (int i = 0; i < degerler.GetLength(0); i++)
            {
                BinList.Add(degerler[i, 0]);
            }


            float max = 0;
            for (int i = 0; i < BinList.Count; i++)
            {
                if (BinList[i] > max) max = BinList[i];
            }

            Console.WriteLine('|');
            for (int i = 0; i < BinList.Count; i++)
            {
                Console.Write("|");
                for (int j = 0; j < (int)(BinList[i] / max * 25f); j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine('|');
            Console.WriteLine("\n----------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
