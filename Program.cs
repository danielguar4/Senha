using System.Security.AccessControl;

string Senhadigitada;
string Senha = "1234abcd";

Console.Write("Olá usuario, Digite sua Senha de acesso...: ");
Senhadigitada = Console.ReadLine()!;

if (Senhadigitada == Senha)
{
    Console.WriteLine("Acesso  Permitido");
}
else
{
    Console.WriteLine("Acesso Negado");
}