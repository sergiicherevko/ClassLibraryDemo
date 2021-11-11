using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;
//Course:
    //04 ОСНОВЫ C#: ОБЪЕКТНО-ОРИЕНТИРОВАННОЕ ПРОГРАММИРОВАНИЕ, ЧАСТЬ 1
        //Video: 6 Class Libraries

namespace ConsoleUI
// Note: In ConsoleUI you put only the code that importatant for the User Interface itself in the UI
// Example: Console Rear/WriteLine
// Everything else goes to the Class Library

// Note: Two projects under the same Solution do not talk to each other. They can be connected through references
// Steps: Right Click on References in UI > Add Reference > Projects > Choose your Library > Now have access to the Library and you can do: Using YouLibraryName.Models
// Note2: You can NOT add reference to both projects, you'd get cercular dependancy error
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
        }
    }
}
