using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualJournal.Models;
using VirtualJournal.Repositories;

namespace VirtualJournal.Services
{
    public class RegistrationService : IRegistration
    {
        public readonly IRegistrationRepo _context = null;
        public RegistrationService(IRegistrationRepo context)
        {
            _context = context;
        }
        public async Task<bool> AddRegistration(Registration registration)
        {
            if (await _context.AddRegistration(registration))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteRegistrationById(int id)
        {
            if (await _context.DeleteRegistrationById(id))
            {
                return true;
            }
            return false;
        }

        public async Task<List<Registration>> GetAllRegistrations()
        {
            return await _context.GetAllRegistrations();
        }

        public async Task<bool> UpdateRegistration(Registration registration)
        {
            return await _context.UpdateRegistration(registration);
        }

        public async Task<bool> validateRegistration(string username, string password)
        {
            return await _context.validateRegistration(username, password);
        }

        public async Task<bool> validateUsername(string username)
        {
            return await _context.validateUsername(username);
        }
    }
}
