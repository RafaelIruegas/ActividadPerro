namespace ActividadPerro.Models.ViewModels
{
    public class Pais
    {
        public List<Pai> pai { get; set; } = null!;
    }
    public class Pai
    {
        public int Id { get; set; }
        public string NamePais { get; set; } = null!;
        public IEnumerable<Perro> perros { get; set; } = null!;
    }
    public class Perro
    {
        public int Id { get; set; }
        public string Nombre { get; set;} = null!;

    }
}
