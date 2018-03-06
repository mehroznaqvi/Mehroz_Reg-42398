using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vp_Assigment__01
{
    class Student
    {
        private string studentID;
        private string studentName;
        private string semseter;
        private string CGPA;
        private string  Dept;
        private string University;
        

        
        public void setStudentID(string Id)
        {
            this.studentID = Id;
        }
        public void setStudentName(string name)
        {
            this.studentName = name;
        }
        public void setSemester(string semester)
        {
            this.semseter = semester;
        }
        public void setCGPA(string cgpa)
        {
            this.CGPA = cgpa;
        }
        public void setDepartament(string dept)
        {
            this.Dept = dept;
        }
        public void setUnivarsity(string uni)
        {
            this.University = uni;
        }
       
        
        /////// getter Motheds

        public string getStudentID()
        {
            return this.studentID;
        }

        public string getStudentName()
        {
            return this.studentName;
        }

        public string getSemester()
        {
            return this.semseter;
        }

        public string getCGPA()
        {
            return this.CGPA;
        }
        public string getDepartment()
        {
            return this.Dept;
        }
        public string getUniversity()
        {
            return this.University;
        }
       

    }
}
