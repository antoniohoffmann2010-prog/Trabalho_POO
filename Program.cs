Cliente cliente = new Cliente("João");
Cliente cliente2 = new Cliente("Albert");

Barbeiro barbeiro = new Barbeiro("Carlos");
Barbeiro barbeiro2 = new Barbeiro("Jailson");

Servico servico = new Servico("Corte");
Servico servico2 = new Servico("Barba");

cliente.Nome = "João";
barbeiro.Nome = "José";
servico.Nome = "Degradê";

Console.WriteLine(cliente);
Console.WriteLine(barbeiro);
Console.WriteLine(servico);

cliente.MarcarHorario();
barbeiro.CortarCabelo();
servico.MostrarServiço();

Console.WriteLine("---------------------------------------");

Console.WriteLine(cliente2);
Console.WriteLine(barbeiro2);
Console.WriteLine(servico2);

cliente2.MarcarHorario();
barbeiro2.CortarCabelo();
servico2.MostrarServiço();