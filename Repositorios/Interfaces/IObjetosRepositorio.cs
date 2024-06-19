using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IObjetosRepositorio
    {
        Task<List<ObjetosModel>> GetAll();

        Task<ObjetosModel> GetById(int id);

        Task<ObjetosModel> InsertObjeto(ObjetosModel user);

        Task<ObjetosModel> UpdateObjeto(ObjetosModel user, int id);

        Task<bool> DeleteObjeto(int id);
    }
}
