using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Tron
{
    public class Controles
    {
        private Nodo nodoActual;
        private PictureBox picMoto;
        private Mapa mapa;
        private int cellSize;

        public Controles(Mapa mapa, Nodo nodoInicial, PictureBox picMoto, int cellSize)
        {
            this.mapa = mapa;
            this.nodoActual = nodoInicial;
            this.picMoto = picMoto;
            this.cellSize = cellSize;

            // Inicializar la ubicación del PictureBox
            picMoto.Location = new Point(nodoActual.X * cellSize, nodoActual.Y * cellSize);
        }

        public void Mover(KeyEventArgs e)
        {
            Nodo nuevoNodo = null;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    nuevoNodo = nodoActual.Arriba;
                    break;
                case Keys.Down:
                    nuevoNodo = nodoActual.Abajo;
                    break;
                case Keys.Left:
                    nuevoNodo = nodoActual.Izquierda;
                    break;
                case Keys.Right:
                    nuevoNodo = nodoActual.Derecha;
                    break;
            }

            if (nuevoNodo != null)
            {
                nodoActual = nuevoNodo;
                // Actualizar la posición del PictureBox basado en el tamaño de la celda
                picMoto.Location = new Point(nodoActual.X * cellSize, nodoActual.Y * cellSize);
            }
        }
    }
}
