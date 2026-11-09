using MySql.Data.MySqlClient;
using System.Data;

namespace Ejercicio3;

public static class Utiles
{
    public static string? Registrar(string usuario, string clave)
    {
        string hash = BCrypt.Net.BCrypt.HashPassword(clave);

        using MySqlConnection conexion = Conexion.ObtenerConexion(); // coge la conex
        using MySqlCommand cmd = new("INSERT INTO Usuarios (NombreUsuario, PasswordHash) VALUES (@u, @h)", conexion); // agrega al user
        cmd.Parameters.AddWithValue("@u", usuario); // le mete los parametros a la query
        cmd.Parameters.AddWithValue("@h", hash);
        try
        {
            cmd.ExecuteNonQuery();
            return hash; // devuelve el hash
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            return null;
        }
    }

    public static bool Login(string usuario, string clave)
    {
        using MySqlConnection conexion = Conexion.ObtenerConexion(); // ig que arriba coge la conex
        using MySqlCommand cmd = new("SELECT PasswordHash FROM Usuarios WHERE NombreUsuario = @u", conexion); // tira la query para buscar al user
        cmd.Parameters.AddWithValue("@u", usuario); // ig mete parametros
        bool valido = cmd.ExecuteScalar() is string hash && BCrypt.Net.BCrypt.Verify(clave, hash); // convierte el hash para comparar a ver si esta bien
        // agrega el intento de meterse
        using MySqlCommand log = new("INSERT INTO IntentosLogin (NombreUsuario, Exitoso, Fecha) VALUES (@u, @e, NOW())", conexion);
        log.Parameters.AddWithValue("@u", usuario);
        log.Parameters.AddWithValue("@e", valido);
        log.ExecuteNonQuery();

        return valido;
    }

    public static DataTable ObtenerIntentos() // esto es pal data grid view
    {
        using MySqlConnection conexion = Conexion.ObtenerConexion();
        using MySqlDataAdapter sqlTabla = new("SELECT NombreUsuario, Exitoso, Fecha FROM IntentosLogin ORDER BY Id DESC", conexion);
        DataTable datosTabla = new();
        sqlTabla.Fill(datosTabla);
        return datosTabla;
    }
}