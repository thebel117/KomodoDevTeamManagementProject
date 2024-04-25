using System; // System namespace to gets access to core C# functionalities and that's it

namespace Komodo_Console // Defining a namespace Komodo_Console.
{
    class Program // A class named Program.
    {
        static void Main(string[] args) // Main method 
        {
            ProgramUI program = new ProgramUI();        // Makes an instance of ProgramUI class, assigns it to 'program' var, then "new ProgramUI()" 
//                                                         makes a new obj using the 'ProframUI' (this is instantiating)
            program.Run();                              // Calling Run method to kick it off
        }
    }
};

//Prof notes 4/24/24:
//Remember that dots=namespace. Nbd, but causes issues if we do say, "XYZ.Console", which creates a namespace
//So like if you're doing a 'Console.WriteLine()' now you've created ambiguity of location, causing you to have to specify further.
//If you aren't careful with intentional naming and name a namespace something too common, you could have a namespace and object overlap (cannot have a namespace as a class)
//Sys cant really distinguish names like that.