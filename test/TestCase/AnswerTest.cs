using System;
using NUnit.Framework;

using Quizzical.TestCase;

namespace Quizzical.UnitTests
{
    [TestFixture]
    public class AnswerTest
    {
        [SetUp]
        protected void SetUp() 
        {
        }

        [Test]
        public void Should_EvaluateStringBasedAnswers () 
        {
            Answer<string> stringAnswer = new Answer<string>("foo");

            Assert.That (Answer<string>.Evaluate (stringAnswer, "foo"), 
                "Evaluates to false when correct input given", 
                Is.EqualTo (true));
            Assert.That (Answer<string>.Evaluate (stringAnswer, "bar"), 
                "Evaluates to true when incorrect input given", 
                Is.EqualTo (false));
        }

        [Test]
        public void Should_EvaluateCharBasedAnswers () 
        {
            Answer<char> charAnswer = new Answer<char>('c');

            Assert.That (Answer<char>.Evaluate (charAnswer, 'c'), 
                "Evaluates to false when correct input given", 
                Is.EqualTo (true));
            Assert.That (Answer<char>.Evaluate (charAnswer, 'a'), 
                "Evaluates to true when incorrect input given", 
                Is.EqualTo (false));
        }

        [Test]
        public void Should_EvaluateIntBasedAnswers () 
        {
            Answer<int> intAnswer = new Answer<int>(1);

            Assert.That (Answer<int>.Evaluate (intAnswer, 1), 
                "Evaluates to false when correct input given", 
                Is.EqualTo (true));
            Assert.That (Answer<int>.Evaluate (intAnswer, 0), 
                "Evaluates to true when incorrect input given", 
                Is.EqualTo (false));
        }

        public void Should_EvaluateBoolBasedAnswers ()
        {
            Answer<bool> boolAnswer = new Answer<bool>(false);

            Assert.That (Answer<bool>.Evaluate (boolAnswer, false), 
                "Evaluates to false when correct input given", 
                Is.EqualTo (true));
            Assert.That (Answer<bool>.Evaluate (boolAnswer, true), 
                "Evaluates to true when incorrect input given", 
                Is.EqualTo (false));
        }

        [Test]
        public void Should_EvaluateMultipleAnswers ()
        {
            int[] answerkey = {1, 4};
            Answer<int[]> answers = Answer<int[]>.CreateAnswerSet (answerkey);

        }
    }
}