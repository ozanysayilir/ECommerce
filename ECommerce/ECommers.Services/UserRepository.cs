using ECommerce.Service;
using ECommers.Data.Contexts;

namespace ECommers.Services
{
    public class UserRepository :Repository<Data.Entities.User>, Data.Interfaces.IUserRepository<Data.Entities.User>()
    {
        private DataContext _dataContext;

        public UserRepository(Data.Contexts.DataContext dataContext) :base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
