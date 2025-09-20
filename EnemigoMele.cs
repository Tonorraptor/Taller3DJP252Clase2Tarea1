using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class EnemigoMele:Enemigo
    {

        public EnemigoMele(string name, int vida, int daño, bool vivo):base("Enemigo mele", 10, 2,vivo)
        {
        }
        public override int Daño()
        {
            return daño;
        }
        public override int Vida()
        {
            return vida;
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
    }
}
