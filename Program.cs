using System;

namespace ArrayString__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, C, D, E, F, G, H;
            string Aa, Bb, Cc, Dd, Ee, Ff, Gg, Hh, Ii, Jj, Kk, Ll, Mm, Nn, Oo;

            String[] ArrStr = new String[7];

            A = "Rizky Khapidsyah";
            B = "Nama Saya : ";
            C = A.Insert(0, B);
            D = " itu siapa?";
            E = A.Insert(16, D);
            F = "Ini Adalah: ";
            G = "Hari Rabu";
            H = G.Replace("Rabu", "Jum'at");

            ArrStr[0] = "Senin";
            ArrStr[1] = "Selasa";
            ArrStr[2] = "Rabu";
            ArrStr[3] = "Kamis";
            ArrStr[4] = "Jum'at";
            ArrStr[5] = "Sabtu";
            ArrStr[6] = "Minggu";

            /* Saya Sengaja tidak menggunakan variabel array untuk bagian ini (Aa, Bb, Cc dst..), agar kebih mudah dipahami. 
             * Namun lebih disarankan menggunakan array dan statement for jika bekerja di lingkungan komersil
             */

            Aa = ", ";
            Bb = ".";
            Cc = Bb.Insert(0, ArrStr[6]);
            Dd = Cc.Insert(0, Aa);
            Ee = Dd.Insert(0, ArrStr[5]);
            Ff = Ee.Insert(0, Aa);
            Gg = Ff.Insert(0, ArrStr[4]);
            Hh = Gg.Insert(0, Aa);
            Ii = Hh.Insert(0, ArrStr[3]);
            Jj = Ii.Insert(0, Aa);
            Kk = Jj.Insert(0, ArrStr[2]);
            Ll = Kk.Insert(0, Aa);
            Mm = Ll.Insert(0, ArrStr[1]);
            Nn = Mm.Insert(0, Aa);
            Oo = Nn.Insert(0, ArrStr[0]);

            Console.WriteLine(A);
            Console.WriteLine(A.Length);
            Console.WriteLine(A.IndexOf('p'));
            Console.WriteLine(A[9]);
            Console.WriteLine(C);
            Console.WriteLine(E);
            Console.WriteLine(Oo);
            Console.WriteLine(F, G);
            Console.WriteLine(H);

            if (!H.Contains("Kamis")) 
            {
                Console.WriteLine("Tidak Ditemukan Hari: Kamis");
            }
            else
            {
                Console.WriteLine("Ditemukan Hari: Kamis");
            }

            H = H.Remove(2);
            Console.WriteLine(H);

            Console.ReadLine();
        }
    }
}
