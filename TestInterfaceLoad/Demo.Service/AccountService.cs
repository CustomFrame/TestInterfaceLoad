using Demo.Core.Dependency;
using Demo.IService;

namespace Demo.Service
{
    public class AccountService : IAccountService, ITransientDependency
    {
        public string SayHello(string userName)
        {
            return $"你好，{userName}！";
        }
    }
}