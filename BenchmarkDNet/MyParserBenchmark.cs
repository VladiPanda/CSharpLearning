using Benchmark;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDNet
{
    [MemoryDiagnoser()]
    [RankColumn()]
    public class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "qwerty22";
        private const string STRING_TO_PARSE = "54";

        private readonly MyParser _myParser = new MyParser();

        [Benchmark]
        public void TryCatchParseTestWithError()
        {
            int result = _myParser.TryCathParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]
        public void TryParseTestWithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]
        public void TryParseFixedTestWithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]
        public void TryCatchParseTest()
        {
            int result = _myParser.TryCathParse(STRING_TO_PARSE);
        }

        [Benchmark]
        public void TryParseTest()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }

        [Benchmark]
        public void TryParseFixedTest()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }
    }
}