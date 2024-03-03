using StudentApp.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DAL.Services
{
    public class StudentService
    {
        public List<StudentDto> GetStudentList()
        {
            List<StudentDto> lobjResponse = new List<StudentDto>();
            using (StudentDbEntities dbcontext = new StudentDbEntities())
            {
                try
                {
                    var res = dbcontext.SudentDetails.ToList();
                    foreach (var student in res)
                    {
                        lobjResponse.Add(new StudentDto() { Id = student.StudentId, Address = student.Address, FirstName = student.FirstName, LastName = student.LastName, PhoneNumber = student.PhoneNumber });
                    }

                }
                catch (Exception ex)
                {
                }
            }
            return lobjResponse;
        }

        public StudentDto GetStudent(int id)
        {
            StudentDto lobjResponse = new StudentDto();
            using (StudentDbEntities dbcontext = new StudentDbEntities())
            {
                try
                {
                    var res = dbcontext.SudentDetails.Find(id);
                    lobjResponse = new StudentDto() { Id = res.StudentId, Address = res.Address, FirstName = res.FirstName, LastName = res.LastName, PhoneNumber = res.PhoneNumber };

                }
                catch (Exception ex)
                {
                }
            }
            return lobjResponse;
        }


        public int AddStudent(StudentDto student)
        {
            int Id = 0;
            using (StudentDbEntities dbcontext = new StudentDbEntities())
            {
                try
                {
                    SudentDetail sudentDetail = new SudentDetail() { Address = student.Address, LastName = student.LastName, FirstName = student.FirstName, PhoneNumber = student.PhoneNumber };
                    dbcontext.SudentDetails.Add(sudentDetail);
                    dbcontext.SaveChanges();
                    Id = sudentDetail.StudentId; 

                }
                catch (Exception ex)
                {
                }
            }
            return Id;
        }

        public bool UpdateStudent(StudentDto student)
        {
            using (StudentDbEntities dbcontext = new StudentDbEntities())
            {
                try
                { 
                    var res = dbcontext.SudentDetails.Find(student.Id);
                    res.Address = student.Address;
                    res.PhoneNumber = student.PhoneNumber;
                    res.FirstName = student.FirstName;
                    res.LastName = student.LastName;
                    dbcontext.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                }
            }
            return false;
        }


        public bool DeleteStudent(StudentDto student)
        {
            using (StudentDbEntities dbcontext = new StudentDbEntities())
            {
                try
                {
                    var res = dbcontext.SudentDetails.Find(student.Id);
                    dbcontext.SudentDetails.Remove(res);
                    dbcontext.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                }
            }
            return false;
        }
    }
}

