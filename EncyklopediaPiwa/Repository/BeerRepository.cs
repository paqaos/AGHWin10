using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncyklopediaPiwa.Interfaces.Repository;
using EncyklopediaPiwa.Model;

namespace EncyklopediaPiwa.Repository
{
    public class BeerRepository : IRepository<Beer>
    {
        private readonly  List<Beer> _beers;

        public BeerRepository()
        {
            _beers = new List<Beer>();

            _beers.Add(new Beer() { Country = 1, Id = 1, Name = "Porter Warminski", Voltage = 8.9M});
        }
    
        public void Create( Beer beer )
        {
            _beers.Add(beer);
        }

        public Beer Read( long id )
        {
            return _beers.FirstOrDefault(o => o.Id == id);
        }

        public void Update( Beer beer )
        {
            var entity = Read(beer.Id);

            if ( entity != null )
            {
                Delete(beer.Id);
                Create(beer);
            }
        }

        public void Delete( long id )
        {
            var entity = Read(id);
            if ( entity != null )
            {
                _beers.Remove(entity);
            }
        }

        public ICollection<Beer> GetAll()
        {
            return new List<Beer>(_beers);
        } 
    }
}
