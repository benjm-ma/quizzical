
using System.Collections.Generic;

using Quizzical.Metrics;
using Quizzical.Filter;

namespace Quizzical.TestCase
{
    class MultipleSelection: CheckableQuestion<int[]>
    {
        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.MULTIPLE_SELECTION;

        public MultipleSelection (int[] answer, int attempts, List<Tag> tags, 
            Measurable.Difficulty hardness, Ratio successRate, 
            Measurable.Outcome result ): 
            base (answer, attempts, tags, hardness, successRate, result) { }

    }
}