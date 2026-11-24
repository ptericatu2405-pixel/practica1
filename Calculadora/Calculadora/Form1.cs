/* 
 Deber / Ejercicio: Calculadora en C# (Windows Forms)
Autor(a): Erika Paola Tamba

Fecha de realización: 12/11/2026

Fecha de entrega: [Insertar fecha]

Resultados:
Desarrollo e implementación exitosa de una aplicación de escritorio interactiva
bajo la arquitectura de Windows Forms en C#, dotada de una interfaz gráfica intuitiva 
para realizar operaciones aritméticas básicas de forma precisa. Por lo ta
nto, se logra una experiencia de usuario fluida y eficiente, cumpliendo con los requisitos 
funcionales y de usabilidad establecidos en el practica.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        string operador = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn9.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                num1 = Convert.ToDouble(txtPantalla.Text);
                operador = btnSuma.Text;
                txtPantalla.Clear();
            }
        }

       

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                num1 = Convert.ToDouble(txtPantalla.Text);
                operador = btnMultiplicar.Text;
                txtPantalla.Clear();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                num1 = Convert.ToDouble(txtPantalla.Text);
                operador = btnDividir.Text;
                txtPantalla.Clear();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Verificamos que haya texto y que no sea solo un signo menos suelto
            if (txtPantalla.Text != "" && txtPantalla.Text != "-")
            {
                num2 = Convert.ToDouble(txtPantalla.Text);

                if (operador == btnSuma.Text)
                {
                    txtPantalla.Text = Convert.ToString(num1 + num2);
                }
                if (operador == btnRestar.Text)
                {
                    txtPantalla.Text = Convert.ToString(num1 - num2);
                }
                if (operador == btnMultiplicar.Text)
                {
                    txtPantalla.Text = Convert.ToString(num1 * num2);
                }
                if (operador == btnDividir.Text)
                {
                    if (num2 != 0)
                    {
                        txtPantalla.Text = (num1 / num2).ToString();
                    }
                    else
                    {
                        txtPantalla.Text = "Error";
                    }
                }
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            {
                // Si la pantalla está vacía, permitimos usar el
                // botón de resta para poner un número negativo (-)
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "-";
                }
                else
                {
                    // Si ya hay un número, actúa como operador normal de resta
                    num1 = Convert.ToDouble(txtPantalla.Text);
                    operador = btnRestar.Text;
                    txtPantalla.Clear();
                }
            }
        }
    }
}
/*
 * Conclusiones:
    - El uso del entorno de Visual Studio y el modelo de eventos en C# facilita la estructuración de la 
    lógica de programación orientada a objetos, permitiendo enlazar correctamente las acciones del usuario en la interfaz gráfica con las funciones de cálculo implementadas en el código fuente.

    - La correcta gestión de la estructura del proyecto y de los espacios de nombres (namespaces) es
    fundamental para garantizar una compilación limpia y evitar conflictos de rutas o referencias en los
    archivos de diseño (.Designer.cs).

* Recomendaciones:
    -  Verificar y mantener la sincronización de las rutas de los archivos de código (.cs), 
    recursos (.resx) y metadatos (.csproj) dentro del directorio de trabajo para prevenir errores de 
    compilación o desvinculación visual del formulario.

    - Realizar respaldos periódicos y limpiezas de carpetas temporales (bin / obj) antes de realizar 
    control de versiones o subidas a repositorios públicos como GitHub, asegurando así la integridad y 
    portabilidad del código fuente.

  - Bibliografía:
    Naranjo, J. (16 de octubre de 2026). ITID 543 Diseño y Programación de Software:
    Especificación y Validación de Requerimientos [Archivo PDF: ITID543_04_JLNV.pdf].
    Google Drive. https://drive.google.com/open?id=1rNi0uTHfMwTjpzmf_9i7iDDrdaNdNplx
*/