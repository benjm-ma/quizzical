using System.Collections.Generic;

namespace quizzical
{
    class MultipleChoice: Question<char>
    {
        public override Answer<char> Solution {get;set;}

        public override int Attempts {get;set;}

        public override List<Tag> Tags {get;set;}

        public override Test.TestDifficulty Difficulty {get;set;}

        public override Test.TestResult Result {get;set;}

        public override Catagorizable.TestType Type {get;}

        public override bool Evaluate(char attempt)
        {
            return Solution.Value == attempt;
        }
    }
}