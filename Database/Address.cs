using Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Address
    {
        private string connection = "";

        public Address()
        {
            connection = ConnectionString.Connection;
        }

        public void Save(int id, string publicPlace, int number, string complement, string city, string district, char uf, string cep, int idPerson)
        {

            string script = @"INSERT INTO Enderecos VALUES(@PublicPlace, @Number, @Complement, @City, @District, @Uf, @Cep, @IdPerson)";

            if (id != 0)
                script = "";
           
            using (SqlConnection conn = new SqlConnection(connection))
            {
                
                SqlCommand cmd = new SqlCommand(script, conn);

                cmd.Parameters.Add("@PublicPlace", SqlDbType.VarChar);
                cmd.Parameters["@PublicPlace"].Value = publicPlace;

                cmd.Parameters.Add("@Number", SqlDbType.Int);
                cmd.Parameters["@Number"].Value = number;

                cmd.Parameters.Add("@Complement", SqlDbType.VarChar);
                cmd.Parameters["@Complement"].Value = complement;

                cmd.Parameters.Add("@City", SqlDbType.VarChar);
                cmd.Parameters["@City"].Value = city;

                cmd.Parameters.Add("@District", SqlDbType.VarChar);
                cmd.Parameters["@District"].Value = district;

                cmd.Parameters.Add("@Uf", SqlDbType.Char);
                cmd.Parameters["@Uf"].Value = uf;

                cmd.Parameters.Add("@Cep", SqlDbType.VarChar);
                cmd.Parameters["@Cep"].Value = cep;

                cmd.Parameters.Add("@IdPerson", SqlDbType.Int);
                cmd.Parameters["@IdPerson"].Value = idPerson;

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
