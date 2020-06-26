using System.Collections.Generic;

namespace quizzical
{
    abstract class Question<T> : Test, Catagorizable
    {
        public abstract Answer<T> Solution {get;set;}

        public abstract Test.TestResult Result {get;set;}

        public abstract Test.TestDifficulty Difficulty {get;set;}

        public abstract Catagorizable.TestType Type {get;}

        public abstract int Attempts {get;set;}

        public abstract List<Tag> Tags {get;set;}

        public abstract bool Evaluate (T attempt);

    }
}
