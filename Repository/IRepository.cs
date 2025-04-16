namespace WebApp5BySaugat.Repository
{
    public interface IRepository<T>
    {
        public void AddRecord(T model);
        public T UpdateRecord(T model);
        public void DeleteRecord(T model);
        public T GetSingleRecord(int id);
        public IEnumerable<T> GetAllRecords();

    }
}
