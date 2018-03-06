using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vp_Assigment__01
{
    class AttendeceData
    {
        private string studentID;
        private string studentName;
        private string attenState;

        public void setAttendeceStates(string n)
        {
            attenState = n;
        }
        public void setStudentID(string id)
        {
            studentID = id;
        }
        public void setStudentName(string name)
        {
            studentName = name;
        }

        ////////
        public string getAttendeceStatus()
        {
            return attenState;
        }
        public string getStudentID()
        {
            return studentID;
        }
        public string getStudentName()
        {
            return studentName;
        }

    }
}
