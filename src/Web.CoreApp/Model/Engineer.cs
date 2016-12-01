using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CoreApp.Model
{
    public class Engineer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int DateOfBirth { get; set; }
        public ICollection<Experience> Experiences { get; set; }

    }
}
