using System;

namespace EFCurso.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Salario { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
