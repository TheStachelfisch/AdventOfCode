namespace Day2.Tokenizer
{
    public struct Range
    {
        public readonly int First;
        public readonly int Last;

        public Range(int first, int last)
        {
            First = first;
            Last = last;
        }

        public override string ToString()
        {
            return $"{First}:{Last}";
        }
    }
}