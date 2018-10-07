using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Buffteks
{
    public class Team
    {
       
        //PK - DONE
        //FK - Student
        //Student List - FK - DONE
        //Name - DONE
        //projects = FK - DONE
        public int TeamId { get; set; }
        public string TeamName { get; set; }
      public ICollection<Student> Student { get; set; }
       //public ICollection<Projects> Project{ get; set; }
}

    }