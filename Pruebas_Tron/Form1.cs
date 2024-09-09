using System.Windows.Forms;

namespace Pruebas_Tron
{
    public partial class Form1 : Form
    {
        private Mapa mapa;
        private Controles controles;
        private int cellSize = 26;

        public Form1()
        {
            InitializeComponent();
            mapa = new Mapa(40, 25); // Ejemplo: mapa de 10x10
            this.Paint += new PaintEventHandler(Form1_Paint);

            // Configurar el tamaño del PictureBox para que coincida con el tamaño de la celda
            PicMoto.Width = cellSize;
            PicMoto.Height = cellSize;

            Nodo nodoInicial = mapa.NodoEn(0, 0); // Posición inicial de la moto
            controles = new Controles(mapa, nodoInicial, PicMoto, cellSize);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            controles.Mover(e);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkBlue, 1); // Color y grosor de las líneas de la cuadrícula

            for (int x = 0; x <= mapa.Ancho; x++)
            {
                e.Graphics.DrawLine(pen, x * cellSize, 0, x * cellSize, mapa.Alto * cellSize);
            }

            for (int y = 0; y <= mapa.Alto; y++)
            {
                e.Graphics.DrawLine(pen, 0, y * cellSize, mapa.Ancho * cellSize, y * cellSize);
            }
        }
    }
}
