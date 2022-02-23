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
        private List<Task> _tasks = new();
        public List<string>? Users { get; set; }

        public Project(string name)
        {
            this.ProjectName = name;
        }
        public Project(string name,string []users)
        {
            this.ProjectName = name;
            this.Users = users.ToList();
        }
        public Project(string name, string[] users, List<Task> tasks)
        {
            this.ProjectName = name;
            Users = users.ToList();
            foreach (var task in tasks)
            {
                this._tasks.Add(task);
            }
        }
        public void AddUser(string username)
        {
            Users.Add(username);
        }
        public void Add_Task(Task task)
        {
            this._tasks.Add(task);
        }
        public void PrintProjectInfo()
        {
            if ((Users != null) && (_tasks.Count!=0))
            {
                Console.WriteLine($"project name : {ProjectName} \n it has {Users.Count} users and they are :{ string.Join(", ", Users)} \n It consists of multiple tasks:");
                foreach (var item in _tasks)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
