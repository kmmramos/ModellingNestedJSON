namespace ModelThatJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\kirstinmegga.ramos\source\repos\ModelThatJson\ModelThatJson\sample.json";

            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<MyModel>(jsonText);
        }
    }
}