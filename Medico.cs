public class Medico : Funcionario
{
    /*b) Médico é um tipo de funcionário que possui todos os atributos e métodos de funcionário 
além do CRM (registro no conselho), valor de hora extra e especialidade. Os médicos 
recebem um benefício de 22% sobre o salário de auxílio periculosidade (não é contabilizado 
para esse cálculo o valor da hora extra).*/

    public string Crm { get; set; }
    public double ValorHoraExtra { get; set; }
    public string Especialidade { get; set; }

    public Medico(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario, 
        string crm, double valorHoraExtra, string especialidade) : base( nome, cpf, matricula, dataNascimento, sexo, salario)
    {
        Crm = crm;
        ValorHoraExtra = valorHoraExtra;
        Especialidade = especialidade;
        Salario += 0.22 * salario;
    }
}
