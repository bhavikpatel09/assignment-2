using GraduationTracker.Models;
using System.Collections.Generic;

namespace GraduationTracker.Services
{
    public class DiplomaRepository : IDiplomaRepository
    {
        public virtual List<Diploma> All()
        {
            return DbSet.Diplomas;
        }
        public virtual Diploma GetById(int id)
        {
            return DbSet.Diplomas.Find(x => x.Id == id);
        }
        public virtual void Add(Diploma entity)
        {
            DbSet.Diplomas.Add(entity);
        }
        public virtual void Update(Diploma entity)
        {
            if (entity != null)
            {
                var index = DbSet.Diplomas.FindIndex(x => x.Id == entity.Id);
                DbSet.Diplomas[index] = entity;
            }
        }
        public virtual void Delete(Diploma entity)
        {
            if (entity != null)
            {
                var index = DbSet.Diplomas.FindIndex(x => x.Id == entity.Id);
                DbSet.Diplomas.RemoveAt(index);
            }
        }
    }
}
