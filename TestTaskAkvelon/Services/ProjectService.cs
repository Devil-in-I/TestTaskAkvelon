using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTaskAkvelon.Data;
using TestTaskAkvelon.Models;

namespace TestTaskAkvelon.Services
{
    public interface IProjectService
    {
        void Add(ProjectModel project);

        void Update(ProjectModel project);

        void Delete(int id);

        List<ProjectModel> GetAll();

        ProjectModel Get(int id);
    }

    public class ProjectService : ServiceBase, IProjectService
    {
        private ApplicationContext db = new ApplicationContext();
        private List<ProjectModel> _projects;

        public ProjectService()
        {

        }

        public void Add(ProjectModel project)
        {
            db.ProjectModels.Add(project);
            db.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProjectModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectModel project)
        {
            throw new NotImplementedException();
        }
    }
}