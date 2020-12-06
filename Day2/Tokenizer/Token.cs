namespace Day2.Tokenizer
{
    public class Token
    {
        public readonly char Character;
        public readonly Range Range;
        public readonly string Value;

        public Token(Range range, char character, string value)
        {
            Range = range;
            Character = character;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Range.First}-{Range.Last} {Character}: {Value}";
        }
    }
}