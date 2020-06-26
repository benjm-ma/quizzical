
using System.Collections.Generic;

namespace quizzical
{
    class MultipleSelection: Question<int[]>
    {
        public override Answer<int[]> Solution {get;set;}

        public override int Attempts {get;set;}

        public override List<Tag> Tags {get;set;}

        public override Test.TestDifficulty Difficulty {get;set;}

        public override Test.TestResult Result {get;set;}

        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.MULTIPLE_SELECTION;

        public override bool Evaluate(int[] attempt)
        {
            return false;
        }
    }
}