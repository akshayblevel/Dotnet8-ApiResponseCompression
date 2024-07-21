using Dotnet8_ApiResponseCompression.Interfaces;
using Dotnet8_ApiResponseCompression.Models;

namespace Dotnet8_ApiResponseCompression.DataAccess
{
    public interface ILocationDb
    {
        IRepository<Country> CountryRepository { get; }
        IRepository<State> StateRepository { get; }
        IRepository<City> CityRepository { get; }
    }
}
