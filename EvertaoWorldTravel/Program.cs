using EvertaoWorldTravel;

Console.WriteLine("*****************************************");
Console.WriteLine("BEM VINDO A AGENCIA DE VIAGEN DO EVERTAO");
Console.WriteLine("*****************************************");

string[] menuItems = {
                "Listar passagens disponiveis",
                "Comprar Passagem",
                "Sair"
            };
static int ShowMenu(string[] menuItems)
{
    Console.WriteLine();
    Console.WriteLine("SELECIONE A OPCAO DESEJADA:\n");

    for (int i = 0; i < menuItems.Length; i++)
    {
        //Console.WriteLine((i + 1) + ":" + menuItems[i]);
        Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
    }

    int selection;
    Console.WriteLine();
    Console.Write("OPCAO: ");
    while (!int.TryParse(Console.ReadLine(), out selection)
        || selection < 1
        || selection > 3)
    {
        Console.Write("Temos apenas 3 opcoes, digite o numero correspondente a opcao desejada: ");
    }
    return selection;
}

var selection = ShowMenu(menuItems);

while (selection != 3)
{
    switch (selection)
    {
        case 1:
            ListarPassagens();
            break;
        case 2:
            ComprarPassagem();
            break;
        default:
            break;
    }
    selection = ShowMenu(menuItems);
}
Console.WriteLine("OBRIGADO PELA PREFERENCIA");

static void ListarPassagens()
{
    Console.WriteLine("Lista de Passagens Disponiveis: \n");
    var ticketClient = new TicketClient();
    var tickets = ticketClient.GetTickets();
    tickets.ForEach(c => Console.WriteLine(c.ToString()));
}

static void ComprarPassagem()
{
    Console.Write("Digite o numero do ticket que deseja comprar:");
    var ticketClient = new TicketClient();
    int ticketNumber = int.Parse(Console.ReadLine());
    ticketClient.DeleteTicket(ticketNumber);
    Console.WriteLine("Passagem Comprada com SUCESSO !");
}