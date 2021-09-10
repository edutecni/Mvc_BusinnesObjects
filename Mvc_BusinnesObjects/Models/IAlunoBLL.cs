using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BusinnesObjects.Models
{
    public interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
        void IncluirAluno(Aluno aluno);
        void AlterarAluno(Aluno aluno);
        void DeletarAluno(int id);
    }
}
