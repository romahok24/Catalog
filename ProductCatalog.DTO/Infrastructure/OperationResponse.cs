namespace ProductCatalog.DTO.Infrastructure
{
    public class OperationResponse<T>
    {

        public OperationResponse(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }

        public OperationResponse(bool succeeded, string message, T result) : this(succeeded, message)
        {
            Result = result;
        }

        public bool Succeeded { get; private set; }
        public string Message { get; private set; }
        public T Result { get; private set; }
    }
}
