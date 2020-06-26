using System.Collections.Generic;

namespace quizzical
{
    class Answer<T> : Catagorizable
    {
        public Catagorizable.TestType Type {get;}

        public List<Tag> Tags {get;set;}

        public T Value {get;set;}

        public static bool Evaluate (Answer<int[]> solution, int[] attempt)
        {
            return false;
        }

        public static bool Evaluate (Answer<string> solution, string attempt)
        {
            return false;
        }

        public static bool Evaluate (Answer<bool> solution, bool attempt)
            => solution.Value == attempt;

        public static bool Evaluate (Answer<int> solution, int attempt)
            => solution.Value == attempt;
    }
}