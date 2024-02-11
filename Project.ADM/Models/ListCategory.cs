using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Models
{
    public class ListCategory
    {
        public byte ID { get; set; }
        public short? PermissionExtID { get; set; }
        // Навигационное свойство для связи с TaskUserCache
        public ICollection<TaskUserCache> TaskUserCaches { get; set; } = new List<TaskUserCache>();
    }
}
