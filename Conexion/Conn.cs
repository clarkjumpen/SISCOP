using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Conexion
{
    public class Conn
    {

        public Conn()
        {
            this.configurarConexion();
        }

        public String str;
        public NpgsqlConnection conn;
        public NpgsqlCommand command;
        public NpgsqlDataAdapter da;
        public DataTable dt;
        public NpgsqlDataReader dr;

        private String server, port, user, password, database;

        public void configurarConexion()
        {
            this.server = "127.0.0.1";
            this.port = "5432";
            this.user = "postgres";
            this.password = "siscop";
            this.database = "siscop";

            this.conn = new NpgsqlConnection("Server=" + this.server +
                                             ";Port=" + this.port +
                                             ";User Id=" + this.user +
                                             ";Password=" + this.password +
                                             ";Database=" + this.database + ";Pooling=false");


        }
        

    }
}
