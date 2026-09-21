using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarjeta_P___Luis_Ramos.Pages

{
    public class CalculadoraModel : PageModel
    {
        // --------------------------------------------------
        // VARIABLES QUE RECIBIREMOS DEL FORMULARIO
        // --------------------------------------------------

        [BindProperty]
        public double Numero1 { get; set; }

        [BindProperty]
        public double Numero2 { get; set; }


        // --------------------------------------------------
        // VARIABLE PARA GUARDAR EL RESULTADO
        // --------------------------------------------------

        public double? Resultado { get; set; }


        // --------------------------------------------------
        // VARIABLE PARA MOSTRAR MENSAJES DE ERROR
        // --------------------------------------------------

        public string MensajeError { get; set; } = "";


        // --------------------------------------------------
        // MÉTODO GET
        // Se ejecuta cuando abrimos la página
        // --------------------------------------------------

        public void OnGet()
        {

        }


        // --------------------------------------------------
        // MÉTODO POST
        // Se ejecuta cuando presionamos un botón
        // --------------------------------------------------

        public void OnPost(string operacion)
        {

            // Evaluamos qué operación seleccionó el usuario

            switch (operacion)
            {

                // SUMA
                case "sumar":

                    Resultado = Numero1 + Numero2;

                    break;


                // RESTA
                case "restar":

                    Resultado = Numero1 - Numero2;

                    break;


                // MULTIPLICACIÓN
                case "multiplicar":

                    Resultado = Numero1 * Numero2;

                    break;


                // DIVISIÓN
                case "dividir":

                    // Validamos que no se intente dividir entre cero

                    if (Numero2 != 0)
                    {
                        Resultado = Numero1 / Numero2;
                    }
                    else
                    {
                        MensajeError = "No se puede dividir entre cero.";
                    }

                    break;
            }
        }
    }
}
