namespace TamogotchiAPI.Modelspl
{
    public class pets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
    }
}