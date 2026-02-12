namespace ContactManagement.Application.Interfaces.DataAccess
{
    public interface IDatabaseInitializer
    {
        void Initialize();
        void SeedDemoData();
    }
}
