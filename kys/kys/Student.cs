using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kys
{
    internal class Student
    {
        private int id;
        public string name;
        private int grade;
        private string kita;
        private char sex;

        public Student(int id, string name, string kita, char sex)
        {
            this.id = id;
            this.name = name;
            this.grade = -1;
            this.kita = kita;
            this.sex = sex;
        }
        public void setgrade(int grade)
        {
            this.grade = grade; 
        }

        public override string ToString() 
        {
            string write;
            if (grade > -1)
            {
                write = " name: " + this.name + " ,id: " + this.id + " ,grade:" + this.grade + " ,kita: " + this.kita + " ,sex: " + this.sex;
            }
            else {
                write = " name: " + this.name + " ,id: " + this.id + " ,grade: they have no grade yet" + " ,kita" + this.kita + " ,sex" + this.sex;
            }
            return write;

        }
        public bool bestGrade(Student other) {
            return this.grade > other.grade;
        } 
    }
}
