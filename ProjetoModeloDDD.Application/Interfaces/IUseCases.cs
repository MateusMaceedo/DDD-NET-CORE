using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.UseCases
{
    public interface IUseCases<TRequest>
    {
        void Executar(TRequest request);
    }

    public interface IUseCases<TRequest, TResponse>
    {
        TResponse Executar(TRequest request);
    }

    public interface IUseCase<TRequest, TResponse>
    {
        Task<TResponse> Executar(TRequest param);
    }

    public interface IUseCase<TRequest>
    {
        Task Executar(TRequest param);
    }

    public interface IUseCaseWithoutParamAsync<TResponse>
    {
        Task<TResponse> Executar();
    }
}
