using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Tron
{
    public class Mapa
    {
        private Nodo[,] nodos;
        public int Ancho { get; private set; }
        public int Alto { get; private set; }


        public Mapa(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
            nodos = new Nodo[ancho, alto];
            InicializarMalla();
        }

        private void InicializarMalla()
        {
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    nodos[x, y] = new Nodo { X = x, Y = y };
                }
            }

            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    if (x > 0) nodos[x, y].Izquierda = nodos[x - 1, y];
                    if (x < Ancho - 1) nodos[x, y].Derecha = nodos[x + 1, y];
                    if (y > 0) nodos[x, y].Arriba = nodos[x, y - 1];
                    if (y < Alto - 1) nodos[x, y].Abajo = nodos[x, y + 1];
                }
            }
        }
        public Nodo NodoEn(int x, int y)
        {
            if (x >= 0 && x < Ancho && y >= 0 && y < Alto)
            {
                return nodos[x, y];
            }
            return null; // Devuelve null si las coordenadas están fuera del rango
        }
    }
}
