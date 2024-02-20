namespace Project.WORK.Models
{
    /// <summary>
    /// Ответственный за выполнение задачи.
    /// </summary>
    public class TaskResponsibleUser
    {
        public int TaskID { get; set; } // Идентификатор задачи
        public int UserID { get; set; } // Идентификатор пользователя, ответственного за задачу
    }
}
