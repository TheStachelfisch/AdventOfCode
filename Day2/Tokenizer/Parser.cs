using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day2.Tokenizer
{
    public class Parser
    {
        private const RegexOptions OPTIONS = RegexOptions.IgnoreCase;
        
        private string[] _input;
        private List<Token> _tokens = new List<Token>();
        
        public Parser(string[] input) => _input = input;

        public Parser Parse()
        {
            foreach (var password in _input)
            {
                var rangeMatches = new Regex(@"(.\d-.\d)*[0-9]{1,2}").Matches(password);
                Range range = new Range(int.Parse(rangeMatches[0].Value), int.Parse(rangeMatches[1].Value));

                char symbol = char.Parse(new Regex(@"\s(.*?):").Match(password).Groups[1].Value);
                
                _tokens.Add(new Token(range, symbol, new Regex(@"[a-z]{2,}").Match(password).Value));
            }

            return this;
        }

        public List<Token> Build() => _tokens;
    }
}