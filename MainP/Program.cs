using System;
using DLLLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainP
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DLLLibrary.College cl = new DLLLibrary.College();
            DLLLibrary.Teacher cl = new DLLLibrary.Teacher();
            College cl = new College("First Moscow Educational Complex", "Starovatutinsky pr-d, 6", "Pashahonova", "Tuzovskiy");
            cl.Show();
            Teacher tchr1 = new Teacher("Tuzovskiy A.F.", "71", "TRPO")
            Teacher tchr2 = new Teacher("Tihanova A.V.", "21", "OPBD")
                foreach (Teacher tchr in cl.Library)
            {
                cl.Show();
            }
            Console.ReadKey();
        }
    }
}
