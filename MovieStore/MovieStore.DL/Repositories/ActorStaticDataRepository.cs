using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticData;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    internal class ActorStaticDataRepository : IActorRepository
    {
        public List<Actor> GetAll()
        {
            return StaticDB.Actors;
        }

        public Actor? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDB.Actors
                .FirstOrDefault(x => x.Id == id);
        }
    }
}