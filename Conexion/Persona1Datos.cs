using System.Data.SqlClient;
using System.Data;
using Portafolio_RLG.Models;
using System.Security.Cryptography.Xml;

namespace Portafolio_RLG.Conexion
{
    public class Persona1Datos
    {
        public List<Persona1> Listar()
        {
            var oLista = new List<Persona1>();
            var cn = new Conexion();
            using (var conexion=new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using(var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Persona1()
                        {
                            IDpersona = Convert.ToInt32(dr["IDpersona"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcionfullstack = dr["Descripcionfullstack"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Pais = dr["Pais"].ToString(),
                            Ciudad = dr["Ciudad"].ToString()
                        });
                    }
                }

            }
            return oLista;
        }
        public Persona1 ObtenerContacto(int IDpersona)
        {
            var oContacto = new Persona1();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("IDpersona", IDpersona);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oContacto.IDpersona = Convert.ToInt32(dr["IDpersona"]);
                        oContacto.Nombre = dr["Nombre"].ToString();
                        oContacto.Descripcionfullstack = dr["Descripcionfullstack"].ToString();
                        oContacto.Email = dr["Email"].ToString();
                        oContacto.Telefono = dr["Telefono"].ToString();
                        oContacto.Pais = dr["Pais"].ToString();
                        oContacto.Ciudad = dr["Ciudad"].ToString();
                    }
                }

            }
            return oContacto;
        }
    }
}
