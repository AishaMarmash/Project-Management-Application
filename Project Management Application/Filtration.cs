using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class Filtration
    {
        public static void Search(List<Project> projects)
        {
            string[] filterBy = GetInformation();

            var ProjectName_query = projects.Select(p => p);
            ProjectName_query = projects.Select(p => p).Where(p => p.ProjectName.Contains(filterBy[0])).ToList();
            var ProjectName_TaskName_query = ProjectName_query.SelectMany(pros => pros.Tasks).Where(task => task.Title.Contains(filterBy[1])).ToList();
            var ProjectName_TaskName_TaskStatus_query = ProjectName_TaskName_query.Select(task => task).Where(task => task.Status.Contains(filterBy[2]));
            var ProjectName_TaskName_TaskStatus_User_query = ProjectName_TaskName_TaskStatus_query.Select(tasks => tasks).Where(task => task.Contributor.Contains(filterBy[3]));

            foreach (var task in ProjectName_TaskName_TaskStatus_User_query)
            {
                Console.WriteLine(task);
            }
        }

        private static string[] GetInformation()
        {
            string[] _listOfChoices = { "Project Name", "Task Name", "Task Status", "Assigned User" };
            Console.WriteLine($"Search on");
            string[] filterBy = new string[4];
            int counter = 0;
            do
            {
                Console.WriteLine($"** {_listOfChoices[counter]}: ");
                filterBy[counter] = Console.ReadLine();
                Console.WriteLine(filterBy[counter]);
                counter++;
            }
            while (counter < _listOfChoices.Length);
            return filterBy;
        }
    }
}
