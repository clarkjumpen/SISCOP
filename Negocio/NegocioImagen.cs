using Conexion;
using Modelo;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioImagen
    {

        public byte[] Image2Bytes(Image pImagen)
        {
            byte[] mImage = null;
            try
            {
                if (pImagen != null)
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        pImagen.Save(ms, pImagen.RawFormat);
                        mImage = ms.GetBuffer();
                        ms.Close();
                    }
                }
                else { mImage = null; }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return mImage;
        }
        public Byte[] Img2Bytes(String Ubicacion)
        {
            Byte[] Img2bytes;
            FileStream Fs = new FileStream(Ubicacion, FileMode.Open, FileAccess.Read);
            int LongByts = (int)Fs.Length;
            Img2bytes = new byte[LongByts];
            Fs.Read(Img2bytes, 0, (int)LongByts);
            return Img2bytes;
        }
        public Image Bytes2Imagen(byte[] ByteImg)
        {
            if (ByteImg == null) return null;
            MemoryStream MS = new MemoryStream(ByteImg);
            Bitmap Bm = null;
            try
            {
                Bm = new Bitmap(MS);
            }
            catch (Exception ex)
            {
            }
            return Bm;
        }

        public List<ImagenOrden> getImagenesOrden(String numeroOrden)
        {
            string sql = "SELECT * FROM imagenordentrabajo where ordentrabajo_numero_fk='" + numeroOrden + "'";

            Conn n = new Conn();
            n.command = new NpgsqlCommand(sql, n.conn);
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();


            n.conn.Open();
            n.da.Fill(n.dt);
            n.dr = n.command.ExecuteReader();


            List<ImagenOrden> lista = new List<ImagenOrden>();


           
            
                foreach (DataRow row in n.dt.Rows)
                {
                ImagenOrden img = new ImagenOrden();
                img.NUMEROORDEN = row[1].ToString();
                    img.DESCRIPCION = row[2].ToString();
                    img.NOMBREARCHIVO = row[3].ToString();
                    img.IMAGEN = (byte[])row[4];
                    lista.Add(img);
                }
            

            n.conn.Close();
            return lista;
        }

        public void agregarImagen(ImagenOrden i)
        {
            Conn n = new Conn();
            string sql = "INSERT INTO public.imagenordentrabajo(ordentrabajo_numero_fk, descripcion,nombrearchivo,imagen) VALUES(:orden,:descripcion,:nombrearchivo,:imagen)";
            n.command = new NpgsqlCommand(sql, n.conn);

            NpgsqlParameter pOrden = new NpgsqlParameter(":orden", NpgsqlDbType.Text);
            NpgsqlParameter pDescr = new NpgsqlParameter(":descripcion", NpgsqlDbType.Text);
            NpgsqlParameter pNomb = new NpgsqlParameter(":nombrearchivo", NpgsqlDbType.Text);
            NpgsqlParameter pImagen = new NpgsqlParameter(":imagen", NpgsqlDbType.Bytea);

            pOrden.Value = i.NUMEROORDEN;
            pDescr.Value = i.DESCRIPCION;
            pNomb.Value = i.NOMBREARCHIVO;
            pImagen.Value = i.IMAGEN;

            n.command.Parameters.Add(pOrden);
            n.command.Parameters.Add(pDescr);
            n.command.Parameters.Add(pNomb);
            n.command.Parameters.Add(pImagen);

            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }



        
        public void eliminarImagenesOrden(String numeroOrden)
        {
            Conn n = new Conn();
            string sql = "delete from public.imagenordentrabajo where ordentrabajo_numero_fk='"+numeroOrden+"'";
            n.command = new NpgsqlCommand(sql, n.conn);

           
            n.da = new NpgsqlDataAdapter(n.command);
            n.dt = new DataTable();

            n.conn.Open();
            n.command.ExecuteNonQuery();
            n.conn.Close();

        }

    }
}
