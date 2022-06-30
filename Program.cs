using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            //iki tip dönüşüm var 
            //Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm küçük değişkeni büyüğe uyarlarken)
            byte a=5;
            sbyte b=54;
            short c=1;
            int d= a+b+c;
            Console.WriteLine(d);
            string str="deneme";
            char f='a';
            object e=str+f+d;
            Console.WriteLine(e);
            //Explicit Conversion (Bilinçli ya da açık dönüşüm) büyük değişkeni  küçüğe uyarlarken
            int x=4;
            byte y=(byte)x;      
            Console.WriteLine("y"+y);
            float k=10.3f;
            byte w=(byte)k;
            Console.WriteLine("w"+w);
            int t=6;
            string l=t.ToString();
            Console.WriteLine("l= "+l);
            //system convert
            string s1="10", s2="20";
            int sayi1,sayi2;
            int toplam;
            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam=sayi1+sayi2;
            Console.WriteLine("toplam= "+toplam);
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string a="10";
            string b="50.28";
            int rakam;
             double db;
            rakam = Int32.Parse(a);
            Console.WriteLine("rakam " +rakam);   
            db=double.Parse(b);
            Console.WriteLine("double " +db);

        }

    }
}

