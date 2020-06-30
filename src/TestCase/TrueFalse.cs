using System.Collections.Generic;

using Quizzical.Metrics;
using Quizzical.Filter;

namespace Quizzical.TestCase
{
    class TrueFalse : CheckableQuestion<bool>
    {
        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.TRUE_FALSE;

        public TrueFalse (bool answer, int attempts, List<Tag> tags, 
            Measurable.Difficulty hardness, Ratio successRate, 
            Measurable.Outcome result ): 
            base (answer, attempts, tags, hardness, successRate, result) { }

    }
}