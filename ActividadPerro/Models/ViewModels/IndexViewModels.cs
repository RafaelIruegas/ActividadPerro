namespace ActividadPerro.Models.ViewModels
{
    public class IndexViewModels
    {
        public List<Dog> DogList { get; set; } = null!;
    }
    public class Dog
    {
        public int Id { get; set; }
        public string NamePerro { get; set; } = null!;
    }
}
