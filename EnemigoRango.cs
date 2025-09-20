using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class EnemigoRango:Enemigo
    {
        private int bala;
        public EnemigoRango(string name, int vida, int daño, bool vivo, int bala) : base("Enemigo Rango", 20, 5, vivo)
        {
            this.bala = bala;
        }
        public override int Vida()
        {
            return vida;
        }

        public override int Daño()
        {
            return daño;
        }
        public override int RecibirDaño(int daño)
        {

            vida -= daño;
            return vida;
        }
        public override string Name()
        {
            return name;
        }
        public override bool Morir()
        {
            if (vida <= 0)
            {
                vivo = false;
            }
            return vivo;
        }
        public virtual int Balas()
        {
            return bala;
        }
    }
}
