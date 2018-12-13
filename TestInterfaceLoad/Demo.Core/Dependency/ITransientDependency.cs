using OSharp.Dependency;

namespace Demo.Core.Dependency
{
    /// <summary>
    /// 实现此接口的类型将被注册为<see cref="ServiceLifetime.Transient"/>模式
    /// </summary>
    /// 
    [IgnoreDependency]
    public interface ITransientDependency
    { }
}