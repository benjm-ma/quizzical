using System;
using System.Collections.Generic;

namespace quizzical
{
    /// <summary>
    ///
    /// </summary>
    class Answer<T> : Catagorizable
    {
        /// <summary>
        ///
        /// </summary>
        public Catagorizable.TestType Type {get;}

        /// <summary>
        ///
        /// </summary>
        public List<Tag> Tags {get;set;}

        /// <summary>
        ///
        /// </summary>
        public T Value {get;set;}

        /// <summary>
        ///
        /// </summary>
        public static bool Evaluate (Answer<T> solution, T attempt) 
            => solution.Value.Equals (attempt);

        /// <summary>
        ///
        /// </summary>
        public static bool Evaluate (Answer<int[]> solution, int[] attempt)
        {
            // Check each element in attempt and see if it exists within
            // the solution array
            return Array.TrueForAll (attempt, (int attemptValue) => {
                foreach (int solutionValue in solution.Value) 
                    if (solutionValue == attemptValue) return true;
                return false;
            });
        }

        public Answer () {}

        public Answer (T value) { this.Value = value; }

        public static Answer<int[]> CreateAnswer (int[] value) {
            Answer<int[]> answer = new Answer<int[]>();

            Array.Copy (value, answer.Value, value.Length);

            return answer;
        }
    }
}