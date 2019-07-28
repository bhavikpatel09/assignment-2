using GraduationTracker.Models;
using System.Collections.Generic;

namespace GraduationTracker.Services
{
    public class StudentRepository : IStudentRepository
    {
        public virtual List<Student> All()
        {
            return DbSet.Students;
        }
        public virtual Student GetById(int id)
        {
            return DbSet.Students.Find(x => x.Id == id);
        }
        public virtual void Add(Student entity)
        {
            DbSet.Students.Add(entity);
        }
        public virtual void Update(Student entity)
        {
            if (entity != null)
            {
                var index = DbSet.Students.FindIndex(x => x.Id == entity.Id);
                DbSet.Students[index] = entity;
            }
        }
        public virtual void Delete(Student entity)
        {
            if (entity != null)
            {
                var index = DbSet.Students.FindIndex(x => x.Id == entity.Id);
                DbSet.Students.RemoveAt(index);
            }
        }
    }
}
