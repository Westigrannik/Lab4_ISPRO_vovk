 Console.WriteLine("Привет всем, кто это читает");
 Console.WriteLine("Меню:\n1 -- Показать ФИО\n2 -- Показать группу\n3 -- Показать дату\n4 -- Выход");
// Тот же коммит, просто я забыл...

 bool flag = true;
 while (flag == true){
    string ch = Console.ReadLine();
    switch (ch){
        case "1":
            Console.WriteLine("Вовк Тимофей Евгеньевич");
            break;
        case "2":
            Console.WriteLine("ИСП-242");
            break;   
        case "3":
            Console.WriteLine("04.10.2026 ~22:00");
            break;   
        case "4":
            flag = false;
            break;   
        default:
            Console.WriteLine("Не верное число");
            break;
    }
 }