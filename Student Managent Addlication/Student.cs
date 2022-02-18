using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managent_Addlication
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _major;

        public Student(string id,
          string name,
          string Major)
        {
            this._id = id;
            this._name = name;
            this._major = Major;
        }

        public string getId() { return this._id; }
        public string getName() { return this._name; }
        public string getMajor() { return this._major; }
    }
}
