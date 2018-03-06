using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vp_Assigment__01
{
    class DeleteRecord
    {

        public void deleteRecord(string path)
        {
            Console.Clear(); 
            Console.WriteLine("Enter the ID to Delete::");
            string ID=Console.ReadLine();
            Console.Clear(); 
            string line;
            StreamReader read = new StreamReader(path);
            List<Student> list = new List<Student>();
                    while((line=read.ReadLine())!=null)
                    {
                        Student stu = new Student();
                        stu.setStudentID(line.Trim());
                        line = read.ReadLine();
                        stu.setStudentName(line.Trim());
                        line = read.ReadLine();
                        stu.setSemester(line.Trim());
                        line = read.ReadLine();
                        stu.setCGPA(line.Trim());
                        line = read.ReadLine();
                        stu.setDepartament(line.Trim());
                        line = read.ReadLine();
                        stu.setUnivarsity(line.Trim());
                        list.Add(stu);
                    } read.Close();


                    StreamWriter file = new StreamWriter(path);
         file.AutoFlush = true;
         char ch = '0';

          foreach (var item in list)
            {
                
                if (ID != item.getStudentID())
                {
                    
                    
                    file.Write(item.getStudentID() + "\t");
                    file.Write("\r" + item.getStudentName() + "\t");
                    file.Write("\r" + item.getSemester() + "\t");
                    file.Write("\r" + item.getCGPA() + "\t");
                    file.Write("\r" + item.getDepartment() + "\t");
                    file.Write("\r" + item.getUniversity() + "\t");
                    file.WriteLine();
                    
                }
                else
                {
                    ch = '1';
                }
            } file.Close();
            if(ch=='0')
            {
                Console.WriteLine("No record Found Against ID::" + ID);
            }
           // var lines = File.ReadAllLines("StuentProfile.txt").Where(line => line.Trim() != item).ToArray();
           // File.WriteAllLines("StuentProfile.txt", lines);
           // Console.WriteLine(lines.ToArray().ToString());
        }
    }
}
