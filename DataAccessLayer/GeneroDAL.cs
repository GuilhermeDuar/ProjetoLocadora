using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer // UpDate set nome = '' where id = 999
{
    public class GeneroDAL : IGeneroService
    {
        public Response Insert(Genero g)
        {
            //ADO.NET -> frameWork de acesso a dados(performace e controle)
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand("INSERT INTO GENEROS (NOME) VALUES (@NOME)", connection);
            command.Parameters.AddWithValue("@NOME", g.Nome);

            Response r = new Response();
            try
            {
                connection.Open(); 
                command.ExecuteNonQuery();
                r.Message = "Gênero cadastrado  com sucesso.";
                r.Success = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Success = false;
                if (ex.Message.Contains("UQ__GENEROS__E2AB1FF4AEE7B9C4"))
                {
                    r.Message = "Gênero já cadastrado.";
                    return r;
                }
                r.Message = "Erro no banco de dados, contate o administrador.";
                return r;
            }
            finally // poderoso - sobre estcreve ate o return
            {
                connection.Dispose(); // so fecha se estiver aberta 
            }
        }

        public DataResponse<Genero> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand("SELECT * FROM GENEROS ORDER BY ID", connection);

            DataResponse<Genero> resposta = new DataResponse<Genero>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); // responsavel por ler o select
                List<Genero> listGeneros = new List<Genero>();

                while (reader.Read()) // cada loop, aponta para um registro retornado pelo select
                {
                    Genero genero = new Genero();

                    genero.ID = Convert.ToInt32(reader["ID"]);
                    genero.Nome = Convert.ToString(reader["NOME"]);

                    listGeneros.Add(genero);
                }
                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso.";
                resposta.Data = listGeneros;
                return resposta;
            }
            catch (Exception)
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<Genero>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response UpDate(Genero g)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand("UPADATE GENEROS SET NOME = @NOME WHERE ID = @ID", connection);
            command.Parameters.AddWithValue("@NOME", g.Nome);
            command.Parameters.AddWithValue("@ID", g.ID);


            Response r = new Response();
            try
            {
                connection.Open(); // sempre no final para não pesar o sistema 
                command.ExecuteNonQuery();
                r.Message = "Gênero editado  com sucesso.";
                r.Success = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Success = false;
                if (ex.Message.Contains("UQ__GENEROS__E2AB1FF4AEE7B9C4"))
                {
                    r.Message = "Falha ao alterar gênero, tente novamente.";
                    return r;
                }
                r.Message = "Erro no banco de dados, contate o administrador.";
                return r;
            }
            finally // poderoso - sobre estcreve ate o return
            {
                connection.Dispose(); // so fecha se estiver aberta 
            }
        }

        public Response Delete(int id)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand("DELETE FROM GENEROS WHERE ID = @ID", connection);
            command.Parameters.AddWithValue("@ID", id);


            Response r = new Response();
            try
            {
                connection.Open(); // sempre no final para não pesar o sistema 
                command.ExecuteNonQuery();
                r.Message = "Gênero excluido  com sucesso.";
                r.Success = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Success = false;
                if (ex.Message.Contains("FK__FILMES__GENERO"))
                {
                    r.Message = "Gênero não pode ser excluido, pois existem filmes vinculados a ele.";
                    return r;
                }
                r.Message = "Erro no banco de dados, contate o administrador.";
                return r;
            }
            finally // poderoso - sobre estcreve ate o return
            {
                connection.Dispose(); // so fecha se estiver aberta 
            }
        }




    }
}
