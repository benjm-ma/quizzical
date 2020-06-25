using System.Collections.Generic;

namespace quizzical
{
    abstract class TestCase<T> : Test 
    {
        public enum TestType {
            MULTIPLE_CHOICE,
            SHORT_ANSWER,
            TRUE_FALSE
        }

        public abstract Test.TestResult Result {get;set;}

        public abstract Test.TestDifficulty Difficulty {get;set;}

        public abstract TestType Type {get;}

        public abstract int Attempts {get;set;}

        public abstract List<Tag> Tags {get;set;}

        public abstract string Question {get;set;}

        public abstract bool Evaluate (T attempt);

    }
}
