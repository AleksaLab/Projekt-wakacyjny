using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prjkt
{
    internal class G
    {
        Random gen = new Random();
        Tekst wym = new Tekst();
        
        int rounds = 0;
        int[] ptkUP = { 0, 0 };

        
        public void Pkn()
        {
            Game play = new Game();
            G pod = new G();
            Thread.Sleep(1000);
            wym.Text();
            Thread.Sleep(1000);

            while (rounds < 3)
            {
                Thread.Sleep(1000);
                Console.WriteLine(new string('-', 100));
                Thread.Sleep(1000);
                Console.WriteLine("Co wybierasz?");
                Thread.Sleep(1000);
                Console.WriteLine("papier - 1, kamień - 2, nożyce - 3");
                int odp = int.Parse(Console.ReadLine());
                // papier - 1, kamień - 2, nożyce - 3
                int wybP = gen.Next(1, 4);

                
                if (odp == 1 && wybP == 1)
                {
                    Console.WriteLine("-REMIS-");

                }
                if (odp == 1 && wybP == 2)
                {
                    Console.WriteLine("-Punkt dla Ciebie-");
                    ptkUP[0]++;
                }
                if (odp == 1 && wybP == 3)
                {
                    Console.WriteLine("-Punkt dla piwniczaka-");
                    
                    ptkUP[1]++;
                }



                if (odp == 2 && wybP == 2)
                {
                    Console.WriteLine("-REMIS-");
                }
                if (odp == 2 && wybP == 3)
                {
                    Console.WriteLine("-Punkt dla Ciebie-");
                    ptkUP[0]++;
                }
                if (odp == 2 && wybP == 1)
                {
                    Console.WriteLine("-Punkt dla piwniczaka-");
                    
                    ptkUP[1]++;
                }



                if (odp == 3 && wybP == 3)
                {
                    Console.WriteLine("-REMIS-");
                }
                if (odp == 3 && wybP == 1)
                {
                    Console.WriteLine("-Punkt dla Ciebie-");
                    ptkUP[0]++;
                }
                if (odp == 3 && wybP == 2)
                {
                    Console.WriteLine("-Punkt dla piwniczaka-");
                    
                    ptkUP[1] ++;
                }
                Console.WriteLine($"{ptkUP[0]} : {ptkUP[1]}");
                rounds ++;
                wym.Text();
            }
            
            if (ptkUP[0] == ptkUP[1])
            {
                
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(new string('-', 100));
                    Thread.Sleep(1000);
                    Console.WriteLine("Musisz stoczyć walkę z piwniczakiem jeszcze raz!");
                    Thread.Sleep(1000);
                    pod.Pkn();
                    if (ptkUP[0] > ptkUP[1] || ptkUP[0] < ptkUP[1])
                    {
                        break;
                    }
                }
            }
            if (ptkUP[0] > ptkUP[1])
            {
                Thread.Sleep(1000);
                Console.WriteLine(new string('-', 100));
                Thread.Sleep(1000);
                Console.WriteLine("Wygrałeś z piwniczakiem!");
                Thread.Sleep(1000);
                Console.WriteLine("Możesz kontynuować zarządzanie państwem!");
                Thread.Sleep(1000);
                Console.WriteLine(new string('-', 100));
                Thread.Sleep(1000);
                play.Play();
            }
            if (ptkUP[0] < ptkUP[1])
            {
                Thread.Sleep(1000);
                Console.WriteLine(new string('-', 100));
                Thread.Sleep(1000);
                Console.WriteLine("Przegrałeś z piwniczakiem!");
                Thread.Sleep(1000);
                Console.WriteLine("Kraj dostał się do rąk egoistycznych habsburgów!");
            }
            
        }
        
    }
}
