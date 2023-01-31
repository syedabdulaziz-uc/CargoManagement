using CargoManagementAPi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoManagementAPi.IRepository
{
    public interface IRepository<T> where T : class
    {



        Task<IEnumerable<T>> GetAllCargo();
        Task<T> GetCargoById(int id);
        Task Create(T cargo);
        Task<T> Update(int cargoId, T cargo);
        Task<T> Delete(int cargoId);




    }
    //Customers
    public interface IRepository2<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T customer);
        Task<T> Update(int Custid,T customer);
        Task<T> Delete(int id);

    }

    //Admin

    public interface IRepository3<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T customer);
        Task<T> Update(int id, T admin);
        Task<T> Delete(int id);
    }

    //Cargo Type

    public interface IRepository4<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T cargotype);
        Task<T> Update(int id, T cargotype);
        Task<T> Delete(int id);
    }
    //City
    public interface IRepository5<T> where T : class
    {
        Task<T> CityById(int id);
        Task<IEnumerable<T>> GetAllCities();
        Task Create(T cargotype);
        Task<T> Update(int id, T cargotype);
        Task<T> Delete(int id);
    }




    //Employee Interface
    
    public interface IRepositoryEmployee<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T customer);
        Task<T> Update(int id, T admin);
        Task<T> Delete(int id);
    }
    //Order details

    public interface IRepositoryCODR<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T customer);
        Task<T> Update(int id, T admin);
        Task<T> Delete(int id);
    }





}
