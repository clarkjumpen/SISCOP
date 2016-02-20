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
    public class NegocioMuestra
    {

        public Double getValorPromedioPrelude(String codigo)
        {
            string sql = "SELECT valor_promedio FROM public.muestr_exist_prom where codigo_prelude='"+codigo+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Object[]> lista = new List<Object[]>();

            Double d = new Double();
            foreach (DataRow row in n.dt.Rows)
            {
              
                d = Double.Parse(row[0].ToString());


                n.conn.Close();
                return d;
            }


            n.conn.Close();
            return d;

        }

        public Double getValorPromedioMcelroy(String codigo)
        {
            string sql = "SELECT valor_promedio FROM public.muestr_exist_prom where codigo_mcelroy='" + codigo + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Object[]> lista = new List<Object[]>();

            Double d = new Double();
            foreach (DataRow row in n.dt.Rows)
            {

                d = Double.Parse(row[0].ToString());


                n.conn.Close();
                return d;
            }


            n.conn.Close();
            return d;

        }
        public String getFechaServidor()
        {
            string sql = "SELECT current_time";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            String fecha = "";

            foreach (DataRow row in n.dt.Rows)
            {
                fecha = row[0].ToString();
            }

            n.conn.Close();
            return fecha;

        }

        public bool hayProductoEnMuestra(Producto p)
        {
            string sql = "SELECT codigo_mcelroy, codigo_prelude FROM public.muestr_exist_prom  where codigo_mcelroy='" + p.CODIGOMC + "' OR codigo_prelude='" + p.CODIGOPRELUDE + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();




            
                foreach (DataRow row in n.dt.Rows)
                {

                    if ((p.CODIGOMC.Equals(row[0].ToString()) || p.CODIGOPRELUDE.Equals(row[1].ToString())))
                    {
                        n.conn.Close();
                        return true;

                    }

                }
            
            n.conn.Close();
            return false;

        }

        public List<Object[]> getAllExistencias()
        {
            string sql = "SELECT * FROM muestr_exist_prom";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Object[]> lista = new List<Object[]>();


            foreach (DataRow row in n.dt.Rows)
            {
                Object[] ob = new Object[11];
                ob[0] = row[0].ToString();
                ob[1] = row[1].ToString();
                ob[2] = row[2].ToString();
                ob[3] = row[3].ToString();
                ob[4] = row[4].ToString();
                ob[5] = row[5].ToString();
                ob[6] = row[6].ToString();
                ob[7] = row[7].ToString();
                ob[8] = row[8].ToString();



                lista.Add(ob);
            }


            n.conn.Close();
            return lista;

        }

        public List<Object[]> getAllActivos()
        {
            string sql = "SELECT * FROM muestr_activ_prom";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Object[]> lista = new List<Object[]>();


            foreach (DataRow row in n.dt.Rows)
            {
                Object[] ob = new Object[11];
                ob[0] = row[0].ToString();
                ob[1] = row[1].ToString();
                ob[2] = row[2].ToString();
                ob[3] = row[3].ToString();
                ob[4] = row[4].ToString();
                ob[5] = row[5].ToString();
                ob[6] = row[6].ToString();
                ob[7] = row[7].ToString();
                ob[8] = row[8].ToString();



                lista.Add(ob);
            }


            n.conn.Close();
            return lista;

        }
        public List<Muestra> getMuestras(Producto p) {
            string sql = "";

            if (p.CODIGOMC.Equals(""))
            {
                sql = "SELECT * FROM muestra where producto_codigoprelude_fk='" + p.CODIGOPRELUDE + "'";

            }
            if (p.CODIGOPRELUDE.Equals(""))
            {
                sql = "SELECT * FROM muestra where producto_codigo_fk='" + p.CODIGOPRELUDE + "'";

            }
            if (!p.CODIGOPRELUDE.Equals("") && !p.CODIGOMC.Equals(""))
            {
               sql = "SELECT * FROM muestra where producto_codigo_fk='" + p.CODIGOMC + "' OR producto_codigoprelude_fk='" + p.CODIGOPRELUDE + "'";
               
            }
            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Muestra> lista = new List<Muestra>();
            

            foreach (DataRow row in n.dt.Rows)
            {
                Muestra m = new Muestra();
                m.VALORINGRESOCLP = double.Parse(row[3].ToString());
                m.FECHAINGRESO = (DateTime) row[4];
                m.ESTADO = row[9].ToString();
                m.CANTIDAD = int.Parse(row[10].ToString());
                m.BODEGA = row[11].ToString();


                lista.Add(m);
            }


            n.conn.Close();
            return lista;

        }
        public void agregarMuestra(Producto p,Muestra e)
        {
            string sql = "INSERT INTO muestra(producto_codigo_fk, producto_codigoprelude_fk, valoringresoclp, fechaingreso, estado_nombre_fk,cantidad,bodega_nombre_fk)"
                + "VALUES('" + p.CODIGOMC + "','"
                            + p.CODIGOPRELUDE + "',"
                            + e.VALORINGRESOCLP + ",current_date,'NEW',"
                            + e.CANTIDAD +",'"
                            + e.BODEGA+"')";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

       

        public double calcularPromedio(List<double> valores)
        {
            double total = 0;
            foreach (double valor in valores)
            {
                total = total + valor;
            }
            double promedio = (total / valores.Count());

                return promedio;
        }

       
    }
}
