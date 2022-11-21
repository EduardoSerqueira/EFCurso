using EFCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCurso.DataBase
{
    public class EFCursoContext : DbContext
    {
        public EFCursoContext(DbContextOptions<EFCursoContext> options) : base(options) {}

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
