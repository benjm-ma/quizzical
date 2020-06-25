using System.Collections.Generic;

namespace quizzical {
    class ShortAnswer<T> : TestCase 
    {
        public override Test.TestResult Result {get;set;}

        public override TestCase.TestType Type {get;} = TestType.SHORT_ANSWER;

        public override Test.TestDifficulty Difficulty {get;set;}

        public override List<Tag> Tags {get;set;}

        public override int Attempts {get;set;}

        public override string Question {get;set;}

        public override bool Evaluate() 
        {
            return false;
        }

    }
}