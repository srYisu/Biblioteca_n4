using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    public class Errores//
    {
        public void RegistrarError(string mensajeError)
        {
            string rutaArchivo = "Errores.txt";
            string mensajeConMarcaDeTiempo = $"{DateTime.Now}: {mensajeError}\n";
            try
            {
                // Agrega el mensaje al archivo de errores.
                System.IO.File.AppendAllText(rutaArchivo, mensajeConMarcaDeTiempo);

            }
            catch (Exception ex)
            {
                // Notifica al usuario si no se pudo registrar el error.
                MessageBox.Show($"No se pudo guardar el error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
