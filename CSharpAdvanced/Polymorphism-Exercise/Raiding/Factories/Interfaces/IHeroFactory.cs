
using Raiding.Models;

namespace Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        BaseHero Create(string type, string name);
    }
}
