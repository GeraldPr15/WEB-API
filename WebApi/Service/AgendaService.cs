using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IAgendaService
    {
        IEnumerable<Agenda> GetAll();
        bool Add(Agenda model);
        bool Delete(int id);
        bool Update(Agenda model);
        Agenda Get(int id);
    }
    public class AgendaService : IAgendaService
    {
        private readonly AgendaDbContext _agendaDbContext;
        public AgendaService(AgendaDbContext agendaDbContext)
        {
            _agendaDbContext = agendaDbContext;
        }
        public IEnumerable<Agenda> GetAll(Agenda model)
        {
            var result = new List<Agenda>();
            try
            {
                result = _agendaDbContext.Agenda.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public Agenda Get(int id)
        {
            var result = new Agenda();
            try
            {
                result = _agendaDbContext.Agenda.Single(x => x.ContactoId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(Agenda model)
        {
            try
            {
                _agendaDbContext.Add(model);
                _agendaDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool Update(Agenda model)
        {
            try
            {
                var originalModel = _agendaDbContext.Agenda.Single(x =>
                    x.ContactoId == model.ContactoId
                );

                originalModel.Nombre = model.Nombre;
                originalModel.Apellido = model.Apellido;
                originalModel.Mensaje = model.Mensaje;

                _agendaDbContext.Update(originalModel);
                _agendaDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                _agendaDbContext.Entry(new Agenda { ContactoId = id }).State = EntityState.Deleted;
                _agendaDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<Agenda> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
