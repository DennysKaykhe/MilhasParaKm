double milhas;
double km;

Console.Clear();

Console.Write("Entre com a medida (em milhas): ");
milhas = Convert.ToDouble (Console.ReadLine());

km = milhas * 1.609;

Console.WriteLine($"Medida em KM: {km} ");