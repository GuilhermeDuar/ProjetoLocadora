﻿using Entities;
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
    public class FuncionarioDAL : IFuncionarioService
    {
        public SingleResponse<Funcionario> Authenticate(string email, string senha)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM FUNCIONARIOS WHERE EMAIL = @EMAIL AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);

            SingleResponse<Funcionario> response = new SingleResponse<Funcionario>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    f.ID = Convert.ToInt32(reader["ID"]);
                    f.Nome = reader["NOME"].ToString();
                    f.Email = reader["EMAIL"].ToString();
                    response.Success = true;
                    response.Message = "Autenticação realizada com sucesso.";
                    response.item = f;
                    return response;
                }
                response.Success = false;
                response.Message = "Usuário e/ou senha inválidos.";
                return response;
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate um administrador.";
                return response;
            }
            finally
            {
                connection.Dispose();
            }

        }
        
    }
}
