using System.Collections.Generic;

namespace quizzical
{
    interface Catagorizable 
    {
        public enum TestType {
            MULTIPLE_CHOICE,
            MULTIPLE_SELECTION,
            SHORT_ANSWER,
            TRUE_FALSE
        }

        public abstract List<Tag> Tags {get;set;}

        public abstract TestType Type {get;}
    }
}