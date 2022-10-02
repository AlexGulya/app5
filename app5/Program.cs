
while (true)
{
    
    Console.WriteLine("\n\n\t\tСписок студентов\n\n");
    Console.WriteLine("1. Добавить студента\n");
    Console.WriteLine("2. Просмотреть список студентов\n");
    Console.WriteLine("3. Удалить студента\n");
    Console.WriteLine("4. Выход");
    Console.WriteLine();
    try
    {
        int list = Convert.ToInt32(Console.ReadLine());

        switch (list)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Добавить студента");
                Info2();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Список студента");
                Info2();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Удалить студента");
                Info2();
                break;
            case 4: return;
            default:
                Console.Clear();
                Info();
                break;
        }
    }
    catch 
    {
        Console.Clear();
        Info();
    }
    


}
void Info()
{
    Console.WriteLine("Ошибка ввода");
    Console.WriteLine("\n\nНажмите любую кнопку для выхода...");
    Console.ReadKey();
    Console.Clear();
}
void Info2()
{
    Console.WriteLine("\n\nНажмите любую кнопку для выхода...");
    Console.ReadKey();
    Console.Clear();
}