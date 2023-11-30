﻿using DonSergios.Domain.Entities;

namespace DonSergios.Applications.Interfaces
{
    public interface IRepuestoRepository
    {
        void Create(REPUESTOS rRepuesto);
        List<REPUESTOS> Read();
        REPUESTOS GetRepuestoByID(int ID);
        void Update(REPUESTOS rRepuesto);
        void Delete(int rID);
    }
}