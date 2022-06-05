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
            DateTime startDate1 = DateTime.Parse("1/06/2022");
            DateTime startDate2 = DateTime.Parse("5/06/2022");
            DateTime startDate3 = DateTime.Parse("1/06/2022");

            DateTime expDate1 = startDate1 + TimeSpan.FromDays(10);
            DateTime expDate2 = startDate2 + TimeSpan.FromDays(10);
            DateTime expDate3 = startDate3 + TimeSpan.FromDays(2);

            context.ProjectModels.AddOrUpdate(
              p => p.Id,
              new ProjectModel { Id = 1, Name = "Project 1", StartDate =  startDate1, CompletionDate = expDate1, ProjectStatus = ProjectStatus.Active, Priority = 10},
              new ProjectModel { Id = 2, Name = "Project 2", StartDate = startDate2, CompletionDate = expDate2, ProjectStatus = ProjectStatus.NotStarted, Priority = 5 },
              new ProjectModel { Id = 3, Name = "Project 3", StartDate = startDate3, CompletionDate = expDate3, ProjectStatus = ProjectStatus.Completed, Priority = 3 }
            );


            context.TaskModels.AddOrUpdate(
                t => t.Id,
                // Task for project 1
                new TaskModel() { Id = 1, Name = "Task 1", Description = "Some description for task 1", TaskStatus = TaskStatus.ToDO, Priority = 5, ProjectId = 1 },
                new TaskModel() { Id = 2, Name = "Task 2", Description = "Some description for task 2", TaskStatus = TaskStatus.InProgress, Priority = 5, ProjectId = 1 },
                new TaskModel() { Id = 3, Name = "Task 3", Description = "Some description for task 3", TaskStatus = TaskStatus.Done, Priority = 5, ProjectId = 1 },
                // Tasks for project 2
                new TaskModel() { Id = 4, Name = "Task 4", Description = "Some description for task 4", TaskStatus = TaskStatus.ToDO, Priority = 5, ProjectId = 2 },
                new TaskModel() { Id = 5, Name = "Task 5", Description = "Some description for task 5", TaskStatus = TaskStatus.ToDO, Priority = 5, ProjectId = 2 },
                new TaskModel() { Id = 6, Name = "Task 6", Description = "Some description for task 6", TaskStatus = TaskStatus.ToDO, Priority = 5, ProjectId = 2 },
                // Tasks for project 3
                new TaskModel() { Id = 7, Name = "Task 7", Description = "Some description for task 7", TaskStatus = TaskStatus.Done, Priority = 5, ProjectId = 3 },
                new TaskModel() { Id = 8, Name = "Task 8", Description = "Some description for task 8", TaskStatus = TaskStatus.Done, Priority = 5, ProjectId = 3 },
                new TaskModel() { Id = 9, Name = "Task 9", Description = "Some description for task 9", TaskStatus = TaskStatus.Done, Priority = 5, ProjectId = 3 }
                );

        }
    }
}
