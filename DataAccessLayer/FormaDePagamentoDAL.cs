using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FormaDePagamentoDAL : IFormaDePagamentoService
    {
        public Response Insert(FormaDePagamento fp)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand("INSERT INTO FORMAS_PAGAMENTO (DESCRICAO) VALUES (@DESCRICAO)", connection);
            command.Parameters.AddWithValue("@DESCRICAO", fp.Descricao);

            Response response = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Message = "Forma de pagamento cadastrada com sucesso.";
                response.Success = true;
                return response;
            }
            catch (Exception exception)
            {
                response.Success = false;
                if (exception.Message.Contains("UQ__FORMAS_P__57EDBE3C523F1F9A"))
                {
                    response.Message = "Forma de pagamento já cadastrado.";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate um administrador.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }

        }
        public DataResponse<FormaDePagamento> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM FORMAS_PAGAMENTO ORDER BY ID";

            DataResponse<FormaDePagamento> resposta = new DataResponse<FormaDePagamento>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                List<FormaDePagamento> listPagamentos = new List<FormaDePagamento>();

                while (reader.Read())
                {
                    FormaDePagamento fp = new FormaDePagamento();

                    fp.ID = Convert.ToInt32(reader["ID"]);
                    fp.Descricao = Convert.ToString(reader["DESCRICAO"]);

                    listPagamentos.Add(fp);
                }
                resposta.Success = true;
                resposta.Message = "Dados selecionados com sucesso.";
                resposta.Data = listPagamentos;
                return resposta;
            }
            catch (Exception )
            {
                resposta.Success = false;
                resposta.Message = "Erro no banco de dados, contate o administrador.";
                resposta.Data = new List<FormaDePagamento>();
                return resposta;
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response UpDate(FormaDePagamento fp)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING); 

            SqlCommand command = new SqlCommand("UPDATE FORMAS_PAGAMENTO SET DESCRICAO = @DESCRICAO WHERE ID = @ID ", connection);
            command.Parameters.AddWithValue("@DESCRICAO", fp.Descricao);
            command.Parameters.AddWithValue("@ID", fp.ID);

            Response r = new Response();
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                r.Message = "Update realizado com sucesso.";
                r.Success = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Success = false;
                if (ex.Message.Contains("UQ__FORMAS_P__57EDBE3C523F1F9A"))
                {
                    r.Message = "Falha ao realizar o update, tente novamente.";
                    return r;
                }
                r.Message = "Erro no banco de dados, contate o administrador.";
                return r;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Delete(int id)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM FORMAS_PAGAMENTO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);


            Response r = new Response();
            try
            {
                connection.Open(); 
                command.ExecuteNonQuery();
                r.Message = "Forma de pagamento excluido com sucesso.";
                r.Success = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Success = false;
                if (ex.Message.Contains("FK__LOCACOES__FORMAP__36B12243"))
                {
                    r.Message = "Forma de pagamento não pode ser excluido, pois existem filmes vinculados a ele.";
                    return r;
                }
                r.Message = "Erro no banco de dados, contate o administrador.";
                return r;
            }
            finally 
            {
                connection.Dispose();  
            }
        }
    }
}
