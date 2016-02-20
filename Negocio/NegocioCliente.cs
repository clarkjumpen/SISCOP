using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Conexion;
using Npgsql;
using System.Data;

namespace Negocio
{
    public class NegocioCliente
    {
        public Cliente getCliente(string rut)
        {
            string sql = "SELECT * FROM cliente WHERE cliente.rut ='" + rut + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Cliente u = new Cliente();
            while (n.dr.Read())
            {
                foreach (DataRow row in n.dt.Rows)
                {

                    u.NOMBRE = row[1].ToString();
                    u.RUT = row[2].ToString();
                    u.DIRECCION = row[3].ToString();
                    u.CONTACTO = row[4].ToString();
                    u.CARGO = row[5].ToString();
                    u.FONO = row[6].ToString();
                   u.EMAIL= row[7].ToString();

                }
            }
            n.conn.Close();
            return u;
        }

        public List<Cliente> getClientes()
        {
            string sql = "SELECT * FROM cliente";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Cliente> lista = new List<Cliente>();



            foreach (DataRow row in n.dt.Rows)
            {
                Cliente u = new Cliente();

                u.NOMBRE = row[1].ToString();
                u.RUT = row[2].ToString();
                u.DIRECCION = row[3].ToString();
                u.CONTACTO = row[4].ToString();
                u.CARGO = row[5].ToString();
                u.FONO = row[6].ToString();
                u.EMAIL = row[7].ToString();

                lista.Add(u);
            }


            n.conn.Close();
            return lista;
        }

        
      

        public void agregarCliente(Cliente u)
        {
            string sql = "INSERT INTO cliente(nombre, rut, direccion, contacto, cargo, fono, email)"
                + "VALUES('" + u.NOMBRE + "','"
                            + u.RUT + "','"
                            + u.DIRECCION + "','"
                            + u.CONTACTO + "','"
                            + u.CARGO + "','"
                            + u.FONO + "','"
                            + u.EMAIL + "')";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public void modificarCliente(Cliente u)
        {
            string sql = "UPDATE cliente SET"
                + " nombre ='" + u.NOMBRE
                + "', direccion ='" + u.DIRECCION
                + "', contacto ='" + u.CONTACTO
                + "', cargo ='" + u.CARGO 
                + "', fono ='"+ u.FONO
                + "', email ='" +u.EMAIL+"' WHERE rut='" + u.RUT + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

       
        public void eliminarCliente(String rut)
        {
            string sql = "DELETE FROM cliente WHERE rut='" + rut + "'";

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

