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
        public void Should_EvaluateAnswersOfBasicDataTypes ()
        {
            Answer<string> stringAnswer = new Answer<string>("foo");
            Answer<char> charAnswer     = new Answer<char>('c');
            Answer<int> intAnswer       = new Answer<int>(1);
            Answer<bool> boolAnswer     = new Answer<bool>(false);

            Assert.That (()=>{
                string foo = "foo";
                if( foo.Equals("foo") ) return true;
                return false;
            }, ".Equals does not evaluate strings how I exprected", 
            Is.EqualTo(false));

            Assert.That (Answer<string>.Evaluate (stringAnswer, "foo"), 
                "Correct string evaluates to false", 
                Is.EqualTo (true));
            Assert.That (Answer<string>.Evaluate (stringAnswer, "bar"), 
                "Incorrect string evaluates to true", 
                Is.EqualTo (false));
            Assert.That (Answer<char>.Evaluate (charAnswer, 'c'), 
                "Correct char evaluates to false", 
                Is.EqualTo (false));
            Assert.That (Answer<char>.Evaluate (charAnswer, 'a'), 
                "Incorrect char evaluates to true", 
                Is.EqualTo (false));
            Assert.That (Answer<int>.Evaluate (intAnswer, 1), 
                "Correct int evaluates to false", 
                Is.EqualTo (false));
            Assert.That (Answer<int>.Evaluate (intAnswer, 0), 
                "Incorrect int evaluates to true", 
                Is.EqualTo (false));
            Assert.That (Answer<bool>.Evaluate (boolAnswer, false), 
                "Correct int evaluates to false", 
                Is.EqualTo (false));
            Assert.That (Answer<bool>.Evaluate (boolAnswer, false), 
                "Incorrect int evaluates to true", 
                Is.EqualTo (false));
        }

        [Test]
        public void Should_EvaluateMultipleAnswers ()
        {

        }
    }
}