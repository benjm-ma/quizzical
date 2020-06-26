using System.Collections.Generic;

namespace quizzical
{
    class TrueFalse : Question<bool>
    {
        public override Answer<bool> Solution {get;set;}

        public override int Attempts {get;set;}

        public override List<Tag> Tags {get;set;}

        public override Measurable.Difficulty Hardness {get;set;}

        public override Ratio SuccessRate {get;set;}

        public override Measurable.Outcome Result {get;set;} 
            = Measurable.Outcome.UNATTEMPTED;

        public override Catagorizable.TestType Type {get;}
            = Catagorizable.TestType.TRUE_FALSE;

        public override void CheckAnswer (bool attempt)
        {
            if (Answer<bool>.Evaluate(this.Solution, attempt))
                this.Result = Measurable.Outcome.PASSED;
            else
                this.Result = Measurable.Outcome.FAILED;
        }
    }
}