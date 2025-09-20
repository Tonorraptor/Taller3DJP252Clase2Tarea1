using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Enemigo
    {
        protected string name;
        protected int vida;
        protected int daño;
        protected bool vivo = true;

        public Enemigo(string name, int vida, int daño, bool vivo)
        {
            this.name = name;
            this.vida = vida;
            this.daño = daño;
            this.vivo = vivo;
        }
        public virtual int RecibirDaño(int daño)
        {
            return 0;
        }
        public virtual int Daño()
        {
            return 0;
        }
        public virtual int Vida()
        {
            return 0;
        }
        public virtual string Name()
        {
            return name;
        }
        public virtual bool Morir()
        {
            return vivo;
        }
    }
}
