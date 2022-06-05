using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TestTaskAkvelon.Data;
using TestTaskAkvelon.Models;

namespace TestTaskAkvelon.Controllers
{
    public class ProjectController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/Project
        public IQueryable<ProjectModel> GetProjectModels()
        {
            return db.ProjectModels;
        }

        // GET: api/Project/5
        [ResponseType(typeof(ProjectModel))]
        public async Task<IHttpActionResult> GetProjectModel(int id)
        {
            ProjectModel projectModel = await db.ProjectModels.FindAsync(id);
            if (projectModel == null)
            {
                return NotFound();
            }

            return Ok(projectModel);
        }

        // PUT: api/Project/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProjectModel(int id, ProjectModel projectModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectModel.Id)
            {
                return BadRequest();
            }

            db.Entry(projectModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Project
        [ResponseType(typeof(ProjectModel))]
        public async Task<IHttpActionResult> PostProjectModel(ProjectModel projectModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProjectModels.Add(projectModel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = projectModel.Id }, projectModel);
        }

        // DELETE: api/Project/5
        [ResponseType(typeof(ProjectModel))]
        public async Task<IHttpActionResult> DeleteProjectModel(int id)
        {
            ProjectModel projectModel = await db.ProjectModels.FindAsync(id);
            if (projectModel == null)
            {
                return NotFound();
            }

            db.ProjectModels.Remove(projectModel);
            await db.SaveChangesAsync();

            return Ok(projectModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProjectModelExists(int id)
        {
            return db.ProjectModels.Count(e => e.Id == id) > 0;
        }
    }
}