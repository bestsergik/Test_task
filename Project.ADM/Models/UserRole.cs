using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Models
{


    /// <summary>
    /// используется для представления роли пользователя в  системе. Он связывает пользователя (User) с 
    /// конкретной ролью (RoleName) и устанавливает связь между пользователями и их ролями. Этот класс также содержит 
    /// навигационное свойство RolePermissions, которое позволяет определить разрешения (перечисленные в RolePermissionExt),
    /// связанные с данной ролью. Эта структура позволяет управлять доступом пользователей к различным частям  приложения 
    /// на основе их ролей и назначенных разрешений.
    /// </summary>
    public class UserRole
    {
        public int ID { get; set; } // Уникальный идентификатор роли
        public int UserID { get; set; } // Идентификатор пользователя
        public string RoleName { get; set; } // Название роли

        // Навигационные свойства
        public User User { get; set; } // Связь с сущностью User
        public ICollection<RolePermissionExt> RolePermissions { get; set; } = new List<RolePermissionExt>(); // Связь с разрешениями
    }

}
