using StudentsManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.DAL
{
    class StudentsContext
    {
        StudentManagementEntities dbcontext = new StudentManagementEntities();

        /// <summary>
        /// Lấy tất cả danh sách sinh viên
        /// </summary>
        /// <returns>ListStudens</returns>
        public List<Student> LoadStudents()
        {
            return dbcontext.Students.ToList();
        }
    }

    internal class QuanLySinhVienEntities
    {
    }
}
