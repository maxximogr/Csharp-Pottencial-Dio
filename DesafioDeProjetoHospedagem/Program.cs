using System.Text;
using desafio_de_projeto.Models;


Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos de hospedes e cadastra na linha de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");


hospedes.Add(p1);
hospedes.Add(p2);


//cria a suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

//cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspede: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária R$: {reserva.CalcularValorDiaria()}");