using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    public partial class FormBlanco : Form
    {
        Errores errores = new Errores();
        public FormBlanco()
        {
            InitializeComponent();
        }

        public static double CalcularRaizCuadrada(double numero)
        {
            // Verifica si el número es negativo.
            if (EsNegativo(numero))
            {
                // Lanza una excepción si el número es negativo.
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            // Devuelve la raíz cuadrada si el número es válido.
            return Math.Sqrt(numero);
        }

        // Método auxiliar para determinar si un número es negativo.
        private static bool EsNegativo(double numero)
        {
            return numero < 0;
        }

        // Evento que se ejecuta al hacer clic en el botón "Calcular".
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Intenta convertir el texto ingresado a un número.
                double numero = double.Parse(txtNumero.Text);

                // Calcula la raíz cuadrada del número ingresado.
                double resultado = CalcularRaizCuadrada(numero);

                // Muestra el resultado al usuario.
                MessageBox.Show($"La raíz cuadrada de {numero} es {resultado:F2}");
            }
            catch (FormatException)
            {
                // Maneja el error si el usuario no ingresa un número válido.
                errores.RegistrarError("Por favor, ingrese un número válido.");
            }
            catch (ArgumentException ex)
            {
                // Maneja el error si el número es negativo.
                errores.RegistrarError(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Maneja cualquier otro error inesperado.
                errores.RegistrarError("Error inesperado: " + ex.Message);
            }
        }
    }
}
