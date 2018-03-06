using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Vp_Assigment__01
{
    class Top_Three_Student
    {
        public void TopStudent(string path)
        {
            Console.Write("Enter the department(se,ss)::");
            string dept = Console.ReadLine();


            string trim;
            double first, second, third;
            first = second = third = 0;
            Console.Clear();
            string line;
            StreamReader read = new StreamReader(path);
            List<Student> list = new List<Student>();
            while ((line = read.ReadLine()) != null)
            {
                Student stu = new Student();

                stu.setStudentID(line.Trim());
                line = read.ReadLine();
                stu.setStudentName(line.Trim());
                line = read.ReadLine();
                stu.setSemester(line.Trim());
                line = read.ReadLine();
                trim = line.Trim();
                stu.setCGPA(trim);
                line = read.ReadLine();
                stu.setDepartament(line.Trim());
                line = read.ReadLine();
                stu.setUnivarsity(line.Trim());
                string tem = stu.getDepartment();
                if (tem.Equals(dept))
                {
                    list.Add(stu);
                }
                
            } read.Close();
           
            
            Student obj=list[0];
            first = double.Parse(obj.getCGPA());
            int count = 0;
            foreach(var stu in list)
            {
                if (first <= double.Parse(stu.getCGPA()))
                {
                    first = double.Parse(stu.getCGPA());
                    count++; 
                }

            }
            //Console.WriteLine(count);
            foreach (var stu in list)
            {
                if (first > double.Parse(stu.getCGPA()))
                {
                    if(second<double.Parse(stu.getCGPA()))
                    {
                        second = double.Parse(stu.getCGPA());
                    }
                }

            }


            foreach (var stu in list)
            {
                if (first > double.Parse(stu.getCGPA()))
                {
                    if (second > double.Parse(stu.getCGPA()))
                    {
                        if (third < double.Parse(stu.getCGPA()))
                        {
                            third = double.Parse(stu.getCGPA());
                        }
                    }
                }

            }


            foreach (var stu in list)
            {
                if (first == double.Parse(stu.getCGPA()) || second == double.Parse(stu.getCGPA()) || third == double.Parse(stu.getCGPA()))
                {

                    Console.Write(stu.getStudentID() + "\t");
                    Console.Write(stu.getStudentName() + "\t");
                    Console.Write(stu.getSemester() + "\t");
                    Console.Write(stu.getCGPA() + "\t");
                    Console.Write(stu.getDepartment() + "\t");
                    Console.Write(stu.getUniversity()+"\t");
                    Console.WriteLine();

                }

            }




           
            
        }
    }
}
