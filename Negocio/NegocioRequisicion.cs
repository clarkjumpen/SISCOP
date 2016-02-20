using Conexion;
using Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioRequisicion
    {
        public void agregarRequisicion(Requisicion r )
        {
            string sql = "INSERT INTO requisicion(usuario_rut_fk, descripcion, fecha, prioridad,tipo,numero, estado) "
                + "VALUES('" + r.USUARIO_RUT + "','"
                            + r.DESCRIPCION + "','"
                            + r.FECHA + "','"
                            + r.PRIORIDAD + "','"
                            + r.TIPO + "',"
                            + r.NUMERO + ",'"
                            + r.ESTADO + "')";
            
            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

        public bool existeRequisicion(double numero)
        {
            string sql = "SELECT * FROM requisicion WHERE numero =" + numero;

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
                    return true;


                }
            }
            n.conn.Close();
            return false;

        }
        public void modificarRequisicion(Requisicion r)
        {
            string sql = "UPDATE requisicion SET "
                + "usuario_rut_fk ='" + r.USUARIO_RUT + "',"
                + "descripcion ='" + r.DESCRIPCION + "',"
                + "fecha ='" + r.FECHA + "',"
                + "prioridad ='" + r.PRIORIDAD + "',"
                + "tipo ='" + r.TIPO + "',"
                + "estado ='" + r.ESTADO + "' WHERE numero=" + r.NUMERO;

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

        
        
        public void eliminarRequisicion(double numero)
        {
            string sql = "DELETE FROM requisicion WHERE numero=" + numero;

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }
        public Requisicion getRequisicion(double numero)
        {
            string sql = "SELECT * FROM requisicion WHERE numero =" + numero;

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Requisicion r = new Requisicion();
            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {
                   
                    r.USUARIO_RUT = row[1].ToString();
                    r.DESCRIPCION  = row[2].ToString();
                    r.FECHA = row[3].ToString();
                    r.PRIORIDAD = row[4].ToString();
                    r.TIPO = row[5].ToString();
                    r.NUMERO = Double.Parse(row[6].ToString());
                    r.ESTADO = row[7].ToString();
                 


                }
            }
            n.conn.Close();
            return r;
        }
        public Requisicion getRequisicionUsuario(String rut)
        {
            string sql = "SELECT * FROM requisicion WHERE usuario_rut_fk ='" + rut+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Requisicion r = new Requisicion();
            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {

                    r.USUARIO_RUT = row[1].ToString();
                    r.DESCRIPCION = row[2].ToString();
                    r.FECHA = row[3].ToString();
                    r.PRIORIDAD = row[4].ToString();
                    r.TIPO = row[5].ToString();
                    r.NUMERO = Double.Parse(row[6].ToString());
                    r.ESTADO = row[7].ToString();



                }
            }
            n.conn.Close();
            return r;
        }
        public List<Requisicion> getRequisiciones()
        {
            string sql = "SELECT * FROM requisicion";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Requisicion> lista = new List<Requisicion>();



            foreach (DataRow row in n.dt.Rows)
            {
                Requisicion r = new Requisicion();
                r.USUARIO_RUT = row[0].ToString();
                r.DESCRIPCION = row[1].ToString();
                r.FECHA = "";
                r.PRIORIDAD = row[3].ToString();
                r.TIPO = row[4].ToString();
                r.NUMERO = (Double)row[5];

                lista.Add(r);
            }


            n.conn.Close();
            return lista;
        }

        public List<String> getEstados()
        {
            string sql = "SELECT estado FROM estadorequisicion order by estado asc";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<String> lista = new List<String>();



            foreach (DataRow row in n.dt.Rows)
            {
                String nombre = row[0].ToString();

                lista.Add(nombre);
            }


            n.conn.Close();
            return lista;
        }

        public List<String> getTipos()
        {
            string sql = "SELECT nombre FROM tiporequisicion order by nombre asc";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<String> lista = new List<String>();



            foreach (DataRow row in n.dt.Rows)
            {
                String nombre = row[0].ToString();

                lista.Add(nombre);
            }


            n.conn.Close();
            return lista;
        }

        public List<String> getPrioridades()
        {
            string sql = "SELECT nombre FROM prioridadrequisicion order by nombre asc";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<String> lista = new List<String>();



            foreach (DataRow row in n.dt.Rows)
            {
                String nombre = row[0].ToString();

                lista.Add(nombre);
            }


            n.conn.Close();
            return lista;
        }

        public Double getNumeroRequisicion()
        {
            string sql = "SELECT max(numero) FROM requisicion";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            String numero="";
            foreach (DataRow row in n.dt.Rows)
            {
                 numero = row[0].ToString();
            }


            n.conn.Close();

            if (numero.Equals(""))
            {
                return 0;
            }
            return double.Parse(numero);
        }
    }
}
