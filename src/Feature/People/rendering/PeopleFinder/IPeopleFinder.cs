using Winner.Feature.People.Models;
using System.Threading.Tasks;

namespace Winner.Feature.People.PeopleFinder
{
    public interface IPeopleFinder
    {
        public Task<PeopleSearchResults> FindPeople(SearchParams searchParams);
    }
}