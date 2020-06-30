namespace Quizzical.Metrics
{
    /// <summary>
    /// A ratio.
    /// </summary>
    public struct Ratio {
        public int Antecedent {get;set;}
        public int Consequent {get;set;}

        public Ratio (int antecedent, int consequent)
        {
            Antecedent = antecedent;
            Consequent = consequent;
        }

        //TODO: Normalize the ratio by finding the GCD 
        public static Ratio Normalize (Ratio r)
        {
            return new Ratio (0, 0);
        }

        public override string ToString() => $"{Antecedent}:{Consequent}";
    }
}