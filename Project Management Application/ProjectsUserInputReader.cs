using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class ProjectsUserInputReader
    {
        public static string[] GetSearchInput()
        {
            string[] listOfChoices = { "Project Name", "Task Name", "Task Status", "Assigned Contributor" };
            Console.WriteLine($"Search on");
            string[] UserInput = new string[4];
            int counter = 0;
            do
            {
                Console.WriteLine($"** {listOfChoices[counter]}: ");
                UserInput[counter] = Console.ReadLine();
                Console.WriteLine(UserInput[counter]);
                counter++;
            }
            while (counter < listOfChoices.Length);
            return UserInput;
        }
    }
}
