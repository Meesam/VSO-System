using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface IProjectItem
    {
        public void AddProjectItem(ProjectItem projectItem);

        public void UpdateProjectItem(ProjectItem projectItem);

        public void DeleteProjectItem(int itemId);

        public List<ProjectItem> GetAllProjectItem(int projectId);

        public ProjectItem GetProjectItemById(int itemId);
    }
}
