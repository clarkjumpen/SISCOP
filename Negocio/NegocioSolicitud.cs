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
    public class NegocioSolicitud
    {
        
        public void entregarRepuestoSolicitud(String numeroOrden)
        {

            string sql = "update solicitudrepuesto set estadosolicitudrepuesto_nombre_fk = 'ENTREGADO' where solicitud_numero_fk ='"+numeroOrden + "'";
            

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public void agregarSolicitudEgresoOrden(String fecha, String numeroOrden)
        {

            string sql = "INSERT INTO public.solicitudegreso(fechaegreso, ordentrabajo_numero_fk) VALUES('" 
                + fecha +"','"+ numeroOrden +"')";


            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();
       

    }

        public void eliminarSolicitudesRepuesto(String solicitud)
        {


            string sql = "delete from solicitudrepuesto where solicitud_numero_fk='"+solicitud+"'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();
            
            n.conn.Close();
           
        }

        public void solicitarRepuesto(String numeroOrden, String numeroSolicitud)
        {

            string sql = "UPDATE solicitudrepuesto set estadosolicitudrepuesto_nombre_fk='SOLICITADO' where solicitud_numero_fk='" + numeroSolicitud + "'";

        

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }


        public void desSolicitarRepuesto(String codigo, String prelude)
        {

            string sql = "UPDATE solicitudrepuesto set estadosolicitudrepuesto_nombre_fk='PENDIENTE' where muestra_codigo_fk='" + codigo + "' and muestra_codigoprelude_fk='" + prelude + "'";



            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }
        public Double getLastIdSolicitud()
        {
            string sql = "SELECT max(numero) FROM solicitud";

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

        public Double getNumeroOrdendeSolicitud(String num)
        {
            string sql = "select numero from solicitud where ordentrabajo_numero_fk ='" + num + "'";

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

        public List<Solicitud> getSolicitudes(String numeroOrden)
        {
            string sql = "SELECT * from solicitud where ordentrabajo_numero_fk='" + numeroOrden + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();

            List<Solicitud> lista = new List<Solicitud>();
            Solicitud s = new Solicitud();
            foreach (DataRow row in n.dt.Rows)
            {
                s.FECHA = row[1].ToString();
                s.USUARIO_RUT = row[2].ToString();
                s.ORDENTRABAJO_NUMERO = row[3].ToString();
                s.NUMERO = row[4].ToString();
                lista.Add(s);
            }


            n.conn.Close();
            return lista;
        }

        public void agregarSolicitud(Solicitud s)
        {

            string sql = "INSERT INTO public.solicitud(fechaingreso, usuario_rut_fk, ordentrabajo_numero_fk,numero) VALUES('" + s.FECHA + "','"
            + s.USUARIO_RUT + "','"
            + s.ORDENTRABAJO_NUMERO + "','"
            + s.NUMERO + "')";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();
        }
        public void agregarSolicitudRepuesto(String numero, Repuesto r)
        {

            string sql = "INSERT INTO public.solicitudrepuesto(muestra_codigo_fk, muestra_codigoprelude_fk, solicitud_numero_fk, descripcion, cantidad, valorclp, estadosolicitudrepuesto_nombre_fk) VALUES('"
            + r.CODIGO + "','"
            + r.CODIGOPRELUDE + "','"
            + numero + "','"
            + r.DESCRIPCION + "',"
            + r.CANTIDAD + ",'"
            + r.VALORCLP + "','"
            + r.ESTADO +"')";

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
