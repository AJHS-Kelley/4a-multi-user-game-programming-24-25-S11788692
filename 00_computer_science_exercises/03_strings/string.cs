using system: 

class Strings {
    static void Main(){

        string greeting= "Hey there, how you doing?\n"
        string goodbye= "I'll see you later.\n"

        Console. writeLine(greeting.Length);
        Console. writeLine(goodbye.Length);

        if (greeting.Length > goodbye.length)
        {
            Console.WriteLine("")
        }


        Console.writeLine(greeting.ToUpper());
         Console.writeLine(greeting.ToLower());

         
        string comboString = greeting + goodbye;
        Console.WriteLine(ComboString);

        String comboString2 = String.concat(greeting, goodbye);
        Console.WriteLine(comboString2);

        Console.WriteLine(goodbye[0])
        Console.WriteLine(goodbye[5])

        console.writeLine(greeting.IndexOf("y"));


    }
}
