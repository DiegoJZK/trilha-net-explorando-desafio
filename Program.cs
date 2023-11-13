using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa();
Console.WriteLine("Cadastre os hóspedes para a suíte:");
Console.WriteLine("Digite o nome do hóspede: ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Digite o sobrenome do hóspede: ");
p1.Sobrenome = Console.ReadLine();
hospedes.Add(p1);

while (true){
    Console.WriteLine("Deseja cadastrar mais um hóspede? (Digite "+"sim"+"para continuar e "+"não"+" para encerar cadastro de hóspedes.)");
    string aux = Console.ReadLine();
    if (aux == "sim")
    {
        Pessoa p2 = new Pessoa();
        Console.WriteLine("Cadastre os hóspedes para a suíte:");
        Console.WriteLine("Digite o nome do hóspede: ");
        p2.Nome = Console.ReadLine();
        Console.WriteLine("Digite o sobrenome do hóspede: ");
        p2.Sobrenome = Console.ReadLine();
        hospedes.Add(p2);
    }
    else
    {
        break;
    }

}
// Cria a suíte
Suite suite = new Suite();
Console.WriteLine("Cadastro de suíte: ");
Console.WriteLine("Digite o tipo de suíte: ");
suite.TipoSuite = Console.ReadLine();
Console.WriteLine("Digite sua capacidade de hóspedes: ");
suite.Capacidade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da diária: ");
suite.ValorDiaria = Convert.ToDecimal(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva();
Console.WriteLine("Digite quantos dias vai ter a reserva: ");
reserva.DiasReservados = int.Parse(Console.ReadLine());
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");