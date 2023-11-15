namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG 
        public const string DatabaseConnectionString = @"Data Source=LENOVICH;Initial Catalog=PAD3;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
#endif
#if RELEASE
        public const string DatabaseConnectionString = @"";
#endif

    }
}
