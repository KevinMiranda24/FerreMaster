using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace FerreMaster
{
	public class ComunDB
	{
		//Esta clase es para la cadena de conexion de la Base de Datos
		const string StringDeConexion = @"Data Source=DESKTOP-JSF8LSD\SQLEXPRESS;Initial Catalog=tienOnlineFerreMaster;Integrated Security=True;";

		SqlConnection SqlCon;
		SqlCommand cmd;
		SqlDataAdapter da;
		DataTable dt;

		public void Open()
		{
			try
			{

				SqlCon = new SqlConnection(StringDeConexion);
				SqlCon.Open();
				MessageBox.Show("Conectado correctamente:", "Exito al conectar", MessageBoxButtons.OK);

			}
			catch (Exception e)
			{
				MessageBox.Show("ErrorP: " + e.Message, "Error inesperado", MessageBoxButtons.OK);
			}
		}
		private static SqlConnection ObtenerConexion()
		{
			SqlConnection _conexion = new SqlConnection(StringDeConexion);
			_conexion.Open();
			return _conexion;
		}

		public static int EjecutarComando(string pConsulta)
		{
			SqlConnection _conexion = ObtenerConexion();
			SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
			int resultado = _comando.ExecuteNonQuery();
			_conexion.Close();
			return resultado;
		}
        public static SqlDataReader EjecutarComandoReader(string pConsulta)
		{
			SqlConnection _conexion = ObtenerConexion();
			SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
			SqlDataReader _reader = _comando.ExecuteReader(CommandBehavior.CloseConnection);
			return _reader;
		}
        public static int EjecutarComandoSelect(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();
            SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
            int resultado = (int)_comando.ExecuteScalar();
            _conexion.Close();
            return resultado;
        }
    }
}
