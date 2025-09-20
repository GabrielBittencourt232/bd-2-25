using Aula01.Models;

namespace Aula01.Repository
{
    public interface IStudentCoursesRepository
    {
        public Task Create(StudentCourses studentCourse);
        public Task Update(StudentCourses studentCourse);
        public Task Delete(StudentCourses studentCourse);

        public Task<List<StudentCourses?>> GetByStudentId(int studentId);
        public Task<List<StudentCourses?>> GetByCourseId(int courseId);
        public Task<List<StudentCourses?>> Get(int StudentId, int courseId);
        public Task<List<StudentCourses>> GetAll();
        public Task<List<StudentCourses>> GetByCourseName(string name);
    }
}
