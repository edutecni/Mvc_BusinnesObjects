using Mvc_BusinnesObjects.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BusinnesObjects.Models
{
    public class AlunoBLL : IAlunoBLL
    {
        public List<Aluno> GetAlunos()
        {
                
            var conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Escola;Integrated Security=True";
            
            List<Aluno> alunos = new List<Aluno>();

            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("GetAlunos", con);
                    //SqlCommand cmd = new SqlCommand("Select * from Alunos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.AlunoId = Convert.ToInt32(dr["AlunoId"]);
                        aluno.Nome = dr["Nome"].ToString();
                        aluno.Sexo = dr["Sexo"].ToString();
                        aluno.Email = dr["Email"].ToString();
                        aluno.Nascimento = dr["Email"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["Nascimento"]);
                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void IncluirAluno(Aluno aluno)
        {

            var conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Escola;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("IncluirAluno", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramNome = new SqlParameter();
                    paramNome.ParameterName = "@Nome";
                    paramNome.Value = aluno.Nome;
                    cmd.Parameters.Add(paramNome);

                    SqlParameter paramEmail = new SqlParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = aluno.Email;
                    cmd.Parameters.Add(paramEmail);

                    SqlParameter paramSexo = new SqlParameter();
                    paramSexo.ParameterName = "@Sexo";
                    paramSexo.Value = aluno.Sexo;
                    cmd.Parameters.Add(paramSexo);

                    SqlParameter paramNascimento = new SqlParameter();
                    paramNascimento.ParameterName = "@Nascimento";
                    paramNascimento.Value = aluno.Nascimento;
                    cmd.Parameters.Add(paramNascimento);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
