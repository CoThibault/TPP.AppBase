using SimpleInjector;

namespace TPP.AppBase
{
    public interface IBootStrapper
    {
        void Register(Container container);
    }
}