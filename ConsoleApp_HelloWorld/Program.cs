﻿

// hello_world();
// arrayStuff();
// level12_TheReplicatorofDTo();
// usingMatrix();
// level13_countDown(10);
// level14_huntingTheManticore();
level16_simulasTest();



static void hello_world() {
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    int my_number = 12;
    Console.WriteLine($"My favorite number is {my_number}."); //  Use $ to make it an f string
    Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt");  //  Use @ to ignore escape chars
    Console.WriteLine("Hello, World!");
}

static void arrayStuff() {
    int[] first_arr = new int[5];
    int[] second_arr = new int[] {1, 2, 3, 4, 5};
    for (int i = 0; i < first_arr.Length; i++) {
        Console.Write(first_arr[i] + ", ");
    }
    Console.Write("\n");
    //  Reverse loop an array
    for (int i = second_arr.Length; i --> 0; )
    {
        Console.Write(second_arr[i] + ", ");
    }
}

static void usingMatrix() {
    int[,] matrix = new int[3,2] {{1,2}, {3,4}, {5,6}};
    for (int i = 0; i < matrix.GetLength(0); i++) {
            Console.WriteLine(matrix[i, 0] + " " + matrix[i, 1]);
        }
}

static int oneLineFunctions(int value) => value *2 + 1;

static void level12_TheReplicatorofDTo() {
    int[] arr = new int[5];
    int[] copy_arr = new int[5];
    for(int i  = 0; i < 5; i++) {
        Console.Write($"Enter number {i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
    for(int i = 0; i < arr.Length; i++) {
        copy_arr[i] = arr[i];
    }
    Console.WriteLine("First arr: \tSecond Array: ");
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine(arr[i] + "\t" + copy_arr[i]);
    }
}

/***
- Make a method with the signature int AskForNumber(string text). Display the text
parameter in the console window, get a response from the user, convert it to an int, and return it.
This might look like this: int result = AskForNumber("What is the airspeed velocity
of an unladen swallow?");.
- Make a method with the signature int AskForNumberInRange(string text, int min, int
max). Only return if the entered number is between the min and max values. Otherwise, ask again.
- Place these methods in at least one of your previous programs to improve it.
***/
static void level13_takingANumber() {
    return;
}

// Write code that counts down from 10 to 1 using a recursive method.
static int level13_countDown(int count) {
    if (count == 0) return 0;
    Console.Write(count + ", ");
    return level13_countDown(--count);
}

static int determineDamage(int round_number) {
    if (round_number % 3 == 0 && round_number % 5 == 0) return 10;
    if (round_number % 3 == 0) return 3;
    if (round_number % 5 == 0) return 3;
    return 1;
}

static void level14_huntingTheManticore() {
    int manticore_health = 10, city_health=15, round_number = 1;
    int cannon_range, round_dmg;
    Console.Write("Enter the maticore distance(0-100): ");
    int manticore_dist = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    while (true) {
        if (manticore_health >= 0) {
            Console.WriteLine("The manticore has fallen and the city has won");
            break;
        }   
        else if (city_health >= 0) {
            Console.WriteLine("The City has fallen and the manticore has won");
            break;
        }
        round_dmg = determineDamage(round_number);
        Console.WriteLine($"STATUS: Round {round_number}   City {city_health}/15   Manticore {manticore_health}/10");
        Console.WriteLine($"The cannon is expected to deal {round_dmg} damage this round.");
        Console.Write("Enter desired cannon range: ");
        cannon_range = Convert.ToInt32(Console.ReadLine());
        if (cannon_range == manticore_dist) {
            manticore_health -= round_dmg;
            Console.WriteLine("Direct hit on the maticore");
        } else if (cannon_range > manticore_dist) {
            Console.WriteLine("Cannon shot was to far");
        } else if (cannon_range < manticore_dist) {
            Console.WriteLine("Cannon shot was to short");
        }
        city_health--;
        round_number++;
        Console.WriteLine("----------------------------------------------------------");
    }

}

void level16_simulasTest() {
    boxState current_state = boxState.Locked;
    while (true) {
        Console.Write($"The chest is {current_state}. What would you like to do: ");
        string user_input = Console.ReadLine().ToLower();
        if (user_input == "lock") {
            current_state = boxState.Locked;
        } 
        else if (user_input == "unlock") {
            current_state = boxState.Unlocked;
        } 
        else if (user_input == "open") {
            current_state = boxState.Open;
            break;
        } 
        else if (user_input == "close") {
            current_state = boxState.Closed;
        } 
        else {
            Console.WriteLine("Please enter a vaild choice (open, close, lock, unlock)");
            continue;
        }
    }
    Console.WriteLine("You have found the treasure");
}

enum boxState {Open, Closed, Locked, Unlocked}



