using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class Project
    {
        public string ProjectName { get; set; }  
        public List<string> Users { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string name)
        {
            this.ProjectName = name;
            this.Users = new List<string>();
            this.Tasks = new List<Task>();
        }
        public Project(string name,List<string> users)
        {
            this.ProjectName = name;
            this.Users = users.ToList();
            this.Tasks = new List<Task>();
        }
        public Project(string name, List<Task> tasks)
        {
            this.ProjectName = name;
            this.Users = new List<string>();
            this.Tasks = tasks.ToList();
        }
        public Project(string name, List<string> users, List<Task> tasks)
        {
            this.ProjectName = name;
            Users = users.ToList();
            Tasks = tasks.ToList();
        }
        public void AddUser(string username)
        {
            Users.Add(username);
        }
        public void Add_Task(Task task)
        {
            Tasks.Add(task);
        }
        public void PrintProjectInfo()
        {
            //if ((this.Users != null) && (this.Tasks.Count!=0))
            //{
                Console.WriteLine($"project name : {ProjectName}{Environment.NewLine}" +
                    $"it has {Users.Count} users and they are :{ string.Join(", ", Users)}{Environment.NewLine}" +
                    $"It consists of multiple tasks:");
                foreach (var item in Tasks)
                {
                    Console.WriteLine(item);
                }
            //}
        }
    }
}
