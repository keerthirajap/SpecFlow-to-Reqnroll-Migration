namespace BDDTesting.Net8.Repositories
{
    using BDDTesting.Net8.Models;
    using Insight.Database;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserRepository
    {
        [Sql("SELECT * FROM Users WHERE UserId = @UserId")]
        Task<User> GetUserByIdAsync(int userId);
    }
}