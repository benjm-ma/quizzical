using System.Collections.Generic;

namespace quizzical
{
    abstract class TestCase : Test, Catagorizable
    {
        public abstract Test.TestResult Result {get;set;}

        public abstract Test.TestDifficulty Difficulty {get;set;}

        public abstract int Attempts {get;set;}

        public abstract List<Tag> Tags {get;set;}

        public abstract Catagorizable.TestType Type {get;set;}
    }
}