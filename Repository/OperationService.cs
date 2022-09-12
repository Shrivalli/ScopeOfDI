namespace ScopeOfAPI.Repository
{
    public class OperationService : IScopedService, ITransientService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }

        public Guid getvariablevalue()
        {
            return id;
        }
    }
}
