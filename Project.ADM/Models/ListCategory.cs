namespace Project.ADM.Models
{
    /// <summary>
    /// Категория списка задач.
    /// </summary>
    public class ListCategory
    {
        public byte ID { get; set; } // Уникальный идентификатор категории
        public short? PermissionExtID { get; set; } // Идентификатор расширенного разрешения
        public ICollection<TaskUserCache> TaskUserCaches { get; set; } = new List<TaskUserCache>();    // Коллекция кэшированных задач, связанных с этой категорией
    }
}
