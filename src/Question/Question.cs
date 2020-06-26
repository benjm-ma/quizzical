using System.Collections.Generic;

namespace quizzical
{
    abstract class Question<T> : Measurable, Catagorizable
    {

        public abstract Answer<T> Solution {get;set;}

        public abstract Measurable.Outcome Result {get;set;}

        public abstract Measurable.Difficulty Hardness {get;set;}

        public abstract Ratio SuccessRate {get;set;}

        public abstract Catagorizable.TestType Type {get;}

        public abstract int Attempts {get;set;}

        public abstract List<Tag> Tags {get;set;}

        public abstract void CheckAnswer (T attempt);

    }
}
