using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarjeta_P___Luis_Ramos.Pages
{
    public class IMCModel : PageModel
    {
        // --------------------------------------------------
        // VARIABLES RECIBIDAS DESDE EL FORMULARIO
        // --------------------------------------------------

        [BindProperty]
        public double Peso { get; set; }

        [BindProperty]
        public double Estatura { get; set; }


        // --------------------------------------------------
        // RESULTADO DEL CÁLCULO
        // --------------------------------------------------

        public double? ResultadoIMC { get; set; }


        // --------------------------------------------------
        // CLASIFICACIÓN DEL IMC
        // --------------------------------------------------

        public string Clasificacion { get; set; } = "";


        // --------------------------------------------------
        // MENSAJE DE ERROR
        // --------------------------------------------------

        public string MensajeError { get; set; } = "";


        // --------------------------------------------------
        // MÉTODO GET
        // Se ejecuta al abrir la página
        // --------------------------------------------------

        public void OnGet()
        {

        }


        // --------------------------------------------------
        // MÉTODO POST
        // Se ejecuta al presionar el botón Calcular
        // --------------------------------------------------

        public void OnPost()
        {
            // Validamos que peso y estatura sean mayores a cero

            if (Peso <= 0 || Estatura <= 0)
            {
                MensajeError = "Ingresa un peso y una estatura válidos.";
                return;
            }


            // --------------------------------------------------
            // CALCULAR IMC
            // Fórmula: Peso / Estatura²
            // --------------------------------------------------

            ResultadoIMC = Peso / (Estatura * Estatura);


            // --------------------------------------------------
            // CLASIFICAR EL RESULTADO
            // --------------------------------------------------

            if (ResultadoIMC < 18.5)
            {
                Clasificacion = "Bajo peso";
            }
            else if (ResultadoIMC < 25)
            {
                Clasificacion = "Peso normal";
            }
            else if (ResultadoIMC < 30)
            {
                Clasificacion = "Sobrepeso";
            }
            else
            {
                Clasificacion = "Obesidad";
            }
        }
    }
}
