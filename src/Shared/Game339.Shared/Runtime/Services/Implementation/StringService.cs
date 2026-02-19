using System.Linq;
using Game339.Shared.Diagnostics;

namespace Game339.Shared.Services.Implementation
{
    public class StringService : IStringService
    {
        private readonly IGameLog _log;

        public StringService(IGameLog log)
        {
            _log = log;
        }

        public string Reverse(string input)
        {
            var output = new string(input.Reverse().ToArray());
            _log.Info($"{nameof(StringService)}.{nameof(Reverse)} - {nameof(input)}: {input} - {nameof(output)}: {output}");
            return output;
        }

        public string ReverseWords(string input)
        {
            var words = input.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var charArray = word.ToCharArray();
                System.Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }

    }
}