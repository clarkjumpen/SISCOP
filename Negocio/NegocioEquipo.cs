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
   public class NegocioEquipo
    {

        public bool existeEquipo(Equipo eq)
        {
            string sql = "SELECT* from equipo where numeroserie='"+eq.NUMEROSERIE+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


          
                foreach (DataRow row in n.dt.Rows)
                {
                n.conn.Close();
                return true;

               }

                
            
            n.conn.Close();
            return false;
        }

        public void agregarEquipo(Equipo e)
        {

            string sql = "INSERT INTO public.equipo(nombre, modelo, codigo, numeroserie, pitbull, horometro,ano) VALUES('"
                        + e.NOMBRE + "','"
                        + e.MODELO + "','"
                        + e.CODIGO + "','"
                        + e.NUMEROSERIE + "','"
                        + e.PITBULL + "',"
                        + e.HOROMETRO + ","
                        + e.ANO + ")";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();
        }
        public void modificarEquipo(Equipo e)
        {

            string sql = "UPDATE EQUIPO SET nombre='"+e.NOMBRE+"', "
                           +    " modelo='"+e.MODELO+"',"
                            +   "codigo='"+e.CODIGO+"',"
                            +   "pitbull='"+e.PITBULL+"',"
                           +    "horometro ="+e.HOROMETRO+","
                           +    "ano ="+e.ANO+" where numeroserie='"+e.NUMEROSERIE+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();
        }

        public Equipo getEquipo(String serie)
        {
            string sql = "SELECT * FROM public.equipo where numeroserie='" + serie + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            Equipo eq = new Equipo();

           
            foreach (DataRow row in n.dt.Rows)
            {

               eq.NOMBRE= row[1].ToString();
                eq.MODELO = row[2].ToString();
                eq.CODIGO = row[3].ToString();
                eq.NUMEROSERIE = row[4].ToString();
                eq.PITBULL = row[5].ToString();
                eq.HOROMETRO = int.Parse(row[6].ToString());
                eq.ANO = int.Parse(row[7].ToString());


                n.conn.Close();
                return eq;
            }


            n.conn.Close();
            return eq;

        }

        public List<Equipo> getEquipos()
        {
            string sql = "SELECT * FROM public.equipo";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            

            List<Equipo> lista = new List<Equipo>();
            foreach (DataRow row in n.dt.Rows)
            {
                Equipo eq = new Equipo();
                eq.NOMBRE = row[1].ToString();
                eq.MODELO = row[2].ToString();
                eq.CODIGO = row[3].ToString();
                eq.NUMEROSERIE = row[4].ToString();
                eq.PITBULL = row[5].ToString();
                eq.HOROMETRO = int.Parse(row[6].ToString());
                eq.ANO = int.Parse(row[7].ToString());


                n.conn.Close();
                lista.Add(eq);
            }


            n.conn.Close();
            return lista;

        }

    }
}
