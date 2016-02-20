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
    public class NegocioCuenta
    {
        public List<Cuenta> getListaCuentas()
        {
            string sql = "SELECT nombre, numero FROM cuenta order by numero asc";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Cuenta> lista = new List<Cuenta>();



            foreach (DataRow row in n.dt.Rows)
            {
                Cuenta c = new Cuenta();

                c.NOMBRE = row[0].ToString();
                c.NUMERO = row[1].ToString();

                lista.Add(c);
            }


            n.conn.Close();
            return lista;
        }


        public string getNombreCuenta(string numeroCuenta)
        {
            string sql = "SELECT nombre FROM cuenta where numero='" + numeroCuenta + "'";

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
                return  row[0].ToString();

           
            }


            n.conn.Close();
            return "";
        }
    }
}
