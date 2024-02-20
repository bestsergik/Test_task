namespace Project.WORK.Models
{
    /// <summary>
    /// Категория списка задач.
    /// </summary>
    public class ListCategory
    {
        public byte ID { get; set; } // Уникальный идентификатор категории
        public short? PermissionExtID { get; set; } // Опциональный идентификатор расширенного разрешения
    }
}
