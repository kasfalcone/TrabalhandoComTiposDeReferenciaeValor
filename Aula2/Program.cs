using static System.Console;
class Aula2
{
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O Valor de a é {a}"!);
    }
    static void Adicionar20(ref int a)
    {
        a+=20;
    }
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Demo2()
    {
        var nomes = new string[] {"José","Joseph","Queen","Alice","Rose"};

        WriteLine($@"A lista de nomes é: 
        {string.Join(",\n",nomes)}");

        WriteLine("Digite o nome a ser substituido");
        var nome = ReadLine();
        
        WriteLine("Digite o nome novo:");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome,nomeNovo);

        WriteLine($@"A lista de nomes alterada é: 
        {string.Join(",\n",nomes)}");

    }
    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
                return ref nomes[i];
            
        }
        throw new Exception("Nome não encontrado");
    }

    static void Main()
    {
        
        var nomes = new string[] {"José","Joseph","Queen","Alice","Rose"};

        WriteLine($@"A lista de nomes é: 
        {string.Join(",\n",nomes)}");

        WriteLine("Digite o nome a ser substituido");
        var nome = ReadLine();
        
        WriteLine("Digite o nome novo:");
        var nomeNovo = ReadLine();

        ref var nomeAchado = ref LocalizarNome(nomes,nome);
        if (!string.IsNullOrWhiteSpace(nomeAchado))
        {
            nomeAchado = nomeNovo;

            WriteLine($@"A lista de nomes alterada é: 
            {string.Join(",\n",nomes)}");
        }
        else
        {
            WriteLine("Nome não encontrado.");
        }
        
        

    }

}