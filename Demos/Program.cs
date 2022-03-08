using static System.Console;
public class Program
{
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    static void TrocarNome (Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa ();
        p1.Nome = "Queen";
        p1.Idade = 2;
        p1.Documento = "124568";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1,"Joseph");
        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}");
    }
    static void TrocaNomeStruct(StructPessoa p1, string novoNomeStruct)
    {
        p1.Nome = novoNomeStruct;
    }
    static void Demo3()
    {
         StructPessoa p1 = new StructPessoa()
       {
           Documento ="12345",
           Idade = 30,
           Nome = "Camila"
       };
       var p2 = p1;

       TrocaNomeStruct(p1,"Queen");
       WriteLine($@"
       Nome do p1: {p1.Nome}
       Nome do p2: {p2.Nome}");
        
    }

    static void TrocarNomeString(string nome, string nomeNovoString)
    {
        nome = nomeNovoString;
    }
    static void Demo4()
    {
        string nome = "Joseph";
        TrocarNomeString(nome,"Jow");
        WriteLine($"O novo nome é {nome}");
    }
     static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i]+1;
        }
    }
    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8};
        MudarParaImpar(pares);
        WriteLine($"Os ímpares {string.Join(",", pares)}");
        
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i =0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;
        }
        return -1;
    }
    static void Demo6()
    {
       int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros,numero);

        if (idxEncontrado >= 0)
        {
            WriteLine($"O número digitado esta na posição {idxEncontrado}");
        }
        else
        {
            WriteLine($"O número digitado não foi encontrado");
        }
        
        
    }
    static bool EncontrarPessoa(List<Pessoa> pessoas,Pessoa pessoa)
    {
        foreach(var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    static void Demo7()
    {
          List<Pessoa> pessoas = new List<Pessoa> ()
        {
            new Pessoa(){Nome = "Camila"},
            new Pessoa(){Nome = "Kémellyn"},
            new Pessoa(){Nome = "Queen"},
            new Pessoa(){Nome = "Joseph"},
            new Pessoa(){Nome = "CKQJ"},

        };
        WriteLine($"Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine($"Pessoa Localizada!");
        }
        else
        {
            WriteLine($"Pessoa  não Localizada!");
        }

    }
     static bool EncontrarPessoaStruct(List<StructPessoa> pessoas,StructPessoa pessoa)
    {
        foreach(var item in pessoas)
        {
            if (item.Equals(pessoa))
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        
        List<StructPessoa> pessoas = new List<StructPessoa> ()
        {
            new StructPessoa(){Nome = "Camila"},
            new StructPessoa(){Nome = "Kémellyn"},
            new StructPessoa(){Nome = "Queen"},
            new StructPessoa(){Nome = "Joseph"},
            new StructPessoa(){Nome = "CKQJ"},

        };
        WriteLine($"Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoaStruct(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine($"Pessoa Localizada!");
        }
        else
        {
            WriteLine($"Pessoa  não Localizada!");
        }

       
    }
}
