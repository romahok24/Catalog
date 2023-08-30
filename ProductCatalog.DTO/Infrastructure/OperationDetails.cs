namespace ProductCatalog.DTO.Infrastructure
{
    public class OperationDetails
    {
        public bool Succeeded { get; private set; }
        public string Message { get; private set; }

        public OperationDetails(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }
    }
}