using MovieStore.Models.DTO;


namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        void AddActor(Actor actor);
        IEnumerable<Actor> GetActorsByIds(List<string> actorsIds);
        Actor? GetById(string id);
    }
}