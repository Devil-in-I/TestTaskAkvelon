namespace TestTaskAkvelon.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestTaskAkvelon.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestTaskAkvelon.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestTaskAkvelon.Data.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            DateTime completionDate1 = DateTime.Parse("12/10/22");
            DateTime completionDate2 = DateTime.Parse("11/10/22");
            DateTime completionDate3 = DateTime.Parse("15/10/22");
            DateTime startDate = DateTime.Parse("10/10/22");
            DateTime startDate2 = DateTime.Parse("10/10/22");

            context.ProjectModels.AddOrUpdate(p => p.Id,

                new ProjectModel() { Id = 1, Name = "Project 1", CompletionDate = completionDate1, Priority = 10, ProjectStatus = ProjectStatus.Active, StartDate = startDate},
                new ProjectModel() { Id = 2, Name = "Project 2", CompletionDate = completionDate2, Priority = 10, ProjectStatus = ProjectStatus.Completed, StartDate = startDate },
                new ProjectModel() { Id = 3, Name = "Project 3", CompletionDate = completionDate3, Priority = 10, ProjectStatus = ProjectStatus.NotStarted, StartDate = startDate2 }
                );
                

            context.TaskModels.AddOrUpdate(t => t.Id,
                new TaskModel() { Id = 1, Name = "task 1", Description = "Some test task 1", Priority = 10, TaskStatus = TaskStatus.ToDO, ProjectId = 1},
                new TaskModel() { Id = 2, Name = "task 2", Description = "Some test task 2", Priority = 5, TaskStatus = TaskStatus.Done, ProjectId = 2 },
                new TaskModel() { Id = 3, Name = "task 3", Description = "Some test task 3", Priority = 7, TaskStatus = TaskStatus.InProgress, ProjectId = 1 },
                new TaskModel() { Id = 4, Name = "task 4", Description = "Some test task 4", Priority = 2, TaskStatus = TaskStatus.ToDO, ProjectId = 3 }
                );
        }
    }
}
