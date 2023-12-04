using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSO.DataAccess.Repositories.Interfaces;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Implementation
{
    public class ProjectItemImpelement : IProjectItem
    {
        public void AddProjectItem(ProjectItem projectItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public List<ProjectItem> GetAllProjectItem(int projectId)
        {
            throw new NotImplementedException();
        }

        public ProjectItem GetProjectItemById(int itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProjectItem(ProjectItem projectItem)
        {
            throw new NotImplementedException();
        }
    }
}
