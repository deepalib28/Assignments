using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAsKeyImpl
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

     
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode()*5 + this.Name.GetHashCode()*2;
        }

        public override bool Equals(object obj)
        {
            //check if obj is null
            //check if this and obj have same type
            //check if they have same has code
            //implement custom logic for equals

            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            if (obj.GetHashCode() != this.GetHashCode())
                return false;

            Student s = obj as Student;
            if(s.Id==this.Id)
                return true;
            

            return false;
        }
    }

    public class StudentCollection
    {
        public Dictionary<Student, string> dictionary { get; set;}

        public StudentCollection()
        {
          dictionary=new Dictionary<Student, string>();
        }
        public Dictionary<Student,string> Add(Student s, string course)
        {
            dictionary.Add(s, course);
            return dictionary;
        }

        public string Retrieve(Student stud)
        {
            return dictionary[stud];
        }

        public Dictionary<Student, string> Update(Student stud, string course)
        {
            dictionary[stud] = "Bio";
            return dictionary;
        }

        public Dictionary<Student, string> Delete(Student stud)
        {
            dictionary.Remove(stud);
            return dictionary;
        }
    }
    
}
