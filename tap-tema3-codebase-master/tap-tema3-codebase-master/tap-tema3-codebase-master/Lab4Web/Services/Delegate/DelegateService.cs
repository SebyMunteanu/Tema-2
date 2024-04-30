using Lab4Web.Controllers;

namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Introduction(string value, Func<string, string, string> callback)
        {
            return callback(value.ToUpper(), "Lastname");
        }
        public string Hello(string firstname, string lastname)
        {
            return $"Hello, {firstname}, {lastname}";
        }
    }
}
