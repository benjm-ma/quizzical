using System.Collections.Generic;

namespace quizzical
{
    class MultipleChoice: Question<int>
    {
        public override Answer<int> Solution {get;set;}

        public override int Attempts {get;set;} = 0;

        public override List<Tag> Tags {get;set;}

        public override Measurable.Difficulty Hardness {get;set;}

        public override Ratio SuccessRate {get;set;}

        public override Measurable.Outcome Result {get;set;}
            = Measurable.Outcome.UNATTEMPTED;

        public override Catagorizable.TestType Type {get;} 
            = Catagorizable.TestType.MULTIPLE_CHOICE;

        public override void CheckAnswer (int attempt)
        {
            if (Answer<int>.Evaluate (this.Solution, attempt))
                this.Result = Measurable.Outcome.PASSED;
            else
                this.Result = Measurable.Outcome.FAILED;
        }
    }
}