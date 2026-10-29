using System;
using System.Windows.Forms;

namespace PetMarketView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecuta el formulario de Categoría al iniciar
            Application.Run(new formTipoMascota());
        }
    }
}