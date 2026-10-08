Console.WriteLine("Controle de estoque crítico"); //mostra ba primeira mensagem
Console.Write("Quantos produtos deseja cadastrar? ");
//cria a caixa da quantidade de itens e converte a resposta para int
int quantidadeItens = Convert.ToInt32(Console.ReadLine());
//cria um novo item em int de acordo com a quantidade q o usuario colocou
int [] itens = new int[quantidadeItens];

for (int contador = 0; contador < quantidadeItens; contador++)
{
    Console.Write($"Quantidade do produto {contador +1}: ");
    itens[contador] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("ALERTA! Produtos com estoque crítico: ");
for (int contador = 0; contador < quantidadeItens; contador++)
{
    if (itens[contador] < 5)
    {
        Console.WriteLine($"Produto {contador+1} está com estoque baixo. Apenas {itens[contador]} unidades");
    }
}