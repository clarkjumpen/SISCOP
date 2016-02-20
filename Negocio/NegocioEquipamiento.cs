using Conexion;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioEquipamiento
    {

        public List<String> getListaEquipamiento()
        {
            string sql = "SELECT nombre FROM tipoequipamiento order by nombre asc";

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
    }
}
