using Project.WORK.Repositories.Interfaces;

namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для управления ответственными за задачи пользователями.
    /// Предоставляет функционал для доступа к данным о пользователях, ответственных за выполнение задач.
    /// </summary>
    public class TaskResponsibleUserRepository : ITaskResponsibleUserRepository
    {
        private readonly WorkDbContext _context;

        public TaskResponsibleUserRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает список всех пользователей, ответственных за задачи.
        /// </summary>
        public async Task<IEnumerable<TaskResponsibleUser>> GetAllAsync()
        {
            return await _context.TaskResponsibleUsers.ToListAsync();
        }

        /// <summary>
        /// Добавляет нового ответственного пользователя за задачу в базу данных.
        /// </summary>
        public async Task AddAsync(TaskResponsibleUser taskResponsibleUser)
        {
            await _context.TaskResponsibleUsers.AddAsync(taskResponsibleUser);
            await _context.SaveChangesAsync();
        }
    }
}

