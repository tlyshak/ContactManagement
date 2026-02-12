using System.Data;

namespace ContactManagement.Application.Interfaces.DataAccess
{
    public interface IDbConnectionFactory
    {
        string DataSource { get; }
        IDbConnection Create();
    }
}
