Cliente cliente = new Cliente("João");
Cliente cliente2 = new Cliente("Albert");
Barbeiro barbeiro = new Barbeiro("Carlos");
Barbeiro barbeiro2 = new Barbeiro("Jailson");
Servico servico = new Servico("Corte");
Servico servico2 = new Servico("Barba");
cliente.Nome = "João";
barbeiro.Nome = "José";
servico.Nome = "Degradê";

cliente2.Nome = "Albert";
barbeiro2.Nome = "Jailson";
servico2.Nome = "Barba";

Console.WriteLine(cliente);

Console.WriteLine(barbeiro);

Console.WriteLine(servico);

Console.WriteLine("---------------------------------------");

Console.WriteLine(cliente2);

Console.WriteLine(barbeiro2);

Console.WriteLine(servico2);