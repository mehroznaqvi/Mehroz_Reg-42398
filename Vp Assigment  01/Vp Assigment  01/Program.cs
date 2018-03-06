using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vp_Assigment__01
{
    class Program
    {

        public string filepath;
        public void location(int x,int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            string path = args[0];
            char loop='y';
            Attendance atten = new Attendance();
            do
            {
                // StreamWriter filePath = new StreamWriter("StuentProfile.txt");
                Program obj = new Program();
                Console.ForegroundColor = ConsoleColor.Yellow;
                obj.location(50, 8);
                Console.WriteLine("1. Create Student profile");
                obj.location(50, 10);
                Console.WriteLine("2. Search Student");
                obj.location(50, 12);
                Console.WriteLine("3. Delete Student Record");
                obj.location(50, 14);
                Console.WriteLine("4. List top 03 of class");
                obj.location(50, 16);
                Console.WriteLine("5. Mark student attendance");
                obj.location(50, 18);
                Console.WriteLine("6. View attendance");
                obj.location(52, 22);
                Console.WriteLine("_____________\b\b\b\b\b");
                obj.location(58, 22);
                char option;
                option = Console.ReadKey().KeyChar;
                if (option == '1')
                {
                    char loopDecision;
                    List<Student> list = new List<Student>();
                    do
                    {
                        char chack = '0';
                        Console.Clear();
                        string getData = "";
                        Student stu = new Student();
                        Console.Write("Enter Student Enrollment:: ");
                        getData = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {

                            if (line.Trim() == getData.Trim())
                            {
                                Console.WriteLine("Please use the Unire ID");
                                chack = '1';
                                System.Console.ReadKey();
                                break;
                            }

                        } read.Close();
                        if (chack == '0')
                        {
                            stu.setStudentID(getData);
                            getData = null;
                            Console.Write("Enter Student Name:: ");
                            getData = Console.ReadLine();
                            stu.setStudentName(getData);
                            getData = null;
                            Console.Write("Enter Student semester:: ");
                            getData = Console.ReadLine();
                            stu.setSemester(getData);
                            getData = null;
                            Console.Write("Enter Student CGPA:: ");
                            getData = Console.ReadLine();
                            stu.setCGPA(getData);
                            getData = null;
                            Console.Write("Enter Student Department::");
                            getData = Console.ReadLine();
                            stu.setDepartament(getData);
                            getData = null;
                            Console.Write("Enter Student University:: ");
                            getData = Console.ReadLine();
                            stu.setUnivarsity(getData);
                            getData = null;

                            list.Add(stu);
                        }
                        Console.Clear();
                        Console.WriteLine("Again (Y/N)?");
                        loopDecision = Console.ReadKey().KeyChar;
                        Console.Clear();


                    } while (loopDecision == 'y' || loopDecision == 'Y');

                    foreach (var item in list)
                    {
                        StreamWriter file = File.AppendText(path);
                        file.AutoFlush = true;
                        file.Write(item.getStudentID() + "\t");
                        file.Write("\r" + item.getStudentName() + "\t");
                        file.Write("\r" + item.getSemester() + "\t");
                        file.Write("\r" + item.getCGPA() + "\t");
                        file.Write("\r" + item.getDepartment() + "\t");
                        file.Write("\r" + item.getUniversity() + "\t");
                        file.WriteLine();
                        file.Close();
                    }
                    //string line;
                    //StreamReader read=new StreamReader("StuentProfile.txt");
                    //while((line=read.ReadLine())!=null)
                    //{
                    //    Console.WriteLine(line);
                    //    System.Console.ReadKey();
                    //}


                }
                    //Search *******************
                else if (option == '2')
                {
                    int countStudent = 0; ;
                    Console.Clear();
                    obj.location(50, 8);
                    Console.WriteLine("1. Search by Student ID");
                    obj.location(50, 10);
                    Console.WriteLine("2. Search By Student Name");
                    obj.location(50, 12);
                    Console.WriteLine("3. Search By Department");
                    obj.location(50, 14);
                    char searchOption;
                    searchOption = Console.ReadKey().KeyChar;
                    if(searchOption== '1')
                    {
                        Console.Clear();
                        Console.Write("Enter The ID of The Student:: ");
                        string StudenID;
                        StudenID = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {
                            if (StudenID.Trim() == line.Trim())
                          {
                              Console.Write(line);
                              line = read.ReadLine().Trim();
                              Console.Write(line+"\t");
                              line = read.ReadLine().Trim();
                              Console.Write(line + "\t");
                              line = read.ReadLine().Trim();
                              Console.Write(line + "\t");
                              line = read.ReadLine().Trim();
                              Console.Write(line + "\t");
                              line = read.ReadLine().Trim();
                              Console.Write(line + "\t");
                              Console.WriteLine();
                              read.Close();
                              break;
                          }

                            for(int i=1; i<6; i++)
                            {
                                line=read.ReadLine();

                            }

                            
                        }

                    }
                    else if(searchOption=='2')
                    {

                        
                        Console.Clear();
                        Console.Write("Enter The Name of The Student:: ");
                        string name;
                        name = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        string temp=read.ReadLine();
                      //  Console.WriteLine(temp);
                        while ((line = read.ReadLine()) != null)
                        {
                            
                            if(name==line.Trim())
                            {
                                Console.Write(temp+"\t");
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                read.Close();
                                Console.WriteLine();
                                break;
                            }

                            for (int i = 1; i < 6; i++)
                            {
                                line = read.ReadLine();
                                temp = line;

                            }
                        }

                    }
                    else if (searchOption == '3')
                    {
                        Console.Clear();
                        
                        Console.Write("Enter The Department of The Student:: ");
                        string dept;
                        dept = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {
                            
                            Student obj1 = new Student();
                            obj1.setStudentID(line);
                            line = null;
                            line = read.ReadLine();
                            obj1.setStudentName(line);
                            line = null;
                            line = read.ReadLine();
                            obj1.setSemester(line);
                            line = null;
                            line = read.ReadLine();
                            obj1.setCGPA(line);
                            line = null;
                            line = read.ReadLine();
                            string tem = line.Trim();
                            if (dept == tem)
                            {
                                Console.Write(obj1.getStudentID() + "\t");
                                Console.Write(obj1.getStudentName() + "\t");
                                Console.Write(obj1.getSemester() + "\t");
                                Console.Write(obj1.getCGPA() + "\t");
                                Console.Write(line.Trim() + "\t");
                                //Console.WriteLine(obj1.getStudentName());
                                line = read.ReadLine();
                                Console.Write(line + "\t");
                                Console.WriteLine();
                                countStudent++;
                                
                            }
                            else
                            {
                                line = read.ReadLine();
                                
                            }

                        }
                        read.Close();
                        Console.WriteLine("The Number of Student Found::" + countStudent);

                    }

                }

                //End Search ******************8
                // Delete Recorded******************
                else if(option=='3')
                {
                    DeleteRecord DR = new DeleteRecord();
                    DR.deleteRecord(path);
                }
                else if (option == '4')
                {
                    Top_Three_Student TTS = new Top_Three_Student();
                    TTS.TopStudent(path);
                }
                else if (option == '5')
                {
                   
                    atten.Attend(path);
                }

                else if (option == '6')
                {
                    
                    atten.ViewAtten();
                }



                // Console.Clear();
                Console.WriteLine("Again(y/n)");
                loop = Console.ReadKey().KeyChar;
            } while (loop == 'y' || loop == 'Y');
        }
    }
}
