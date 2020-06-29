using System.Collections.Generic;

namespace quizzical
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