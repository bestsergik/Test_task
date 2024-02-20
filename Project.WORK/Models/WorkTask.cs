namespace Project.WORK.Models
{
    /// <summary>
    /// Задача в системе управления задачами.
    /// </summary>
    public class WorkTask
    {
        public int ID { get; set; } // Уникальный идентификатор задачи
        public int? AssetID { get; set; } // Опциональный идентификатор актива, связанного с задачей
        public int? ApprovalWith { get; set; } // Опциональный идентификатор пользователя, одобряющего задачу
        public int? EscalatedTo { get; set; } // Опциональный идентификатор пользователя, к которому эскалируется задача
        public int CreatedBy { get; set; } // Идентификатор пользователя, создавшего задачу
        public int RequestedBy { get; set; } // Идентификатор пользователя, запросившего задачу
        public short WorkTypeID { get; set; } // Идентификатор типа работы
        public DateTime? Archived { get; set; } // Дата архивации задачи
        public DateTime? Deleted { get; set; } // Дата удаления задачи
    }
}
