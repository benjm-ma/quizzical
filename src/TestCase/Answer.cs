using System;
using System.Collections.Generic;

using Quizzical.Filter;

namespace Quizzical.TestCase
{
    /// <summary>
    ///
    /// </summary>
    public class Answer<T> : Catagorizable
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
        public static bool Evaluate (Answer<T[]> solution, T[] attempt)
        {
            // Check each element in attempt and see if it exists within
            // the solution array
            return Array.TrueForAll (attempt, (T attemptValue) => {
                foreach (T solutionValue in solution.Value) 
                    if (solutionValue.Equals (attemptValue)) return true;
                return false;
            });
        }

        public Answer () {}

        public Answer (T value) { this.Value = value; }

        public static Answer<T[]> CreateAnswerSet (T[] value) {
            Answer<T[]> answer = new Answer<T[]>();

            Array.Copy (value, answer.Value, value.Length);

            return answer;
        }
    }
}