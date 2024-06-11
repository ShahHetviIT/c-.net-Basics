// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the TODO list program!");
List<string> list = new List<string>();

string option = "";

while(option != "e"){
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("Enter 1 to add a task to the list.");
    Console.WriteLine("Enter 2 to remove a task from the list.");
    Console.WriteLine("Enter 3 to view the list.");
    Console.WriteLine("Enter e to exit the program");

    option = Console.ReadLine();

    if(option == "1"){
        Console.WriteLine("Please enter the name of the task to add to the list.");
        string task = Console.ReadLine();
        list.Add(task);
        Console.WriteLine("Task successfully added to the list.");
    }else if(option == "2"){
        for(int i=0;i<list.Count;i++){
            Console.WriteLine(i+1 + " : " + list[i]);
        }
        Console.WriteLine("Please enter the number of the task u want to remove from the list.");
        int taskNumber = Convert.ToInt32(Console.ReadLine());
        list.RemoveAt(taskNumber-1);
    }else if(option == "3"){
        Console.WriteLine("All the tasks int the list.");
        for(int i=0;i<list.Count;i++){
            Console.WriteLine(i+1 + " : " + list[i]);
        }
    }else if(option == "e"){
        Console.WriteLine("Exiting the program.");
    }else{
        Console.WriteLine("Invalid option, please try again.");
    }
}
