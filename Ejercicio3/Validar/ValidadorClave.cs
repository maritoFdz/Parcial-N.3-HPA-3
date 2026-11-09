namespace Ejercicio3.Validar
{
    public class ValidadorClave : IValidatorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || valor.Length < 4)
            {
                MensajeError = "La password debe tener por lo menos 4 caracteres";
                return false;
            }
            return true;
        }
    }
}