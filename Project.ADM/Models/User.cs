using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Models
{
    public class User
    {
        public int ID { get; set; }

        // Навигационное свойство для связи с TaskUserCache
        public ICollection<TaskUserCache> TaskUserCaches { get; set; } = new List<TaskUserCache>();

    }

}
