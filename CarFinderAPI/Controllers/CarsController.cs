using CarFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CarFinderAPI.Controllers
{
    ///TODO: Add XML Comment Here
    ///
    ///
    [RoutePrefix("api/Cars")]
    public class CarsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// Get List of Car Years
        /// </summary>
        /// <returns></returns>
        [Route("Years")]
        public async Task<List<string>> GetYears()
        {
            return await db.GetYears();
        }

        /// <summary>
        /// Get List of Cars By a Specific Year
        /// </summary>
        /// <returns></returns>
        [Route("GetCarByYear")]
        public async Task<List<Car>> GetCarByYear(string year)
        {
            return await db.GetCarByYear(year);
        }

        /// <summary>
        /// Get List of Cars By a Specific Year and Make
        /// </summary>
        /// <returns></returns>
        [Route("GetCarByYearMake")]
        public async Task<List<Car>> GetCarByYearMake(string year,string make)
        {
            return await db.GetCarByYearMake(year,make);
        }

        /// <summary>
        /// Get List of Cars By a Specific Year,Make and Model
        /// </summary>
        /// <returns></returns>
        [Route("GetCarByYearMakeModel")]
        public async Task<List<Car>> GetCarByYearMakeModel(string year, string make, string model)
        {
            return await db.GetCarByYearMakeModel(year, make,model);
        }

        /// <summary>
        /// Get List of Cars By a Specific Year,Make,Model and Trim
        /// </summary>
        /// <returns></returns>
        [Route("GetCarByYearMakeModelTrim")]
        public async Task<List<Car>> GetCarByYearMakeModel(string year, string make, string model, string trim)
        {
            return await db.GetCarByYearMakeModelTrim(year, make, model,trim);
        }

        /// <summary>
        /// Get List of Car Makes By a Specific Year
        /// </summary>
        /// <returns></returns>
        [Route("GetMakeByYear")]
        public async Task<List<string>> GetMakeByYear(string year)
        {
            return await db.GetMakeByYear(year);
        }

        /// <summary>
        /// Get List of Car Models By a Specific Year and Make
        /// </summary>
        /// <returns></returns>
        [Route("GetModelByYearMake")]
        public async Task<List<string>> GetModelByYearMake(string year, string make)
        {
            return await db.GetModelByYearMake(year, make);
        }

        /// <summary>
        /// Get List of Cars with a Trim Package By a Specific Year,Make and Model
        /// </summary>
        /// <returns></returns>
        [Route("GetTrimByYearMakeModel")]
        public async Task<List<string>> GetTrimByYearMakeModel(string year, string make, string model)
        {
            return await db.GetTrimByYearMakeModel(year, make, model);
        }
    }
}
