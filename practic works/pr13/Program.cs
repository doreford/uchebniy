using System;

struct Painting
{
    public string name;
    public string artist;
    public int inventoryNumber;
    public int year;
    public string restorer;
    public double price;
}
class Gallery
{
    static void Main()
    {
        Console.Write("Количество экспонатов: ");
        int n = int.Parse(Console.ReadLine());

        Painting paintings = new Painting();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Экспонат № {i + 1}: ");
            Console.Write("Наименование картины: ");
            paintings.name = Console.ReadLine();
            Console.Write("художник: ");
            paintings.artist = Console.ReadLine();
            Console.Write("Инвентарный номер: ");
            paintings.inventoryNumber = int.Parse(Console.ReadLine());
            Console.Write("Год создания картины: ");
            paintings.year = int.Parse(Console.ReadLine());
            Console.Write("Реставратор: ");
            paintings.restorer = Console.ReadLine();
            Console.Write("Цена: ");
            paintings.price = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Список экспонатов: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Экспонат № {i + 1}: ");
            Console.WriteLine($"Наименование картины: {paintings.name}");
            Console.WriteLine($"Художник: {paintings.artist}");
            Console.WriteLine($"Инвентарный номер: {paintings.inventoryNumber}");
            Console.WriteLine($"Год создания картины: {paintings.year}");
            Console.WriteLine($"Реставратор: {paintings.restorer}");
            Console.WriteLine($"Цена: {paintings.price}");
        }

        Console.Write("Поиск: ");
        string search = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (paintings.name.Contains(search) ||
                paintings.artist.Contains(search) ||
                paintings.restorer.Contains(search))
            {
                Console.WriteLine($"Найден экспонат № {i + 1}:");
                Console.WriteLine($"Наименование картины: {paintings.name}");
                Console.WriteLine($"Художник: {paintings.artist}");
                Console.WriteLine($"Инвентарный номер: {paintings.inventoryNumber}");
                Console.WriteLine($"Год создания картины: {paintings.year}");
                Console.WriteLine($"Реставратор: {paintings.restorer}");
                Console.WriteLine($"Цена: {paintings.price}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Экспонаты не найдены.");
        }
    }
}

