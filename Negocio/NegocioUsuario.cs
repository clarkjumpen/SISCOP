using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Npgsql;
using System.Data;
using Modelo;

namespace Negocio
{
    public class NegocioUsuario
    {


        public Usuario getUsuario(string rut)
        {
            string sql = "SELECT * FROM public.usuario WHERE usuario.rut ='" + rut + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();
                

            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Usuario u = new Usuario();
          
                foreach (DataRow row in n.dt.Rows)
                {

                    u.RUT = row[1].ToString();
                    u.NOMBRE = row[2].ToString();
                    u.APELLIDO = row[3].ToString();
                    u.CLAVE = row[4].ToString();
                    u.BLOQUEADO = (bool)row[5];
                    u.NIVEL = (int)row[6];


                }
            
            n.conn.Close();
            return u;
        }

        public List<Usuario> getUsuarios()
        {
            string sql = "SELECT * FROM public.usuario";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Usuario> lista = new List<Usuario>();
            
           
               
                foreach (DataRow row in n.dt.Rows)
                {
                    Usuario u = new Usuario();
                    u.RUT = row[1].ToString();
                    u.NOMBRE = row[2].ToString();
                    u.APELLIDO = row[3].ToString();
                    u.CLAVE = row[4].ToString();
                    u.BLOQUEADO = (bool)row[5];
                    u.NIVEL = (int)row[6];

                    lista.Add(u);
                }
                
            
            n.conn.Close();
            return lista;
        }

        public bool IniciarSesion(string rut, string clave)
        {
            string sql = "SELECT usuario.rut, usuario.clave FROM public.usuario WHERE usuario.rut ='" + rut + "' AND usuario.clave ='" + clave + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {

                    if (rut.Equals(row[0].ToString()) && clave.Equals(row[1].ToString()))
                    {
                        n.conn.Close();
                        return true;

                    }

                }
            }
            n.conn.Close();
            return false;
        }

        public bool estaBloqueado(string rut)
        {
            string sql = "SELECT usuario.establoqueado FROM public.usuario WHERE usuario.rut ='" + rut + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {

                    if ((bool)row[0] == true)
                    {
                        n.conn.Close();
                        return true;

                    }

                }
            }
            n.conn.Close();
            return false;
        }

        public int getNivel(string rut)
        {
            string sql = "SELECT usuario.nivel FROM public.usuario WHERE usuario.rut ='" + rut + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {

                    n.conn.Close();
                    return (int)row[0];

                }
            }
            n.conn.Close();
            return -1;
        }

        public void agregarUsuario(Usuario u)
        {
            string sql = "INSERT INTO usuario(rut, nombre, apellido, clave, establoqueado, nivel)"
                + "VALUES('" + u.RUT + "','"
                            + u.NOMBRE + "','"
                            + u.APELLIDO + "','"
                            + u.CLAVE + "',"
                            + u.BLOQUEADO + ","
                            + u.NIVEL + ")";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public void modificarUsuario(Usuario u)
        {
            string sql = "UPDATE usuario SET"
                +" nombre ='"+u.NOMBRE
                +"', apellido ='"+u.APELLIDO
                +"', establoqueado ="+u.BLOQUEADO
                +", nivel =" +u.NIVEL+" WHERE rut='"+u.RUT+"'";
            
            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

        public void modificarUsuarioClave(Usuario u)
        {
            string sql = "UPDATE usuario SET"
                + " nombre ='" + u.NOMBRE
                + "', apellido ='" + u.APELLIDO
                +"', clave='"+u.CLAVE
                + "', establoqueado =" + u.BLOQUEADO
                + ", nivel =" + u.NIVEL + " WHERE rut='" + u.RUT + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

        public void eliminarUsuario(String rut)
        {
            string sql = "DELETE FROM usuario WHERE rut='" + rut + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }
    }
}
