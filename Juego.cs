using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Juego
    {
        public void Execute()
        {
            List<Enemigo> enemigos = new List<Enemigo>();
            int CantidadEnemigos=10;
            bool juego = true;
            for(int i = 0; i < CantidadEnemigos; i++)
            {
                if (i % 3 == 0)
                {
                    enemigos.Add(new EnemigoRango("Enemigo Rango", 20, 5, true, 10));
                }
                else
                {
                    enemigos.Add(new EnemigoMele("Enemigo mele", 10, 2, true));
                }
            }
            int option = -1;
            while (option!=2)
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1 Jugar");
                Console.WriteLine("2 Salir");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int elegir;
                        Jugador j = GetDatos();
                        Console.WriteLine($"{j.Name()} {j.Vida()} {j.Daño()}");
                        for (int i = 0; i < enemigos.Count; i++)
                        {
                            var enemigo = enemigos[i];
                            Console.WriteLine($"{i} {enemigo.Name()} {enemigo.Vida()} {enemigo.Daño()}");
                        }
                        while (juego)
                        {
                            Console.WriteLine("Elige un enemigo en el oden que aparece");
                            elegir = int.Parse(Console.ReadLine());
                            if (elegir >= 0 && elegir < enemigos.Count)
                            {
                                var enemIgoSeleccionado = enemigos[elegir];
                                enemIgoSeleccionado.RecibirDaño(j.Daño());
                                Console.WriteLine($"El enemigo {enemIgoSeleccionado.Name()} ahora tiene {enemIgoSeleccionado.Vida()}");
                                for (int i = 0; i < enemigos.Count; i++)
                                {
                                    var enemigo = enemigos[i];
                                    Console.WriteLine($"{i} {enemigo.Name()} {enemigo.Vida()} {enemigo.Daño()}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El enemigo no existe, pierdes un turno");
                            }
                            for (int i = 0; i < enemigos.Count; i++)
                            {
                                if (enemigos[i].Morir())
                                {
                                    j.RecibirDaño(enemigos[i].Daño());
                                    Console.WriteLine($"Recibiste {enemigos[i].Daño()} de daño");
                                    Console.WriteLine($"Tienes {j.Vida()}");
                                }

                            }
                            for (int i = 0; i < enemigos.Count; i++)
                            {
                                var enemigo = enemigos[i];
                                Console.WriteLine($"{i} {enemigo.Name()} {enemigo.Vida()} {enemigo.Daño()}");
                            }
                            bool victoria = true;
                            for (int i = 0; i < enemigos.Count; i++)
                            {
                                if (enemigos[i].Vida() >= 0)
                                {
                                    victoria = false;
                                }
                            }
                            if (victoria)
                            {
                                Console.WriteLine("Has ganado");
                                juego = false;
                            }
                            else if (j.Vida() <= 0)
                            {
                                Console.WriteLine("Has perdido");
                                juego = false;
                            }
                        }
                            break;
                    case 2:
                        Console.WriteLine("Saliendo de juego");
                        break;
                }
            }
        }
        private Jugador GetDatos()
        {
            string name;
            int vida, daño;
            Console.WriteLine("Añade un nombre");
            name = Console.ReadLine();
            Console.WriteLine("Añade cantidad de vida");
            vida = int.Parse(Console.ReadLine());
            Console.WriteLine("Añade cantidad de daño");
            daño = int.Parse(Console.ReadLine());
            if(vida<=100 && daño <= 100)
            {
                Jugador j = new Jugador(name, vida, daño);
                return j;
            }
            else
            {
                Console.WriteLine("Tus valorees no pueden exceder mas de 100");
                return GetDatos();
            }
        }
    }
}
