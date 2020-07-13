using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_votaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de votaciones\n");
            
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0;
            int alt;

            string[] candidatos = { "Mario Peguero", "Julio Andujar",
            "Carlos Guillermo", "Leopoldo Navarro" };
            string[] partidos = { " Partido Fuerza Contraria(PFC)",
            "Partido Internacional Popular Americano(PIPA)", 
            "Partido de Asistencia Publica Avanzada(PAPA) ",
            "Partido Socialista Cristiano Moderno(PSCM) "};
            int[] fechas = { 1960, 1980, 2001, 2010 };

            Console.WriteLine("................................................");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Partido Politico: " + partidos[i]);
                Console.WriteLine("Fecha de creación: " + fechas [i]);
                Console.WriteLine("Aspirante a la presidencia: " + candidatos[i]);
                Console.WriteLine("...............................................................");
            }

            for (int i = 0; i < 1000; i++)
            {
                Random rnd = new Random();
                alt = rnd.Next(1,5);

                if (alt == 1)
                {
                    v1++;
                }

                if (alt == 2)
                {
                    v2++;
                }

                if (alt == 3)
                {
                    v3++;
                }

                if (alt == 4)
                {
                    v4++;
                }
            }

            double rslt = v1 + v2 + v3 + v4;

            double PFC  = (v1 / rslt) * 100;
            double PIPA = (v2 / rslt) * 100;
            double PAPA = (v3 / rslt) * 100;
            double PSCM = (v4 / rslt) * 100;

            Console.WriteLine("\nResultados: ");
            Console.WriteLine("\n" + candidatos[0] + " Consiguio " + v1 + " votos, con un " + PFC + "%");
            Console.WriteLine("\n" + candidatos[1] + " Consiguio " + v2 + " votos, con un " + PIPA + "%");
            Console.WriteLine("\n" + candidatos[2] + " Consiguio " + v3 + " votos, con un " + PAPA + "%");
            Console.WriteLine("\n" + candidatos[3] + " Consiguio " + v4 + " votos, con un " + PSCM + "%");

            Console.WriteLine("...........................................");
            if (v1 > v2 && v1 > v3 && v1 > v4)
            {
                Console.WriteLine("\n" + candidatos[0]+ " fue el ganador"); 
            }

            if (v2 > v1 && v2 > v3 && v2 > v4)
            {
                Console.WriteLine("\n" + candidatos[1] + " fue el ganador");
            }

            if (v3 > v1 && v3 > v2 && v3 > v4 )
            {
                Console.WriteLine("\n" + candidatos[2] + " fue el ganador");
            }

            if (v4 > v1 && v4 > v2 && v4 > v3)
            {
                Console.WriteLine("\n" + candidatos[3] + " fue el ganador");
            }

            Console.ReadKey();
        }
    }
}
