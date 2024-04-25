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
