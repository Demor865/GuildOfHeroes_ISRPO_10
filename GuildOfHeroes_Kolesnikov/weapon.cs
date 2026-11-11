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
    public void Strength_Damage(Double damage) { // снижение прочности
        if (damage < 0) { damage = 0; } // фильтр значений
        Strength -= damage;
        if (Strength < 0) { Strength = 0; } // защита от отрицательной прочности
    }
    public void Strength_Damage() {
        Strength -= 0.05;
        if (Strength < 0) { Strength = 0; } // защита от отрицательной
    }
    public void Strength_Heal(Double heal) { // Восстановление прочности
        if (heal < 0) { heal = 0; } // фильтр значений
        Strength += heal;
        if (Strength > 1) { Strength = 1; } // защита от переполнения 
    }
    public void Rename(string new_name) { // Смена имени
        Name = new_name;
    }
    public bool IsBroken() { // Сломано или нет
        return Strength == 0;
    }
    public string GetInfo() { // Информация
        return $">>> {Name} <<<\n" +
                $"Тип оружия - {Type}\n" +
                $"Урон - {Damage}\n" +
                $"Прочность - {Strength}\n";
    }
}