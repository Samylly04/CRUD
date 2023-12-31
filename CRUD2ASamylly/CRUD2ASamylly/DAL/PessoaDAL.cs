﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CRUD2ASamylly.Model;
using System.Data;

namespace CRUD2ASamylly.DAL
{
    public class PessoaDAL : Conexão
    {
        MySqlCommand comando = null;

        //método para salvar
        public void Salvar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO pessoa (nome, nascimento, sexo, " +
                    "cpf, celular, endereco, bairro, cidade, estado, cep) VALUES (@nome," +
                    "@nascimento, @sexo, @cpf, @celular, @endereco, @bairro, @cidade, @estado, @cep)", conexao);

                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@nascimento", DateTime.Parse(pessoa.Nascimento).ToString());
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.Estado);
                comando.Parameters.AddWithValue("@cep", pessoa.Cep);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //metodo para listar
        public DataTable Listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM pessoa ORDER BY nome", conexao);
                da.SelectCommand= comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
