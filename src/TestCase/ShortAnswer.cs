using System.Collections.Generic;

using Quizzical.Metrics;
using Quizzical.Filter;

namespace Quizzical.TestCase
{
    class ShortAnswer : CheckableQuestion<string>
    {
        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.SHORT_ANSWER;

        public ShortAnswer (string answer, int attempts, List<Tag> tags, 
            Measurable.Difficulty hardness, Ratio successRate, 
            Measurable.Outcome result ): 
            base (answer, attempts, tags, hardness, successRate, result) { }

    }
}