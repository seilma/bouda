using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Domaine
    {
        public int DomaineId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Sector Sector { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Job> Jobs { get; set; }
        //bouda blid
    }
    public enum Sector
    {
        Informatique,Electronique,Mecanique
    }
}
