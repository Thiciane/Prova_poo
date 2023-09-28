public class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Medico> listMed = new();
            List<Administracao> listAdm = new();
            while (true)
            {
                Console.WriteLine("\n1 - Continuar\n2 - Sair\n");
                int.TryParse(Console.ReadLine(), out int opc1);

                switch (opc1)
                {
                    case 1:
                        Console.WriteLine("Nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("CPF:");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Matrícula:");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Data de nascimento:");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Sexo:");
                        string sexo = Console.ReadLine();
                        Console.WriteLine("Salário:");
                        double salario = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("\nFUNCIONÁRIO:\n1 - Médico\n2 - Administração\n");
                        int.TryParse(Console.ReadLine(), out int opc);

                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine("CRM:");
                                string crm = Console.ReadLine();
                                Console.WriteLine("Valor hora extra:");
                                double valorHoraExtra = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Especialidade:");
                                string Especialidade = Console.ReadLine();

                                Medico med = new Medico(nome, cpf, matricula, dataNascimento, sexo, salario, crm, valorHoraExtra, Especialidade);

                                listMed.Add(med);
                                break;
                            case 2:
                                Administracao adm = new Administracao(nome, cpf, matricula, dataNascimento, sexo, salario);

                                listAdm.Add(adm);
                                break;

                        }
                        break;
                    case 2:
                        
                        goto sair;
                }
            }
            sair:;
            Console.Clear();
            Console.WriteLine("Salários acima de R$2000,00:");
            listMed.ForEach((med) =>
            {
                if (med.Salario > 2000)
                {
                    Console.WriteLine($"\nNome: {med.Nome}\nSalário: {med.Salario}");
                }
            });
            listAdm.ForEach((adm) =>
            {
                if (adm.Salario > 2000)
                {
                    Console.WriteLine($"\nNome: {adm.Nome}\nSalário: {adm.Salario}");
                }
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERRO!\n" + ex);
        }
        Console.ReadKey();
    }
}
