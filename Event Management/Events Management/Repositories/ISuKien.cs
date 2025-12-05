using Events_Management.Models;

namespace Events_Management.Repositories
{
    public interface ISuKien
    {
        List<SuKien> GetAll();
        SuKien? GetById(int id);
        int Insert(SuKien sk);
        int Update(SuKien sk);
        int Delete(int id);
    }
}
