using Conexion;
using Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Drawing;
using NpgsqlTypes;

namespace Negocio
{
    public class NegocioOrdenTrabajo
    {

       
        public List<String> getPrioridades()
        {
            string sql = "SELECT nombre FROM prioridadordentrabajo order by nombre asc";

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

        public bool existeOrden(String numero)
        {
            string sql = "SELECT * from ordentrabajo where numero='"+numero+"'";

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
        public List<String> getEstados()
        {
            string sql = "SELECT nombre FROM estadoordentrabajo order by nombre asc";

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
        
        public List<String> getCategorias(String tipo)
        {
            string sql = "SELECT nombre FROM categoriaordentrabajo where tipoordentrabajo_nombre_fk='"+tipo +"' order by nombre asc";

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

        public List<String> getCategorias()
        {
            string sql = "SELECT nombre FROM categoriaordentrabajo order by nombre asc";

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

        
        public List<Repuesto> getRepuestosSolicitud(String numeroSolicitud)
        {
            string sql = "SELECT * FROM solicitudrepuesto where solicitud_numero_fk='" + numeroSolicitud + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<Repuesto> lista = new List<Repuesto>();


          

            foreach (DataRow row in n.dt.Rows)
            {
                Repuesto r = new Repuesto();
                r.CODIGO = row[1].ToString();
               r.CODIGOPRELUDE = row[2].ToString();
               r.DESCRIPCION = row[4].ToString();
                r.CANTIDAD =int.Parse(row[5].ToString());
                r.VALORCLP = Double.Parse(row[6].ToString());
                r.ESTADO = row[7].ToString();
                lista.Add(r);
            }


            n.conn.Close();
            return lista;



        }
        

        

        public Orden getOrden(String numero)
        {
            string sql = "select * from ordentrabajo where numero='" + numero + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            Orden o = new Orden();
            

            foreach (DataRow row in n.dt.Rows)
            {
                o.NUMERO = row[1].ToString();
                o.FECHAINICIO = row[2].ToString();
                o.USUARIO_RUT=row[3].ToString();
                o.CLIENTE= row[4].ToString();
                o.PRIORIDAD= row[5].ToString();
                o.VALORTOTALCLP= Double.Parse(row[6].ToString());
                o.VALORTOTALUSD= Double.Parse(row[7].ToString());
                o.VALORDOLAR= Double.Parse(row[8].ToString());
                o.MANODEOBRA= row[9].ToString();
                o.TRABAJOTERCEROS= row[10].ToString();
                o.ENCARGADO= row[11].ToString();
                o.CATEGORIA= row[12].ToString();
                o.TIPOORDENTRABAJO= row[13].ToString();
                o.EQUIPO= row[14].ToString();
                o.ESTADOORDENTRABAJO= row[15].ToString();
                o.FECHATERMINO= row[15].ToString();
                
            }


            n.conn.Close();
            return o;


        }

        public DataTable getListaOrdenes()
        {
            string sql = "select * from estadoordenes";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

          


            n.conn.Close();
            return n.dt;


        }
        public void agregarOrden(Orden o)//PRIMERO INGRESAR EQUIPO luego imagenes 
        {
            string sql = "INSERT INTO public.ordentrabajo(numero, fechainicio, usuario_rut_fk, cliente_rut_fk,"
            +"prioridadordentrabajo_nombre_fk, valortotalclp, valortotalusd," 
            +"valordolar, encargado," 
            +"categoriaordentrabajo_nombre_fk, tipoordentrabajo_nombre_fk,"
            +"estadoordentrabajo_nombre_fk, fechatermino) VALUES('" + o.NUMERO + "','"
                                                                            + o.FECHAINICIO + "','"
                                                                            + o.USUARIO_RUT + "','"
                                                                            + o.CLIENTE + "','"
                                                                            + o.PRIORIDAD + "',"
                                                                            + o.VALORTOTALCLP + ","
                                                                            + o.VALORTOTALUSD + ","
                                                                            + o.VALORDOLAR + ",'"
                                                                            + o.ENCARGADO + "','"
                                                                            + o.CATEGORIA + "','"
                                                                            + o.TIPOORDENTRABAJO + "','"
                                                                            + o.ESTADOORDENTRABAJO + "','"
                                                                            + o.FECHATERMINO + "')";



            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public void modificarOrdenEquipo(Orden o)
        {
            string sql =" UPDATE ordentrabajo SET fechainicio ='"+o.FECHAINICIO+"',"+
                        " usuario_rut_fk ='"+o.USUARIO_RUT+"'," +
                        " cliente_rut_fk ='"+o.CLIENTE+"'," +
                        " prioridadordentrabajo_nombre_fk ='"+o.PRIORIDAD+"'," +
                        " valortotalclp ="+o.VALORTOTALCLP+"," +
                        " valortotalusd ="+o.VALORTOTALUSD+"," +
                        " valordolar ="+o.VALORDOLAR+"," +
                        " manodeobra ='"+o.MANODEOBRA+"'," +
                        " trabajoterceros = '"+o.TRABAJOTERCEROS+"'," + 
                        " encargado ='"+o.ENCARGADO+"'," +
                        " categoriaordentrabajo_nombre_fk ='"+o.CATEGORIA+"'," +
                        " tipoordentrabajo_nombre_fk ='"+o.TIPOORDENTRABAJO+"'," +
                        " equipo_numeroserie_fk ='"+o.EQUIPO+"'," +
                        " estadoordentrabajo_nombre_fk ='"+o.ESTADOORDENTRABAJO+"'," +
                        " fechatermino = '"+o.FECHATERMINO+"' WHERE numero='"+o.NUMERO+"'";



            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }
        public void modificarOrdenServicio(Orden o)
        {
            string sql = " UPDATE ordentrabajo SET fechainicio ='" + o.FECHAINICIO + "'," +
                        " usuario_rut_fk ='" + o.USUARIO_RUT + "'," +
                        " cliente_rut_fk ='" + o.CLIENTE + "'," +
                        " prioridadordentrabajo_nombre_fk ='" + o.PRIORIDAD + "'," +
                        " valortotalclp =" + o.VALORTOTALCLP + "," +
                        " valortotalusd =" + o.VALORTOTALUSD + "," +
                        " valordolar =" + o.VALORDOLAR + "," +
                        " manodeobra ='" + o.MANODEOBRA + "'," +
                        " trabajoterceros = '" + o.TRABAJOTERCEROS + "'," +
                        " encargado ='" + o.ENCARGADO + "'," +
                        " categoriaordentrabajo_nombre_fk ='" + o.CATEGORIA + "'," +
                        " tipoordentrabajo_nombre_fk ='" + o.TIPOORDENTRABAJO + "'," +
                        " estadoordentrabajo_nombre_fk ='" + o.ESTADOORDENTRABAJO + "'," +
                        " fechatermino = '" + o.FECHATERMINO + "' WHERE numero='" + o.NUMERO + "'";



            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }
        public List<String> getTipoOrdenes()
        {


            string sql = "SELECT nombre FROM tipoordentrabajo";

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

        public String getTipoOrden(String numero)
        {


            string sql = "select tipoordentrabajo_nombre_fk from ordentrabajo where numero='"+ numero+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            String nombre = "";
            foreach (DataRow row in n.dt.Rows)
            {
                 nombre = row[0].ToString();

                           }


            n.conn.Close();
            return nombre;
        }

        public Double getNumeroOrden()
        {
            string sql = "SELECT max(numero) FROM ordentrabajo";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            String numero = "";
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
