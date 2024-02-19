
namespace Project.ADM.Repositories.Interfaces
{
    public interface IRolePermissionExtRepository
    {
        Task<IEnumerable<RolePermissionExt>> GetByRoleIdsAsync(IEnumerable<int> roleIds);
    }
}
