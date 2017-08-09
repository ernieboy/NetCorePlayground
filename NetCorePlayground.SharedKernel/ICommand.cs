using System.Threading.Tasks;

namespace NetCorePlayground.SharedKernel
{
    public interface ICommand
    {
        Task Execute();
    }
}
