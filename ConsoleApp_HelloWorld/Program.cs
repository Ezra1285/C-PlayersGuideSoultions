
using System;

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


/***
- Make a program that creates an array of length 5.
- Ask the user for five numbers and put them in the array.
- Make a second array of length 5.
- Use a loop to copy the values out of the original array and into the new one.
- Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
again
***/
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

static void Main() {
    // hello_world();
    // arrayStuff();
    level12_TheReplicatorofDTo();
}

Main();


