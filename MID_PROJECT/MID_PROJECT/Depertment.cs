using System;
using System.Collections.Generic;
using System.Text;

namespace MID_PROJECT
{
    class Depertment
       {
       
        private string name;
        private int NumOFCourse;
        public Courses[] courselist;

        public int NOC {
            set { NumOFCourse = value; }
            get { return NumOFCourse; }
        }

        public string NameofDpt
        {
            set { name = value; }
            get { return name; }
        }

       
     
   
         public void showDeptInfo()
        {
            Console.WriteLine(" Name of the Dept : "+ name);
            Console.WriteLine(" total couese "+ NumOFCourse);
            
        }
        

    }
}
