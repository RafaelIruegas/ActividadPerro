namespace ActividadPerro.Models.ViewModels
{
    public class Raza
    {
        public int Id { get; set; }
        public string NameRaza { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string OtroNombre { get; set; } = null!;
        public string NomPais { get; set; } = null!;
        public int PesoMax { get; set; }
        public int PesoMin { get; set; }
        public int AlturaMax { get; set; } 
        public int AlturaMin { get; set; }    
        public int Esperanza {  get; set; }
        public string Patas {  get; set; } = null!;
        public string Cola { get; set;} = null!;
        public string Color { get; set; } = null!;
        public string Hosico { get; set; } = null!;
        public string Pelo { get; set; } = null!;
        public uint AmistadePerro { get; set;} 
        public uint NivelEnergia { get; set;} 
        public uint EjercicioObligatorio { get; set; }
        public uint AmistadDesconocido { get; set; } 
        public uint FacilidadEntrenamiento { get; set; } 
        public uint NecesidadCepillado { get; set; }
        public List <Perro>perros { get; set; }
    }

}
