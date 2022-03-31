using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Async_Efcore_New.Models;


namespace WebApi_Async_Efcore_New.Repository
{
    public interface ISchool
    {
        Task<IEnumerable<School>> GetAllSchool();
        Task<School> GetSchool(int roll);
        Task<School> InsertSchool(School Sobj);
        Task UpdateSchool(School Sobj);
        Task DeleteSchool(int roll);
    }
}
