using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hayvanlar={"aslan","kaplan","gergedan","goril"};
            string[] renkler=new string[3];
            renkler[0]="kirmizi";
            renkler[1]="yesil";
            renkler[2]="mavi";
            foreach (string s in hayvanlar)
            {
                Console.WriteLine(s);                
            }
            foreach (string z in  renkler)
            {
                Console.WriteLine(z);
            }
            
            Console.Write("sayi dizisinin uzunlugunu giriniz: ");
            int dizilen=int.Parse(Console.ReadLine());
            int toplam=0;
            int[] sayilar = new int[dizilen];

            Console.Write("sayi dizisinin elemanlarını giriniz: ");
            
            for (int i = 0; i < dizilen; i++)
            {
                Console.Write("sayi dizisinin {0}. elemanını giriniz: ",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("girilen sayilar şu şekildedir");


            foreach (int k in sayilar)
            {
                Console.WriteLine(k);
                toplam+=k;
            }
            Console.WriteLine("girilen sayilarin ortalamasi {0}",(toplam/dizilen));
            

        }
    }
}
