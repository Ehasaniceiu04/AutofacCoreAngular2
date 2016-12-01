using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CoreApp.Model
{
    public class Experience
    {
        public int Id { get; set; }
        public int EngineerId { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("EngineerId")]
        public Engineer Engineer { get; set; }
    }
}
