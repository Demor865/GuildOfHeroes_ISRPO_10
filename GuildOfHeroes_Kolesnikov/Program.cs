Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
print_info(yaroslav);
Console.WriteLine(">>> Герой 2 <<<");
print_info(anastasia);
Console.WriteLine(">>> Герой 3 <<<");
print_info(artem);


void print_info(Hero person) {
    Console.WriteLine($"Имя - {person.Name}");
    Console.WriteLine($"Здоровье - {person.Health}");
    Console.WriteLine($"Уровень - {person.Level}");
    Console.WriteLine($"Опыт: {person.Experience}");
    Console.WriteLine();
}