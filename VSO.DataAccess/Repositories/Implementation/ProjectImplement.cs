using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSO.DataAccess.Data;
using VSO.DataAccess.Repositories.Interfaces;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Implementation
{
    public class ProjectImplement : IProject
    {
        private readonly VsoDbConetxt _context;

        public ProjectImplement(VsoDbConetxt context)
        {
            _context = context;
        }

        public void AddProject(Project project)
        {
            try
            {
                _context.Projects.Add(project);
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProject(int id)
        {
            try
            {
                var project = _context.Projects.FirstOrDefault(c => c.Id == id);
                if (project != null)
                {
                    _context.Projects.Remove(project);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Project GetProjectById(int id)
        {
            try
            {
                var project = _context.Projects.FirstOrDefault(c => c.Id == id);
                if (project == null)
                {
                    return null;
                }
                else { return project; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProject(Project project)
        {
            try
            {
                var projectData = _context.Projects.FirstOrDefault(c => c.Id == project.Id);
                if (projectData != null)
                {
                    _context.Projects.Update(project);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       public Task<IQueryable<Project>> GetAllProject()
       {
            try
            {
                return Task.FromResult(_context.Projects.AsQueryable());
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
