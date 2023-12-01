using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD2ASamylly.DAL;
using System.Data;
using CRUD2ASamylly.Model;

namespace CRUD2ASamylly.BLL
{
    public class PessoaBLL
    {
        PessoaDAL pessoaDAL = new PessoaDAL();

        //metodo para salvar 
        public void Salvar(Pessoa pessoa)
        {
            try
            {
                pessoaDAL.Salvar(pessoa);
            }
            catch (Exception erro) 
            {
                throw erro;
            }
        }

        //metodo para listar

        public DataTable Listar()
        {
          try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAL.Listar();
                return dt;
            }
            catch (Exception erro) 
            {
                throw erro;
            }
        }
           

    }
}
