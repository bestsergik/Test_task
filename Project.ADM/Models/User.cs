namespace Project.ADM.Models
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User
    {
        public int ID { get; set; } // Уникальный идентификатор пользователя

        // Коллекция кэшированных задач, назначенных на пользователя
        public ICollection<TaskUserCache> TaskUserCaches { get; set; } = new List<TaskUserCache>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
