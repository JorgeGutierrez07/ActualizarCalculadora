using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo, alturaTriangulo = 0;


            bool baseTrianguloValid = double.TryParse(BaseTriangulo.Text, out baseTriangulo);
            bool alturaTrianguloValid = double.TryParse(AlturaTriangulo.Text, out alturaTriangulo);

            if (!baseTrianguloValid || !alturaTrianguloValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de triangulo");
            }
            else
            {
                double cal = (alturaTriangulo * baseTriangulo) / 2;
                AreaTriangulo.Text = cal.ToString();
            }

        }

        private void BotonPerimetroTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo, alturaTriangulo, lado3 = 0;
            bool baseTrianguloValid = double.TryParse(BaseTriangulo.Text, out baseTriangulo);
            bool alturaTrianguloValid = double.TryParse(AlturaTriangulo.Text, out alturaTriangulo);
            
            
            bool lado3valid = double.TryParse(Lado3.Text, out lado3);
            if (!baseTrianguloValid || !alturaTrianguloValid || !lado3valid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de triangulo");
            }
            else
            {
                double cal = baseTriangulo + alturaTriangulo + lado3;
                PerimetroTriangulo.Text = cal.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado = 0;
            bool ladoValid = double.TryParse(ladoCuadrado.Text, out lado);
            if ( !ladoValid )
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de cuadrado");
            }
            else
            {
                double cal = lado*lado;
                AreaCuadrado.Text = cal.ToString();
                double calPer = lado + lado + lado + lado;
                PeriCuadrado.Text = calPer.ToString();
            }
        }

        private void CalcularAreaRectangulo_Click(object sender, EventArgs e)
        {
            double baseRectangulo, altRectangulo = 0;
            bool baseRectValid = double.TryParse(BaseRectangulo.Text, out baseRectangulo);
            bool altRectValid = double.TryParse(AlturaRectangulo.Text, out altRectangulo);
            if (!baseRectValid || !altRectValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo del Rectangulo");
            }
            else
            {
                double calArea = altRectangulo * baseRectangulo;
                AreaRectangulo.Text = calArea.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double baseRectangulo, altRectangulo = 0;
            bool baseRectValid = double.TryParse(BaseRectangulo.Text, out baseRectangulo);
            bool altRectValid = double.TryParse(AlturaRectangulo.Text, out altRectangulo);
            if (!baseRectValid || !altRectValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo del Rectangulo");
            }
            else
            {
                double calPeri = (altRectangulo * 2) + (baseRectangulo * 2);
                PerimetroRectangulo.Text = calPeri.ToString();
            }
        }

        private void AreaCirculo_Click(object sender, EventArgs e)
        {
            double radio = 0;
            bool radioValid = double.TryParse(RadioCirculo.Text, out radio);
            if (!radioValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de Circulo");
            }
            else
            {
                double pi = Math.PI;
                double calArea = pi * (radio * radio);
                ResultadoAreaCirculo.Text = calArea.ToString();
            }
        }

        private void PerimetroCirculo_Click(object sender, EventArgs e)
        {
            double radio = 0;
            bool radioValid = double.TryParse(RadioCirculo.Text, out radio);
            if (!radioValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de Circulo");
            }
            else
            {
                double pi = Math.PI;
                double calPerimetro = 2 * (pi * radio);
                ResultadoPerimetroCirculo.Text = calPerimetro.ToString();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void ResultadoAreaRombo_Click(object sender, EventArgs e)
        {
            double diametroMayor, diametroMenor = 0;
            bool diametroMaValid = double.TryParse(Diametromayor.Text, out diametroMayor);
            bool diametroMeValid = double.TryParse(Diametromayor.Text, out diametroMenor);
            if (!diametroMaValid || !diametroMeValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de Rombo");
            }
            else
            {
                double calArea = (diametroMayor * diametroMenor) / 2;
                ResAreaRombo.Text = calArea.ToString();
            }
        }

        private void ResultadoAreaPerimetro_Click(object sender, EventArgs e)
        {
            double lado = 0;
            bool ladoValid = double.TryParse(LongLadoRombo.Text, out lado);
            if (!ladoValid)
            {
                MessageBox.Show("Inserta valores validos o no vacios", "Calculo de Rombo");
            }
            else
            {
                double calPer = lado * 4;
                ResPeriRombo.Text = calPer.ToString();
            }
        }
    }
}
