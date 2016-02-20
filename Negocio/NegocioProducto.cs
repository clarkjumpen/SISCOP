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
    public class NegocioProducto
    {
        public List<Producto> getListaTodosProductos()
        {
            string sql = "SELECT * FROM producto";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Producto> lista = new List<Producto>();



            foreach (DataRow row in n.dt.Rows)
            {
                Producto p = new Producto();
                p.PROVEEDOR_NOMBRE = row[1].ToString();
                p.NOMBRE = row[2].ToString();
                p.CUENTA = row[4].ToString();
                p.TIPOEQUIPAMIENTO_NOMBRE = row[5].ToString();
                p.CODIGOMC = row[6].ToString();
                p.CODIGOPRELUDE = row[7].ToString();

                lista.Add(p);
            }


            n.conn.Close();
            return lista;
        }
        public bool existeProducto(string codigoMcelroy, string codigoPrelude)
        {
            string sql = "SELECT codigo,codigoprelude from producto";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


           
                foreach (DataRow row in n.dt.Rows)
                {
                    if ((codigoMcelroy.Equals("") && codigoPrelude.Equals(row[1].ToString())))
                    {

                        n.conn.Close();
                        return true;

                    }
                    if ((codigoMcelroy.Equals(row[0].ToString()) && codigoPrelude.Equals("")))
                    {

                        n.conn.Close();
                        return true;

                    }
                    if ((codigoMcelroy.Equals(row[0].ToString()) && codigoPrelude.Equals(row[1].ToString())))
                    {

                        n.conn.Close();
                        return true;

                    }

                
            }
            n.conn.Close();
            return false;
        }


        public void agregarProducto(Producto p)
        {
            string sql = "INSERT INTO producto(proveedor_nombre_fk, nombre, cuenta_numero_fk, tipoequipamiento_nombre_fk, codigo, codigoprelude)"
                + "VALUES('" + p.PROVEEDOR_NOMBRE + "','"
                            + p.NOMBRE + "','"
                            + p.CUENTA + "','"
                            + p.TIPOEQUIPAMIENTO_NOMBRE + "','"
                            + p.CODIGOMC + "','"
                            + p.CODIGOPRELUDE + "')";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public int getIdProductoMc(String codigoMc)
        {
            string sql = "SELECT producto_id FROM producto WHERE codigo ='" + codigoMc + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            int id = 0;

            foreach (DataRow row in n.dt.Rows)
            {

                id = int.Parse(row[0].ToString());



            }

            n.conn.Close();
            return id;
        }

        public int getIdProductoPrelude(String codigoPrelude)
        {
            string sql = "SELECT producto_id FROM producto WHERE codigoprelude ='" + codigoPrelude + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            int id = 0;

            foreach (DataRow row in n.dt.Rows)
            {

                id = int.Parse(row[0].ToString());



            }

            n.conn.Close();
            return id;
        }
        public void modificarProducto(Producto p, int idProducto)
        {
            string sql = "UPDATE producto SET "
                + "proveedor_nombre_fk ='" + p.PROVEEDOR_NOMBRE + "',"
                + " nombre ='" + p.NOMBRE + "',"
                + " cuenta_numero_fk ='" + p.CUENTA + "',"
                + " tipoequipamiento_nombre_fk ='" + p.TIPOEQUIPAMIENTO_NOMBRE + "',"
                + " codigo ='" + p.CODIGOMC + "',"
                + " codigoprelude ='" + p.CODIGOPRELUDE + "' where producto_id =" + idProducto;

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

        public Producto getProductoMcelroy(String nombre, String codigo)
        {
            string sql = "SELECT * FROM producto WHERE nombre LIKE '%" + nombre + "%' and codigo = '" + codigo + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Producto p = new Producto();
            
                foreach (DataRow row in n.dt.Rows)
                {

                    p.PROVEEDOR_NOMBRE = row[1].ToString();
                    p.NOMBRE = row[2].ToString();
                    p.CUENTA = row[4].ToString();
                    p.TIPOEQUIPAMIENTO_NOMBRE = row[5].ToString();
                    p.CODIGOMC = row[6].ToString();
                    p.CODIGOPRELUDE = row[7].ToString();


                }
            
            n.conn.Close();
            return p;
        }
       
        public Producto getProductoPrelude(String nombre, String codigo)
        {
            string sql = "SELECT * FROM producto WHERE nombre LIKE '%" + nombre + "%' and codigoprelude = '" + codigo + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Producto p = new Producto();
           
                foreach (DataRow row in n.dt.Rows)
                {

                    p.PROVEEDOR_NOMBRE = row[1].ToString();
                    p.NOMBRE = row[2].ToString();
                    p.CUENTA = row[4].ToString();
                    p.TIPOEQUIPAMIENTO_NOMBRE = row[5].ToString();
                    p.CODIGOMC = row[6].ToString();
                    p.CODIGOPRELUDE = row[7].ToString();


                }
            
            n.conn.Close();
            return p;
        }
        public Producto getProductoMcelroy(String codigo)
        {
            string sql = "SELECT * FROM producto WHERE codigo = '" + codigo + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Producto p = new Producto();
           
                foreach (DataRow row in n.dt.Rows)
                {

                    p.PROVEEDOR_NOMBRE = row[1].ToString();
                    p.NOMBRE = row[2].ToString();
                    p.CUENTA = row[4].ToString();
                    p.TIPOEQUIPAMIENTO_NOMBRE = row[5].ToString();
                    p.CODIGOMC = row[6].ToString();
                    p.CODIGOPRELUDE = row[7].ToString();


                }
            
            n.conn.Close();
            return p;
        }
        public Producto getProductoPrelude(String codigo)
        {
            string sql = "SELECT * FROM producto WHERE codigoprelude = '" + codigo + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Producto p = new Producto();
            
                foreach (DataRow row in n.dt.Rows)
                {

                    p.PROVEEDOR_NOMBRE = row[1].ToString();
                    p.NOMBRE = row[2].ToString();
                    p.CUENTA = row[4].ToString();
                    p.TIPOEQUIPAMIENTO_NOMBRE = row[5].ToString();
                    p.CODIGOMC = row[6].ToString();
                    p.CODIGOPRELUDE = row[7].ToString();


                }
            
            n.conn.Close();
            return p;
        }
        public void eliminarProducto(int idProd)
        {

            string sql = "DELETE FROM producto WHERE producto_id=" + idProd + "";

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
