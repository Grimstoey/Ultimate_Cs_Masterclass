List<string> addList = new List<string>();

Console.WriteLine("Hello!!!");

void Choice()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S] See all to do list");
    Console.WriteLine("[A] Add a to do list");
    Console.WriteLine("[R] Remove a to do list");
    Console.WriteLine("[E] Exit");
}

void showList()
{
    int no = 1;
    if (addList.Count != 0)
    {
        foreach (string order in addList)
        {
            Console.WriteLine($"{no}. {order}");
            no++;
        }
    }
    else if(addList.Count == 0)
    {
        Console.WriteLine("No to-do list");
    }
}

void WantToDo()
{
    string addToDo;

    do
    {
        Console.WriteLine("What do you want to do ?");
        addToDo = Console.ReadLine();

        if (addToDo.Length > 0 && addToDo != "B")
        {
            addList.Add(addToDo);
            if (addList.Count != 0)
            {
                CheckAddList();
            }
            Console.WriteLine();
            ToDoList();
        }
        else if (addToDo.Length <= 0)
        {
            Console.WriteLine("You didn't add what you wanted to do.");
            Console.WriteLine("Or press [ B ] to return to the main menu.");
        }
    }
    while (addToDo.Length <= 0);

    if(addToDo == "B")
    {
        Console.WriteLine();
        ToDoList();
    }
}
void CheckAddList()
{
    bool canAdd = true;
    for (int i = 0; i < addList.Count(); i++)
    {
        int check = 0;
        for (int ii = 0; ii < addList.Count(); ii++)
        {
            if (addList[i].Contains(addList[ii]))
            {
                check++;
            }

            if (check > 1)
            {
                addList.Remove(addList[ii]);
                Console.WriteLine("You have already added this. Unable to add identical entries.");
                canAdd = false;
                break;
            }
        }

    }
    if (canAdd == true)
    {
        Console.WriteLine($"Your to-do list has been successfully added.");
    }
}

void RemoveList()
{
    string  selected;
    int     checkNo;
    bool    canRemoveNo;

    do
    {
        Console.WriteLine("Select what number you want to remove.");
        showList();
        selected = Console.ReadLine();
        if (selected.Length <= 0)
        {
            IncorrectRemove();
        }
    }
    while (selected.Length <= 0);

    if (selected.Length > 0)
    {
        canRemoveNo = int.TryParse(selected, out checkNo);

        if (canRemoveNo)
        {
            if (checkNo > 0 && checkNo <= addList.Count)
            {
                Console.WriteLine($"Remove : {addList[checkNo - 1]}");
                addList.Remove(addList[checkNo - 1]);
                Console.WriteLine();
            }
            else
            {
                IncorrectRemove();
            }
        }
        else
        {
            IncorrectRemove();
        }

        ToDoList();
    }
}

void IncorrectRemove()
{
    Console.WriteLine("Your number to remove is incorrect.");
    Console.WriteLine();
    RemoveList();
}

void ToDoList()
{
    Choice();

    string input = Console.ReadLine();

    if (input == "S" || input == "s")
    {
        showList();
        Console.WriteLine();
        ToDoList();
    }
    else if (input == "A" || input == "a")
    {
        WantToDo();
    }
    else if (input == "R" || input == "r")
    {
        RemoveList();
    }
    else if (input == "E" || input == "e")
    {
        Console.WriteLine("Exit");
    }
    else
    {
        Console.WriteLine("Invalid Input!! Please enter S, A, R, or E");
        Console.WriteLine();
        ToDoList();
    }
}

ToDoList();
Console.ReadKey();
