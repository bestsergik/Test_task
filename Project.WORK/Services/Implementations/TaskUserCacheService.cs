using Project.WORK.Repositories.Implementations;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;


namespace Project.WORK.Services.Implementations
{
    public class TaskUserCacheService : ITaskUserCacheService
    {
        private readonly ITaskUserCacheRepository _repository;
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly IUserRepository _userRepository;

        public TaskUserCacheService(ITaskUserCacheRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TaskUserCache>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(TaskUserCache taskUserCache) => await _repository.AddAsync(taskUserCache);

        public async Task AggregateTasksForCacheAsync(short tenantId)
        {
            // Здесь должна быть логика, аналогичная той, что реализована в хранимых процедурах
            // Например, выборка задач, доступных всем пользователям или назначенных на конкретных пользователей

            // Этот пример кода предполагает, что у вас есть методы в репозиториях для выборки нужных данных
            //var allTasks = await _workTaskRepository.GetAllTasksForTenantAsync(tenantId);
            //var allUsers = await _userRepository.GetAllAsync();

            //// Пример агрегации данных и добавления их в кэш
            //foreach (var task in allTasks)
            //{
            //    foreach (var user in allUsers)
            //    {
            //        // Проверка условий для добавления задачи в кэш для пользователя
            //        // Например, проверка, назначена ли задача на пользователя
            //        if (task.IsAssignedToUser(user.ID))
            //        {
            //            var taskUserCache = new TaskUserCache
            //            {
            //                TaskID = task.ID,
            //                UserID = user.ID,
            //                // Установите TaskListCategoryID в соответствии с вашей бизнес-логикой
            //            };
            //            await AddAsync(taskUserCache);
            //        }
            //    }
            //}
        }

    }





}
