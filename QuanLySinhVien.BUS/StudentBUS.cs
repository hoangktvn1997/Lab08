using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagement.DAL;

namespace StudentsManagement.BUS
{
    class StudentBUS
    {
        StudentBUS studentBus = new StudentBUS();

        /// <summary>
        /// Lấy tất cả danh sách sinh viên
        /// </summary>
        /// <returns></returns>
        public List<Student> LoadStudents()
        {
            return studentBus.LoadStudents();
        }
    }
}
