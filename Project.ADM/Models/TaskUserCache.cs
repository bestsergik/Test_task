namespace Project.ADM.Models
{
    /// <summary>
    /// Кэш пользователя задачи, связывает задачи с пользователями и категориями.
    /// </summary>
    public class TaskUserCache
    {
        public int TaskID { get; set; } // Идентификатор задачи
        public int UserID { get; set; } // Идентификатор пользователя
        public byte TaskListCategoryID { get; set; } // Идентификатор категории списка задач
        public User User { get; set; }
        public ListCategory ListCategory { get; set; }
    }
}
