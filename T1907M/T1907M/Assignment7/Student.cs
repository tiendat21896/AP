using System;
using System.Collections.Generic;

namespace T1907M.Assignment7
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public string address;
        public double gpa;
        List<Student> st = new List<Student>();

        public Student()
        {
        }

        public Student(int id, string name, int age, string address, double gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public double Gpa
        {
            get => gpa;
            set => gpa = value;
        }
        
      public void addStudent(Student student)
        {
            st.Add(student);
        }

        public void editStudent(int id,string newname,string newaddress,int newage,double newgpa)
        {
            foreach (Student s in st)
            {
                if (id == s.Id)
                {
                    s.Name = newname;
                    s.Age = newage;
                    s.Address = newaddress;
                    s.Gpa = newgpa;
                    Console.WriteLine("Cap nhat thanh cong!");
                    return;
                }
            }
        }

        public void removeStudent(int id)
        {
            for (int i = 0; i < st.Count; i++)
            {
                if (id == st[i].Id)
                {
                    st.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong ");
                    return;
                }
            }
        }
        

        public void showStudent()
        {
            foreach (Student s in st)
            {
                Console.WriteLine("ID: "+s.Id+"\tName"+s.Name+"\tAge"+s.Age+"\tAddress: "+s.Address+"\tGPA:"+s.Gpa);
            }
        }

        public void sortByName()
        {
            st.Sort(delegate(Student student, Student student1)
            { 
                int compareName = student.Name.CompareTo(student1.Name);
                if (compareName == 0)
                {
                    return student.Id.CompareTo(student1.Id);
                }

                return compareName;
            });
        }
        public void sortByGPA()
        {
            st.Sort(delegate(Student student, Student student1)
            { 
                int compareGPA = student.Gpa.CompareTo(student1.Gpa);
                if (compareGPA == 0)
                {
                    return student.Id.CompareTo(student1.Id);
                }

                return compareGPA;
            });
        }
    }
}