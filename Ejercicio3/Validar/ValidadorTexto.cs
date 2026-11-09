namespace Ejercicio3.Validar
{
    public class ValidadorTexto : IValidatorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MensajeError = "El campo no puede estar vacio";
                return false;
            }
            return true;
        }
    }
}