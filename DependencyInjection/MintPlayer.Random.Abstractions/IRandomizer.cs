using System;
using System.Threading.Tasks;

namespace MintPlayer.Random.Abstractions
{
    public interface IRandomizer
    {
        Task<string> RandomString();
    }
}
