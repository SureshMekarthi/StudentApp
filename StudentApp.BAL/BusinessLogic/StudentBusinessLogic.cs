using StudentApp.Core.Dto;
using StudentApp.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.BAL.BusinessLogic
{
    public class StudentBusinessLogic
    {
        public StudentBusinessLogic() { }

        public int AddStudent(StudentDto student)
        {
            StudentService studentServices = new StudentService();
            return studentServices.AddStudent(student);

        }

        public bool UpdateStudent(StudentDto student)
        {
            StudentService studentServices = new StudentService();
            return studentServices.UpdateStudent(student);

        }

        public StudentDto GetStudent(int Id)
        {
            StudentService studentServices = new StudentService();
            return studentServices.GetStudent(Id);

        }

        public List<StudentDto> GetStudents()
        {
            StudentService studentServices = new StudentService();
            return studentServices.GetStudentList();

        }

        public bool Delete(StudentDto student)
        {
            StudentService studentServices = new StudentService();
            return studentServices.DeleteStudent(student);

        }
    }
}
