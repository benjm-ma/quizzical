namespace Quizzical.Metrics
{
    interface Measurable 
    {
        public enum Difficulty {
            EASY,
            MODERATE,
            HARD
        }

        public enum Outcome {
            FAILED,
            PASSED,
            UNATTEMPTED
        }

        public abstract Outcome Result {get;set;} 
        public abstract Difficulty Hardness {get;set;}
        public abstract int Attempts {get;set;}
        
        public abstract Ratio SuccessRate {get;set;}
    }


}