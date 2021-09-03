using Mvc_BusinnesObjects.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BusinnesObjects.Models
{
    public class AlunoBLL : IAlunoBLL
    {
        public List<Aluno> GetAlunos()
        {
            //var configuration = ConfigurationHelper.GetConfiguration(Directory.GetCurrentDirectory());

            var conexaoString = "Data Source=MATRIX\\SQLEXPRESS;Initial Catalog=Escola;Integrated Security=True";

            List<Aluno> alunos = new List<Aluno>();

            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    //SqlCommand cmd = new SqlCommand("GetAluno", con);
                    SqlCommand cmd = new SqlCommand("Select * from Alunos", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.AlunoId = Convert.ToInt32(dr["AlunoId"]);
                        aluno.Nome = dr["Nome"].ToString();
                        aluno.Sexo = dr["Sexo"].ToString();
                        aluno.Email = dr["Email"].ToString();
                        aluno.Nascimento = Convert.ToDateTime(dr["Nascimento"]);
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
    }
}
