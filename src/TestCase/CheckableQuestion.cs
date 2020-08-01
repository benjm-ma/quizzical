using System.Collections.Generic;

using Quizzical.Metrics;
using Quizzical.Filter;

namespace Quizzical.TestCase
{
    class CheckableQuestion<T> : Question<T> {

        public override Answer<T> Solution {get;set;}

        public override int Attempts {get;set;} = 0;

        public override List<Tag> Tags {get;set;}

        public override Measurable.Difficulty Hardness {get;set;}

        public override Ratio SuccessRate {get;set;}

        public override Measurable.Outcome Result {get;set;}
            = Measurable.Outcome.UNATTEMPTED;

        public override Catagorizable.TestType Type {get;} 

        public CheckableQuestion (T answer, int attempts, List<Tag> tags, 
            Measurable.Difficulty hardness, Ratio successRate, 
            Measurable.Outcome result)
        {
            this.Solution = new Answer<T> (answer);
            Tags = tags; // Do a shallow copy
            Hardness = hardness;
            SuccessRate = successRate;
            Result = result;
        }

        public CheckableQuestion (T answer, int attempts)
        {

        }

        public override void CheckAnswer (T attempt)
        {
            if (Answer<T>.Evaluate (Solution, attempt)){
                this.Result = Measurable.Outcome.PASSED;
                
            } else {
                this.Result = Measurable.Outcome.FAILED;
            }

            Attempts++;
        }


    }
}