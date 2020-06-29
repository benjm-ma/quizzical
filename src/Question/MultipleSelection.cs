
using System.Collections.Generic;

namespace quizzical
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