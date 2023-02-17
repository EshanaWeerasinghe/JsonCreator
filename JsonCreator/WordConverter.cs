using Newtonsoft.Json;

namespace JsonCreator
{
    public class WordConverter
    {
        private readonly List<TestWordModel> RequireWordList = new List<TestWordModel>();

        public void ConvertList()
        {
            InitializeWordList();
        }

        private void InitializeWordList()
        {
            RequireWordList.Add(new TestWordModel()
            {
                WordList = new List<WordModel>()
                {
                    new WordModel()
                    {
                        Team ="Netherlands",
                        Seed="1A"
                    },
                     new WordModel()
                    {
                        Team ="England",
                        Seed="1B"
                    },
                    new WordModel()
                    {
                        Team ="Argentina",
                        Seed="1C"
                    },
                     new WordModel()
                    {
                        Team ="Brazil",
                        Seed="1E"
                    },
                      new WordModel()
                    {
                        Team ="France",
                        Seed="1D"
                    },
                }
            });

            var Attachment = JsonConvert.SerializeObject(RequireWordList);
        }
    }
}