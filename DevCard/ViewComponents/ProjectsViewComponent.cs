using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>
            {
                new Project(1,"ali","dhfasdf","sdf","project-1.jpg"),
                new Project(2,"ali 2 ","dhfgggggggggggasdf","sdfsdf sdf ","project-1.jpg"),
                new Project(3,"ali 34","dhfdddddddddasdf","sdf2222","project-1.jpg"),
                new Project(4,"ali 54","dhfvvvvvvvvvvvvasdf","saaaadf","project-1.jpg"),
            };

            return View("Projects", project);
        }
    }
}
