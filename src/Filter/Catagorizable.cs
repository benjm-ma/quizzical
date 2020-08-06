using System.Collections.Generic;

namespace Quizzical.Filter
{
    public interface Catagorizable 
    {
        public enum TestType {
            MULTIPLE_CHOICE,
            MULTIPLE_SELECTION,
            SHORT_ANSWER,
            TRUE_FALSE
        }

        List<Tag> Tags {get;set;}

        TestType Type {get;}
    }
}