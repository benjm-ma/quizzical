using System.Collections.Generic;

namespace quizzical
{
    class TrueFalse : Question<bool>
    {
        public override Answer<bool> Solution {get;set;}

        public override int Attempts {get;set;}

        public override List<Tag> Tags {get;set;}

        public override Test.TestDifficulty Difficulty {get;set;}

        public override Test.TestResult Result {get;set;}

        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.TRUE_FALSE;

        public override void CheckAnswer (bool attempt)
        {
            if (Answer<bool>.Evaluate(this.Solution, attempt))
                this.Result = Test.TestResult.PASSED;
            else
                this.Result = Test.TestResult.FAILED;
        }
    }
}