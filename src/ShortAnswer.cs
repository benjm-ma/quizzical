using System.Collections.Generic;

namespace quizzical
{
    class ShortAnswer : Question<string>
    {

        public override Answer<string> Solution {get;set;}

        public override int Attempts {get;set;}

        public override List<Tag> Tags {get;set;}

        public override Test.TestDifficulty Difficulty {get;set;}

        public override Test.TestResult Result {get;set;}

        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.SHORT_ANSWER;

        public override void CheckAnswer (string attempt)
        {
            if (Answer<string>.Evaluate (this.Solution, attempt))
                this.Result = Test.TestResult.PASSED;
            else
                this.Result = Test.TestResult.FAILED;
        }
    }
}