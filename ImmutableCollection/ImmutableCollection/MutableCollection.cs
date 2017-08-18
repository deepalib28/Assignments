using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableCollection
{
    public class MutableCollection
    {
        //dictionay 
        private readonly Dictionary<string, Student> _studentCollection;

        public Dictionary<string, Student> StudentCollection
        {
            get { return _studentCollection; }
        }

        public MutableCollection()
        {
            _studentCollection=new Dictionary<string, Student>();

            _studentCollection.Add("1",new Student("Deepali","Bhavsar"));
            _studentCollection.Add("2",new Student("Dee","Bhavsar"));
            _studentCollection.Add("3", new Student("B", "B"));

        }
       

        public Student GetStudent(string key)
        {
            if (string.IsNullOrEmpty(key) == false && _studentCollection.ContainsKey(key))
            {
                return _studentCollection[key];
            }
            return null;
        }
     


    }
}
