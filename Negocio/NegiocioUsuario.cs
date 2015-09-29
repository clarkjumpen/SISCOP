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
    public class NegiocioUsuario
    {


        public Usuario getUsuario(string rut)
        {
            string sql = "SELECT * FROM public.usuario WHERE usuario.rut ='" + rut+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Usuario u = new Usuario();
            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {
                  
                    u.RUT = row[1].ToString();
                    u.NOMBRE = row[2].ToString();
                    u.APELLIDO = row[3].ToString();
                    u.CLAVE = row[4].ToString();
                    u.BLOQUEADO = (bool) row[5];
                    u.NIVEL = (int) row[6];
                    

                }
            }
            n.conn.Close();
            return u;
        }

        public bool IniciarSesion(string rut, string clave)
        {
            string sql = "SELECT usuario.rut, usuario.clave FROM public.usuario WHERE usuario.rut ='"+rut+"' AND usuario.clave ='"+ clave+"'";

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
                        return true;

                    }
                    
                }
            }
            n.conn.Close();
            return false;
        }

        public bool estaBloqueado(string rut)
        {
            string sql = "SELECT usuario.establoqueado FROM public.usuario WHERE usuario.rut ='" + rut +"'";

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

                    if ((bool)row[0]==true)
                    {
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
                    return (int) row[0];

                }
            }
            n.conn.Close();
            return -1;
        }
    }
}
