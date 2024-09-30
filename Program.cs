//main

string userChoice = "0";
while (userChoice != "4"){


    DisplayMenu();
    userChoice = GetMenuChoice();
    RouteEm(userChoice);

}





//end main

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Select an option:\n1.Toppingless Slice\n2.Cheese pizza Slice\n3.Pepperoni Slice\n4.Exit");
}
static string GetMenuChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userChoice){
    switch (userChoice){
        case "1":
            NoToppings();
            break;
        case "2":
            CheeseSlice();
            break;
        case"3":
            PepperoniSlice();
            break;
        case"4":
            SayBye();
            break;
        default:
            DisplayErrorMessage();
            break;

    }
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

static void DisplayErrorMessage(){
    Console.WriteLine("Invalid entry; try again");
}

static void SayBye(){
    Console.WriteLine("Goodbye!");
}

static void NoToppings(){
    Random rnd = new Random();
    int num = rnd.Next(8, 13);

    for (int i = num; i > 0; i--){
        for (int j = 0; j < i; j++){
            Console.Write("* ");
        }
        Console.WriteLine("");
    
        
    }

    Pause();


}

static void CheeseSlice(){
    Random rnd = new Random();
    int num = rnd.Next(8, 13);

    for (int i = num; i >=  0; i--){
        for (int j = 0; j < i; j++){
            if(i == num || j == 0 || j == (i-1)){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine("");
    
        
    }

    Pause();


}

static void PepperoniSlice(){
    Random rnd = new Random();
    int num = rnd.Next(8, 13);

    

    for (int i = num; i >=  0; i--){
        for (int j = 0; j < i; j++){
            if(i == num || j == 0 || j == (i-1)){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine("");
    
        
    }

    Pause();


}