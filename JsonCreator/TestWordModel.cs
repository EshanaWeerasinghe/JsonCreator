namespace JsonCreator
{
    public class TestWordModel
    {
        public IEnumerable<WordModel> WordList { get; set; }

        public TestWordModel()
        {
            WordList = new List<WordModel>();
        }
    }
}