namespace quizzical
{
    /// <summary>
    /// A ratio of passes and failures.
    /// </summary>
    public struct Ratio {
        public int Antecedent {get;set;}
        public int Consequent {get;set;}

        public override string ToString() 
            => $"{Antecedent}:{Consequent}";
    }
}