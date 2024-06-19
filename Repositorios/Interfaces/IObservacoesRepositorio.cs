using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IObservacoesRepositorio
    {
        Task<List<ObservacoesModel>> GetAll();

        Task<ObservacoesModel> GetById(int id);

        Task<ObservacoesModel> InsertObservacoes(ObservacoesModel observacoe);

        Task<ObservacoesModel> UpdateObservacoes(ObservacoesModel observacoe, int id);

        Task<bool> DeleteObservacoes(int id);
    }
}