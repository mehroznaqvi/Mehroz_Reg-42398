using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vp_Assigment__01
{
    public class Attendance
    {
        public string Path;


        public Attendance()
        {
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("dd/MM/yyyy");
            string[] dat = new string[2];
            dat = date.Split('/');
            string filePath = dat[0] + "-";
            filePath += dat[1] + "-";
            filePath += dat[2] + ".txt";
            Path = filePath;
        }
        public void Attend(string path)
        {
            Console.Clear();
            
            StreamWriter atten =new StreamWriter(@Path);
            List<AttendeceData> list = new List<AttendeceData>();
            string line;
            StreamReader read = new StreamReader(path);
            Console.Write("Enter the Semester like(one ,two):: ");
            string sem=Console.ReadLine();
            sem.Trim();
            string temSem;
            while ((line = read.ReadLine()) != null)
            {
                AttendeceData stu = new AttendeceData();

                stu.setStudentID(line.Trim());
                line = read.ReadLine();
                stu.setStudentName(line.Trim());
                line = read.ReadLine();
                temSem = line.Trim();
                if (temSem == sem)
                {
                    list.Add(stu);
                    stu.setAttendeceStates(null);
                }
                read.ReadLine();
                read.ReadLine();
                read.ReadLine();


            } read.Close();
            int x,y;
            x=30;
            y=8;
            Console.Clear();
            Console.Write("\n\n\n\n\t\t\t\t\t\t Marks Attendance\n\n\n");

            atten.AutoFlush = true;
            foreach(var item in list)
            { 
                Console.SetCursorPosition(x, y);

                Console.Write(item.getStudentID() + "\t");
                Console.Write(item.getStudentName()+"\t");

                atten.Write(item.getStudentID()+"\t");
                atten.Write(item.getStudentName()+"\t");
                char status;
                Console.Write("(Y/N)::");
                status =Console.ReadKey().KeyChar;
                if (status == 'Y' || status == 'y')
                {
                    atten.Write("Yes");
                }
                else {
                    atten.Write("No");
                
                }
                atten.WriteLine();
                y += 2;
            } atten.Close();

            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t Press any key ");
            Console.ReadKey();
            Console.Clear();
        }
        public void ViewAtten()
        {

            Console.Clear();
            string line;
            StreamReader read = new StreamReader(@Path);
            List<AttendeceData> list = new List<AttendeceData>();
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            } read.Close();




        }



    }
}
