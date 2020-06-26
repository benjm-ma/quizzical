using System.Collections.Generic;

namespace quizzical
{
    class Answer<T> : Catagorizable
    {
        public Catagorizable.TestType Type {get;}

        public List<Tag> Tags {get;set;}

        public T Value {get;set;}
    }
}