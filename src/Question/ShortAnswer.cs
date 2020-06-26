using System.Collections.Generic;

namespace quizzical
{
    class ShortAnswer : Question<string>
    {

        public override Answer<string> Solution {get;set;}

        public override int Attempts {get;set;} = 0;

        public override List<Tag> Tags {get;set;}

        public override Measurable.Difficulty Hardness {get;set;}

        public override Ratio SuccessRate {get;set;}

        public override Measurable.Outcome Result {get;set;}
            = Measurable.Outcome.UNATTEMPTED;

        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.SHORT_ANSWER;

        public override void CheckAnswer (string attempt)
        {
            if (Answer<string>.Evaluate (this.Solution, attempt))
                this.Result = Measurable.Outcome.PASSED;
            else
                this.Result = Measurable.Outcome.FAILED;
        }
    }
}