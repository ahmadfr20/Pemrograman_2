using System;

namespace Binatang
{
    class Program
    {
        class Binatang
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase ()
            {
                Console.WriteLine ("Nama:" + name);
                Console.WriteLine ("umur:" + age);
                Console.WriteLine ("Kebahagiaan:" + happiness);
            }
        }

        class Kucing : Binatang
        {
            public int jumlahMakan;
            public void Mengeong ()
            {
                Console.WriteLine("Meong");
            }
        }
        class Anjing : Binatang
        {
            public int jumlahSpot;
            public void Menggonggong ()
            {
                Console.WriteLine("WOOF"); 
                base.happiness += 0.1f;              
            }
        }
        static void Main(string[] args)
        {
            Anjing spike = new Anjing ();
            spike.name = "Spike";
            spike.age = 5;
            spike.happiness = 0.8f;
            spike.jumlahSpot = 20;
            spike.PrintBase ();
            spike.Menggonggong ();
            Console.WriteLine ("New Happines: " + spike.happiness);
            

            Kucing tom = new Kucing ();
            tom.name = "tom";
            tom.age = 4;
            tom.happiness = 0.3f;
            tom.jumlahMakan = 20;
            tom.happiness = 0.5f;
            tom.PrintBase ();
            tom.Mengeong ();
            

            Console.ReadKey ();
        }
    }
}
