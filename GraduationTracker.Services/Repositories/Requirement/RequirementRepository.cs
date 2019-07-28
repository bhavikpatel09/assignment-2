﻿using GraduationTracker.Models;
using System.Collections.Generic;

namespace GraduationTracker.Services
{
    public class RequirementRepository : IRequirementRepository
    {
        public virtual List<Requirement> All()
        {
            return DbSet.Requirements;
        }
        public virtual Requirement GetById(int id)
        {
            return DbSet.Requirements.Find(x => x.Id == id);
        }
        public virtual void Add(Requirement entity)
        {
            DbSet.Requirements.Add(entity);
        }
        public virtual void Update(Requirement entity)
        {
            if (entity != null)
            {
                var index = DbSet.Requirements.FindIndex(x => x.Id == entity.Id);
                DbSet.Requirements[index] = entity;
            }
        }
        public virtual void Delete(Requirement entity)
        {
            if (entity != null)
            {
                var index = DbSet.Requirements.FindIndex(x => x.Id == entity.Id);
                DbSet.Requirements.RemoveAt(index);
            }
        }
    }
}
