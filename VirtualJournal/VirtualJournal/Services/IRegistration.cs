using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualJournal.Models;

namespace VirtualJournal.Services
{
    public interface IRegistration
    {
        Task<bool> AddRegistration(Registration registration);
        Task<List<Registration>> GetAllRegistrations();
        Task<bool> DeleteRegistrationById(int id);
        Task<bool> UpdateRegistration(Registration registration);
        Task<bool> validateRegistration(string username, string password);
        Task<bool> validateUsername(string username);
    }
}
