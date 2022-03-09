using static System.Console;

Pessoa p1 = new Pessoa();
p1.Nome = "Joseph";
p1.Idade = 2;
//p1.EnderecoPessoa = default; ou
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua 1",
    Numero = 2777,
    CEP = "19013150",
    Cidade = "São Paulo",

};

WriteLine("Fim");