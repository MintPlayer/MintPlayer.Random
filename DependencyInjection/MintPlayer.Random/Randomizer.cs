using System.Linq;
using System.Threading.Tasks;
using MintPlayer.Random.Abstractions;

namespace MintPlayer.Random
{
    public class Randomizer : IRandomizer
    {
        private readonly System.Random random;
        public Randomizer(System.Random random)
        {
            this.random = random;
        }

        public Task<string> RandomString(int length = 20)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return Task.FromResult(new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
        }
    }
}
