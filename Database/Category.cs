using Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Category
    {
        private string connString = "";

        public Category()
        {
            connString = ConnectionString.Connection;
        }

        public int Save(string name, string description)
        {
            int id = 0;
            string script = @"INSERT INTO Categorias VALUES (@Nome, @Descricao, @Data);" +
                               "SELECT CAST(scope_identity() AS int)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(script, conn);
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = name;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = description;

                cmd.Parameters.Add("@Data", SqlDbType.VarChar);
                cmd.Parameters["@data"].Value = DateTime.Now;
                try
                {
                    conn.Open();
                    id = (int)cmd.ExecuteScalar();
                }
                catch (Exception erro)
                {
                    Message.Take(erro.Message);
                }
            }
            return (int)id;
        }



        public DataTable List()
        {
            int id = 0;
            return List(string.Empty, id);
        }

        public DataTable List(int id)
        {
            return List(string.Empty, id);
        }

        public DataTable List(string name, int id)
        {
            DataTable table = new DataTable();

            string script = @"SELECT * FROM Categorias ORDER BY nome";

            if (!string.IsNullOrEmpty(name))
                script = @"SELECT * FROM Categorias WHERE nome LIKE '% @Nome %' ORDER BY nome";

            if (id != 0)
                script = @"SELECT * FROM Categorias WHERE id = @id";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(script, conn);

                if (id != 0)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters["@id"].Value = id;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = name;
                }

                try
                {
                    conn.Open();

                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(table);
                    }
                }
                catch (Exception erro)
                {
                    Message.Take(erro.Message);
                }
            }
            return table;
        }

        public void Alter(int id, string name, string description)
        {
            string script = @"UPDATE Categorias SET nome = @Nome, descricao = @Descricao WHERE id = @Id";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(script, conn);

                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = name;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = description;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    Message.Take(erro.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string script = @"DELETE FROM Categorias WHERE id = @id";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(script, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    Message.Take(erro.Message);
                }
            }
        }
    }
}
