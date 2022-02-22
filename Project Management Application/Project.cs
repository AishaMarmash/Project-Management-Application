using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class Project
    {
        public string Project_name { get; set; }  
        List<Task> tasks = new List<Task>();
        public List<string> Users { get; set; }
        public Project(string name)

        {
            this.Project_name = name;
        }
        public Project(string name,string []users)
        {
            this.Project_name = name;
            Users = users.ToList();
        }
        public Project(string name, string[] users, List<Task> tasks)
        {
            this.Project_name = name;
            Users = users.ToList();
            foreach (var task in tasks)
            {
                this.tasks.Add(task);
            }
        }
        public void Add_User(string username)
        {
            Users.Add((string)username);
        }
        public void Add_Task(Task task)
        {
            this.tasks.Add(task);
        }
        public void print_project_info()
        {
            Console.WriteLine("project name : "+Project_name+" \n it has "+ Users.Count+" users and they are :"+ string.Join(", ", Users)
                + "\n It consists of multiple tasks:");
            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
