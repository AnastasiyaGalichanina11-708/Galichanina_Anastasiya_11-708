using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debut2.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Quest { get; set; }
        public int OkQuest { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
