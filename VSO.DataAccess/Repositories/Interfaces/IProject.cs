using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface IProject
    {
        public void AddProject(Project project);

        public void UpdateProject(Project project);

        public void DeleteProject(int id);

        public List<Project> GetAllProject();

        public Project GetProjectById(int id);
    }
}
