using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Async_Efcore_New.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Async_Efcore_New.Repository
{
    public class SchoolRepo : ISchool
    {
        private student2Context _cnt;

        public SchoolRepo(student2Context cnt)  //Dependncy Inject
        {
            _cnt = cnt;
        }
        public async Task DeleteSchool(int roll)
        {
            var obj = await _cnt.School.FindAsync(roll);
            _cnt.School.Remove(obj);
            await _cnt.SaveChangesAsync();
        }
        public async Task<IEnumerable<School>> GetAllSchool()
        {
            return await _cnt.School.Select(i => i).ToListAsync();
        }
        public async Task<School> GetSchool(int roll)
        {
            return await _cnt.School.FindAsync(roll);
        }
        public async Task<School> InsertSchool(School Sobj)
        {
            _cnt.School.Add(Sobj);
            await _cnt.SaveChangesAsync();
            return Sobj;
        }
        public async Task UpdateSchool(School Sobj)
        {
            _cnt.Entry(Sobj).State = EntityState.Modified;
            await _cnt.SaveChangesAsync();
        }

    }
}
