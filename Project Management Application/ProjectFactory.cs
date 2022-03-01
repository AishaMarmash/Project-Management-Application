﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class ProjectFactory
    {
        public static Project BuildProject(string projectName, List<string> users, List<Task> tasks)
        {
            Project project = new(projectName, users, tasks);
            return project;
        }
        public static Project BuildProject(string projectName, List<string> users)
        {
            Project project = new(projectName, users);
            return project;
        }
        public static Project BuildProject(string projectName, List<Task> tasks)
        {
            Project project = new(projectName, tasks);
            return project;
        }
        public static Project BuildProject(string projectName)
        {
            Project project = new(projectName);
            return project;
        }
    }
}
