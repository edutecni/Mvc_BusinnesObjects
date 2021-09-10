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
        private string conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Escola;Integrated Security=True";
       
        public List<Aluno> GetAlunos()
        {   
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
                        aluno.Foto = dr["Foto"].ToString();
                        aluno.Texto = dr["Texto"].ToString();
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

                    SqlParameter paramFoto = new SqlParameter();
                    paramFoto.ParameterName = "@Foto";
                    paramFoto.Value = aluno.Foto;
                    cmd.Parameters.Add(paramFoto);

                    SqlParameter paramTexto = new SqlParameter();
                    paramTexto.ParameterName = "@Texto";
                    paramTexto.Value = aluno.Texto;
                    cmd.Parameters.Add(paramTexto);                    

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

        public void AlterarAluno(Aluno aluno)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("AlterarAluno", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramAlunoId = new SqlParameter();
                    paramAlunoId.ParameterName = "@AlunoId";
                    paramAlunoId.Value = aluno.AlunoId;
                    cmd.Parameters.Add(paramAlunoId);

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

                    SqlParameter paramFoto = new SqlParameter();
                    paramFoto.ParameterName = "@Foto";
                    paramFoto.Value = aluno.Foto;
                    cmd.Parameters.Add(paramFoto);

                    SqlParameter paramTexto = new SqlParameter();
                    paramTexto.ParameterName = "@Texto";
                    paramTexto.Value = aluno.Texto;
                    cmd.Parameters.Add(paramTexto);

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

        public void DeletarAluno(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("DeletarAluno", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramAlunoId = new SqlParameter();
                    paramAlunoId.ParameterName = "@AlunoId";
                    paramAlunoId.Value = id;
                    cmd.Parameters.Add(paramAlunoId);

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
