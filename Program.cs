Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua altura(m):");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu peso(kg):");
double peso = double.Parse(Console.ReadLine());

double imc = 0;

imc = peso/(altura * altura);

Console.WriteLine($"O IMC de {nome} é igual a {imc:f2}");

if(imc < 18.5)
{
    Console.WriteLine("Você esta abaixo do peso!");
}
else if(imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Você esta no peso ideal!");
}
else
{
    Console.WriteLine("Você esta acima do peso!");
}