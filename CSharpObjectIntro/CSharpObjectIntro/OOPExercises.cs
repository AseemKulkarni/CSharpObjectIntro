using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        internal static void Run()
        {
            UseDiary();
        }

        internal static void UseDiary()
        {
            // Create a new diary 
            Diary book = new Diary("Personal diary"); 
            Console.WriteLine(book.Name);
            DateOnly eventdate=new DateOnly(2022,10,03);

            // Add some events to your diary
            book.AddEvent(eventdate, 19, "Table tennis practice", "Fencing salle");
            // Now check how many events you have on a particular day
            int num_of_events = book.CheckDiary(eventdate);
            Console.WriteLine(num_of_events);

            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
            // Im not sure how to create a new method
        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class

            // Write calling code from here
        }
    }
}

