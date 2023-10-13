Console.Write("Введите К1  ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2  ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2  ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = -(b1- b2)/(k1- k2);
int y =k1*x+b1;


Console.WriteLine($"Точка пересечения ({x} {y})");
