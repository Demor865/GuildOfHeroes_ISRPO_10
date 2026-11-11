// Герои
using System.Diagnostics;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine(yaroslav.GetInfo() + "\n");
Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine(anastasia.GetInfo() + "\n");
Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine(artem.GetInfo() + "\n");

// проверка урона
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
Console.WriteLine();

// проверка лечения и xp
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
Console.WriteLine();

// IsAlive()
bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
Console.WriteLine();



// Оружия
Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");

Console.WriteLine(Sword.GetInfo()); // Получение информации о оружии
Bow.Strength_Damage(1.5); // Снижение прочности с параметром и переполнением лимита
Console.WriteLine($"Лук поломан: {Bow.IsBroken()}");
Staff.Strength_Damage(); // Снижение прочности без параметра
Bow.Strength_Heal(0.12); // Починка
Console.WriteLine($"Лук поломан: {Bow.IsBroken()}");
Sword.Strength_Heal(0.4); // Попытка починить целый предмет
Sword.Rename("Легендарный меч"); // Смена имени

Console.WriteLine();
Console.WriteLine(Sword.GetInfo());
Console.WriteLine();
Console.WriteLine(Bow.GetInfo());
Console.WriteLine();
Console.WriteLine(Staff.GetInfo());