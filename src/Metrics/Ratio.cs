namespace Quizzical.Metrics
{
    /// <summary>
    /// A ratio.
    /// </summary>
    public readonly struct Ratio {
        public readonly int Antecedent {get;}
        public readonly int Consequent {get;}

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

        public static bool operator == (Ratio r1, Ratio r2) 
            => r1.Antecedent == r2.Antecedent && 
               r1.Consequent == r2.Consequent;

        public static bool operator != (Ratio r1, Ratio r2)
            => r1.Antecedent != r2.Antecedent || 
               r1.Consequent != r2.Consequent;

        public override bool Equals (object obj)
            => obj is Ratio r1 && this.Antecedent == r1.Antecedent
                               && this.Consequent == r1.Consequent;
        
        public override int GetHashCode ()
            => (Antecedent, Consequent).GetHashCode ();

        public override string ToString() => $"{Antecedent}:{Consequent}";
    }
}