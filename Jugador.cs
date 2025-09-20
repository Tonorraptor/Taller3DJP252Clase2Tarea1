using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Jugador
    {
        private string name;
        private int vida;
        private int daño;

        public Jugador(string name, int vida, int daño)
        {
            this.name = name;
            this.vida = vida;
            this.daño = daño;
        }

        public virtual int RecibirDaño(int daño)
        {
            vida -= daño;
            return vida;
        }
        public virtual int Vida()
        {
            return vida;
        }
        public virtual int Daño()
        {
            return daño;
        }
        public virtual string Name()
        {
            return name;
        }
    }
}
