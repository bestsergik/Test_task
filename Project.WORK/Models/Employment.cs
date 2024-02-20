namespace Project.WORK.Models
{
    /// <summary>
    /// Представляет трудоустройство пользователя в компании.
    /// </summary>
    public class Employment
    {
        public int UserID { get; set; } // Идентификатор пользователя
        public short CompanyID { get; set; } // Идентификатор компании
        public byte TaskListCategoryID { get; set; } // Идентификатор категории списка задач
    }
}
