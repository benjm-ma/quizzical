namespace quizzical
{
    interface Test 
    {
        public enum TestDifficulty {
            EASY,
            MODERATE,
            HARD
        }

        public enum TestResult {
            FAILED,
            PASSED,
            UNATTEMPTED
        }

        public abstract TestResult Result {get;set;} 
        public abstract TestDifficulty Difficulty {get;set;}
        public abstract int Attempts {get;set;}
    }


}