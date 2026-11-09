using MySql.Data.MySqlClient;

namespace Ejercicio3;

public static class Conexion
{
    private static readonly string cadenaConexion = "Server=localhost;Port=3306;Database=LoginDB;Uid=root;Pwd=demo;"; // PROFE RECUERDE QUE AQUI VA SU PASSWORD

    public static MySqlConnection ObtenerConexion()
    {
        var conexion = new MySqlConnection(cadenaConexion);
        conexion.Open();
        return conexion;
    }
}