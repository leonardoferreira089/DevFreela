using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Projeto 1", "Primeiro projeto do sistema", 1, 1, 10000)
            };

            Users = new List<User>()
            {
                new User("Wanderlei", "wanderlei@gmail.com", new DateTime(1992,1,1))
            };

            Skills = new List<Skill>()
            {
                new Skill(".Net Core"),
                new Skill("C#")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
