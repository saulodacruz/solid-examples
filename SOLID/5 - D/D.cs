namespace SOLID.D
{
    interface IRepository
    {

    }

    class SqlRepository : IRepository
    {

    }

    class BusinessRules
    {
        private readonly IRepository _repository;
        public BusinessRules(IRepository repository)
        {
            _repository = repository;
        }
    }

    class Program
    {
        public void Run()
        {
            IRepository repository = new SqlRepository();
            BusinessRules businessRules = new BusinessRules(repository);
        }
    }
}
