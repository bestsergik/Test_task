namespace Project.WORK.Models
{
    /// <summary>
    /// Кэш задачи, связывающий задачи, пользователей и категории.
    /// </summary>
    public class TaskUserCache
    {
        public int TaskID { get; set; } // Идентификатор задачи
        public int UserID { get; set; } // Идентификатор пользователя
        public byte TaskListCategoryID { get; set; } // Идентификатор категории списка задач
    }
}
