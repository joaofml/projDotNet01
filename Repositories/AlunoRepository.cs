using System.Text.Json;
using projDotNet01.Classes;

namespace projDotNet01.Repositories
{
    public class AlunoRepository
    {
        public List<Aluno> listaAluno;

        public AlunoRepository()
        {
            try{
                this.listaAluno = JsonSerializer.Deserialize<List<Aluno>>(File.ReadAllText("./Repositories/db.json"));
            }catch(Exception){
                this.listaAluno = new List<Aluno>();
            }
        }
    }
}