using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualJournal.DbContexts;
using VirtualJournal.Models;

namespace VirtualJournal.Repositories
{
    public class RegistrationRepo : IRegistrationRepo
    {
        public readonly dboVirjualJournalContext _context = null;
        public RegistrationRepo(dboVirjualJournalContext context)
        {
            _context = context;
        }
        public async Task<bool> AddRegistration(Registration registration)
        {
            await _context.RegistrationData.AddAsync(registration);
            int check = _context.SaveChanges();
            if (check > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteRegistrationById(int id)
        {
            Registration registration = _context.RegistrationData.Find(id);
            _context.RegistrationData.Remove(registration);
            int check = await _context.SaveChangesAsync();
            if(check > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Registration>> GetAllRegistrations()
        {
            List<Registration> registrations = new List<Registration>();
            registrations =await _context.RegistrationData.ToListAsync();
            return registrations;
        }

        public async Task<bool> UpdateRegistration(Registration registration)
        {
            _context.RegistrationData.Update(registration);
            int check = await _context.SaveChangesAsync();
            if(check > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> validateRegistration(string username, string password)
        {
            List<Registration> registrations = new List<Registration>();
            registrations = await _context.RegistrationData.ToListAsync();
            foreach(var data in registrations)
            {
                if(data.UserName.Equals(username) && data.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> validateUsername(string username)
        {
            List<Registration> registrations = new List<Registration>();
            registrations = await _context.RegistrationData.ToListAsync();
            foreach (var data in registrations)
            {
                if (data.UserName.Equals(username))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
