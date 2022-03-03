using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class TasksFiltration
    {
        public static List<Task> Search(List<Project> projects, string[] SearchUserInput)
        {
            var searchQuery = projects.Select(p => p).Where(p => p.ProjectName.Contains(SearchUserInput[0]))
                                      .SelectMany(pros => pros.Tasks).Where(task => task.Title.Contains(SearchUserInput[1]))
                                      .Select(task => task).Where(task => task.Status.Contains(SearchUserInput[2]))
                                      .Select(tasks => tasks).Where(task => task.Contributor.Contains(SearchUserInput[3]));
            return searchQuery.ToList();
        }
    }
}