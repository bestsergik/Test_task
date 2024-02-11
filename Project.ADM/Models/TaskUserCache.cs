using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Models
{
    public class TaskUserCache
    {
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public byte TaskListCategoryID { get; set; }

        // Навигационные свойства
        public User User { get; set; }
        public ListCategory ListCategory { get; set; }
    }

}
