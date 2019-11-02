namespace Neo4jClient.Extension.Test.Cypher
{
    public static class TestExtensions
    {
        public static string CorrectLineBreak(this string text)
        {
            return text.Replace("\nSET", " SET");
        }
    }
}