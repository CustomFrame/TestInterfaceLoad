using Demo.Core.Dependency;

namespace Demo.IService
{
    public interface IProductService : ITransientDependency
    {
        /// <summary>
        /// 说，你好！
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        string SayHello(string userName);
    }
}