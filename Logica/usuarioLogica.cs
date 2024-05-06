using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms.ComponentModel;
using Laboratorio.modelo;
using System.Data.SQLite;


namespace Laboratorio.Logica
{
    public class usuarioLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static usuarioLogica _instanci = null;

        public static usuarioLogica Instancia2
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new usuarioLogica();
                }
                return _instanci;
            }
        }

        public bool guardar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Insert into Usuarios(Nombre,Apellidos,CorreoElec,Telefono) values (@Nombre,@Apellidos,@CorreoElec,@Telefono)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@CorreoElec", obj.CorreoElec));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Personalnumber));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public List<Persona> listar()
        {
            List<Persona> Lista = new List<Persona>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Select Usuario_Id,Nombre,Apellidos,CorreoElec,Telefono from Usuarios";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Lista.Add(new Persona()
                        {
                            Usuario_Id = int.Parse(dr["Usuario_Id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            CorreoElec = dr["CorreoElec"].ToString(),
                            Personalnumber = dr["Telefono"].ToString(),
                        });
                    }
                }


            }


            return Lista;
        }

        public bool Editar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Usuarios set Nombre = @Nombre,Apellidos = @Apellidos,CorreoElec = @CorreoElec, Telefono = @Telefono where Usuario_Id = @Usuario_Id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Usuario_Id", obj.Usuario_Id));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@CorreoElec", obj.CorreoElec));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Personalnumber));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Eliminar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Delete from usuarios where Usuario_Id = @Usuario_Id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Usuario_Id", obj.Usuario_Id));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

    }
}
