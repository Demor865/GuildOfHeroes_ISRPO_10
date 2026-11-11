// Герои
using System.Diagnostics;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);


yaroslav.TakeDamage(25);


Console.WriteLine(">>> Герой 1 <<<");
print_person(yaroslav);
Console.WriteLine(">>> Герой 2 <<<");
print_person(anastasia);
Console.WriteLine(">>> Герой 3 <<<");
print_person(artem);

// проверка урона
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// проверка лечения и xp
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
Console.WriteLine();


// Оружия
Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");

Console.WriteLine(">>> Оружие 1 <<<");
print_weapon(Sword);
Console.WriteLine(">>> Оружие 2 <<<");
print_weapon(Bow);
Console.WriteLine(">>> Оружие 3 <<<");
print_weapon(Staff);



// Функции
void print_person(Hero person) {
    Console.WriteLine($"Имя - {person.Name}");
    Console.WriteLine($"Здоровье - {person.Health}");
    Console.WriteLine($"Уровень - {person.Level}");
    Console.WriteLine($"Опыт - {person.Experience}");
    Console.WriteLine();
}
void print_weapon(Weapon x) {
    Console.WriteLine($"Имя - {x.Name}");
    Console.WriteLine($"Тип оружия - {x.Type}");
    Console.WriteLine($"Урон - {x.Damage}");
    Console.WriteLine($"Прочность - {x.Strength}");
    Console.WriteLine();
}