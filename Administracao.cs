public class Administracao : Funcionario
{
    /*
     c) Existe também os funcionários do administrativo que possui todos os atributos de 
funcionários além da função. Esse tipo de funcionário tem no seu salário um acréscimo de 
R$ 250 de vale transporte e 17% a mais do salário de vale alimentação (sobre o salário sem 
conta o vale transporte).

     */
    public Administracao(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
    {
        Salario += (0.17 * salario) + 250;
    }
}
