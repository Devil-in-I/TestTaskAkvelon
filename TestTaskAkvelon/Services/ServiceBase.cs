using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestTaskAkvelon.Models;

namespace TestTaskAkvelon.Services
{
    public abstract class ServiceBase
    {
        public int GetMaxId(List<IIdentifiable> entities)
        {
            if (entities == null || !entities.Any())
            {
                return 0;
            }

            return entities.Max(e => e.Id);
        }

        public string GetStoragePath(string filename)
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\{filename}";
        }
    }
}