int quantidadeNota100 = 10;
int quantidadeNota50 = 10;
int quantidadeNota20 = 10;
int quantidadeNota10 = 10;

Console.WriteLine("Bem-vindo ao caixa eletrônico!");

while (true)
{
    // Solicitar valor de saque
    Console.Write("Digite o valor desejado para saque (ou 0 para sair): ");
    int valorSaque = Convert.ToInt32(Console.ReadLine());

    if (valorSaque == 0)
    {
        Console.WriteLine("Saindo do caixa eletrônico. Obrigado!");
        break;
    }

    int notas100 = Math.Min(valorSaque / 100, quantidadeNota100);
    valorSaque -= notas100 * 100;

    int notas50 = Math.Min(valorSaque / 50, quantidadeNota50);
    valorSaque -= notas50 * 50;

    int notas20 = Math.Min(valorSaque / 20, quantidadeNota20);
    valorSaque -= notas20 * 20;

    int notas10 = Math.Min(valorSaque / 10, quantidadeNota10);
    valorSaque -= notas10 * 10;

    if (valorSaque == 0)
    {
        Console.WriteLine($"Entregando notas: {notas100}x R$100, {notas50}x R$50, {notas20}x R$20, {notas10}x R$10");

        quantidadeNota100 -= notas100;
        quantidadeNota50 -= notas50;
        quantidadeNota20 -= notas20;
        quantidadeNota10 -= notas10;
    }
    else
    {
        Console.WriteLine("Não é possível fornecer o valor solicitado com as notas disponíveis. Tente novamente.");
    }
}