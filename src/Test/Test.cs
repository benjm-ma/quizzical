using System.Collections.Generic;

namespace quizzical
{
    abstract class Test : Measurable, Catagorizable
    {
        public abstract int Score {get;set;}

        public abstract Measurable.Outcome Result {get;set;}

        public abstract Measurable.Difficulty Hardness {get;set;}

        public abstract Ratio SuccessRate {get;set;}

        public abstract int Attempts {get;set;}

        public abstract List<Tag> Tags {get;set;}

        public abstract Catagorizable.TestType Type {get;set;}

    }
}