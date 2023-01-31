﻿using CargoManagementAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoManagementAPi.IRepository
{
    public class CargoOrderDetailsRepository : IRepositoryCODR<CargoOrderDetails>
    {
        private readonly ApplicationDbContext _context2;

        public CargoOrderDetailsRepository(ApplicationDbContext context2)
        {
            _context2 = context2;
        }

        public async Task Create(CargoOrderDetails cargoOrderDetails)
        {
            if (cargoOrderDetails != null)
            {
                _context2.CargoOrderDetails.Add(cargoOrderDetails);
                await _context2.SaveChangesAsync();
            }
        }

        public async Task<CargoOrderDetails> Delete(int id)
        {
            var cargoOrderDetailsInDb = await _context2.CargoOrderDetails.FindAsync(id);
            if (cargoOrderDetailsInDb != null)
            {
                _context2.Remove(cargoOrderDetailsInDb);
                await _context2.SaveChangesAsync();
                return cargoOrderDetailsInDb;
            }
            return null;
        }

        public async Task<IEnumerable<CargoOrderDetails>> GetAll()
        {
            return await _context2.CargoOrderDetails.ToListAsync();
        }

        public async Task<CargoOrderDetails> GetById(int id)
        {
            var cargoOrderDetails = await _context2.CargoOrderDetails.FindAsync(id);
            if (cargoOrderDetails != null)
            {
                return cargoOrderDetails;
            }
            return null;
        }

        public async Task<CargoOrderDetails> Update(int id, CargoOrderDetails cargoOrderDetails)
        {
            var cargoOrderDetailsInDb = await _context2.CargoOrderDetails.FindAsync(id);
            if (cargoOrderDetailsInDb != null)
            {
                cargoOrderDetailsInDb.OrderDate = cargoOrderDetails.OrderDate;
                cargoOrderDetailsInDb.OrderId = cargoOrderDetails.OrderId;
                cargoOrderDetailsInDb.ReceiverName = cargoOrderDetails.ReceiverName;
                cargoOrderDetailsInDb.CargoStatus = cargoOrderDetails.CargoStatus;
                cargoOrderDetailsInDb.CargoStatusId = cargoOrderDetails.CargoStatusId;
                cargoOrderDetailsInDb.CustId = cargoOrderDetails.CustId;
                cargoOrderDetailsInDb.CargoId = cargoOrderDetails.CargoId;
                cargoOrderDetailsInDb.CargoType = cargoOrderDetails.CargoType;
                cargoOrderDetailsInDb.CargoTypeId = cargoOrderDetails.CargoTypeId;
                cargoOrderDetailsInDb.City = cargoOrderDetails.City;
                cargoOrderDetailsInDb.CityId = cargoOrderDetails.CityId;
                _context2.CargoOrderDetails.Update(cargoOrderDetailsInDb);
                await _context2.SaveChangesAsync();
                return cargoOrderDetailsInDb;
            }
            return null;
        }
    }

}
