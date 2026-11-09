namespace Ejercicio3.Validar
{
    public interface IValidatorCampo // aprovechando lo que tenemos del CRUD:b
    {
        bool EsValido(string? valor);
        string MensajeError { get; }
    }
}