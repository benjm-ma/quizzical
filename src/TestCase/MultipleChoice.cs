using System.Collections.Generic;

using Quizzical.Metrics;
using Quizzical.Filter;

namespace Quizzical.TestCase
{
    class MultipleChoice: CheckableQuestion<int>
    {
        public override Catagorizable.TestType Type {get;} = 
            Catagorizable.TestType.MULTIPLE_CHOICE;

        public MultipleChoice (int answer, int attempts, List<Tag> tags, 
            Measurable.Difficulty hardness, Ratio successRate, 
            Measurable.Outcome result ): 
            base (answer, attempts, tags, hardness, successRate, result) { }

    }
}