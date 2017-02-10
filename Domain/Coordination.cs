using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coordination
    {
        public int CoordinationId { get; set; }
        public Job Job { get; set; }
        public ICollection<JobSeeker> Jobseekers { get; set; }
        public bool Valid { get; set; }
    }
}
