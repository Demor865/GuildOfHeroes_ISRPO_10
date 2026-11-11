public class Weapon { // Класс оружие
    public string Name; // Имя 
    public int Damage; // Урон 
    public Double Strength; // Прочность 
    public string Type; // Тип оружия

    public Weapon(string name, int damage, string type) {
        Name = name;
        Damage = damage;
        Strength = 1.0; // Прочность по умолчанию 1(целый)
        Type = type;
    }
}