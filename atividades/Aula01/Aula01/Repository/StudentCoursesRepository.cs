using Aula01.Data;
using Aula01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace Aula01.Repository
{
    public class StudentCoursesRepository : IStudentCoursesRepository
    {
        private readonly SchoolContext _schoolContext;
        public async Task Create(StudentCourses studentCourse)
        {
           await _schoolContext.StudentCourses.AddAsync(studentCourse);
           await _schoolContext.SaveChangesAsync();
        }

        public async Task Delete(StudentCourses studentCourse)
        {
         _schoolContext.StudentCourses.Remove(studentCourse);
            await _schoolContext.SaveChangesAsync();
        }

        public async Task<List<StudentCourses?>> Get(int StudentId, int courseId)
        {
            var data = await _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .Where(w => w.StudentID == StudentId && w.CourseID == courseId)
                .FirstOrDefaultAsync();
            return data;
        }

        public Task<List<StudentCourses>> GetAll()
        {
            var data = _schoolContext.StudentCourses
                .Include(x => x.Course)
                .Include(x => x.Student)
                .FirstOrDefault();
            return data;
        }

        public Task<StudentCourses?> GetByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentCourses>> GetByCourseName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<StudentCourses?> GetByStudentId(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task Update(StudentCourses studentCourse)
        {
            throw new NotImplementedException();
        }
    }
}
