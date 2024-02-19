using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Models
{
    public class RolePermissionExt
    {
        public int ID { get; set; } // Уникальный идентификатор разрешения
        public int RoleID { get; set; } // Идентификатор роли
        public string PermissionName { get; set; } // Название разрешения
        public DateTime? ExpiryDate { get; set; } // Срок действия разрешения
        public UserRole Role { get; set; } // Связь с сущностью UserRole
    }
}
