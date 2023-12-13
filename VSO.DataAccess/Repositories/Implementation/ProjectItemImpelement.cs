using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using VSO.DataAccess.Data;
using VSO.DataAccess.Repositories.Interfaces;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Implementation
{
    public class ProjectItemImpelement : IProjectItem
    {

        private readonly VsoDbConetxt _context;

        public ProjectItemImpelement(VsoDbConetxt context)
        {
            _context = context;
        }
        public void AddProjectItem(ProjectItem projectItem)
        {
            try
            {
                _context.ProjectItems.Add(projectItem);
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProjectItem(int itemId)
        {
            try
            {
                var projectItems = _context.ProjectItems.FirstOrDefault(c => c.Id == itemId);
                if (projectItems != null)
                {
                    _context.ProjectItems.Remove(projectItems);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProjectItem GetProjectItemById(int itemId)
        {
            try
            {
                var projectItems = _context.ProjectItems.FirstOrDefault(c => c.Id == itemId);
                if (projectItems == null)
                {
                    return null;
                }
                else { return projectItems; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProjectItem(ProjectItem projectItem)
        {
            try
            {
                var projectItemData = _context.ProjectItems.FirstOrDefault(c => c.Id == projectItem.Id);
                if (projectItemData != null)
                {
                    _context.ProjectItems.Update(projectItem);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<IQueryable<ProjectItem>> GetAllProjectItem(int projectId)
        {
            try
            {
                return Task.FromResult(_context.ProjectItems.AsQueryable());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
