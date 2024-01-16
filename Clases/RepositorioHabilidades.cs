namespace ExamenExtra_FundamentosSoftware_JuanCervantes.Clases;

public class RepositorioHabilidades : IRepositorioHabilidades
{
    private List<IHabilidad> habilidades;

    public RepositorioHabilidades()
    {
        habilidades = new List<IHabilidad>();
        AgregarHabilidad(new Habilidad("Bola de fuego", 1, ClaseHabilidad.Mago, TipoHabilidad.Normal, 5, false, TipoEfecto.Daño, 10));
        AgregarHabilidad(new Habilidad("Bonk", 1, ClaseHabilidad.Guerrero, TipoHabilidad.Normal, 5, false, TipoEfecto.Daño, 10));
        AgregarHabilidad(new Habilidad("Rayo", 3, ClaseHabilidad.Mago, TipoHabilidad.Normal, 10, false, TipoEfecto.Daño, 25));
        AgregarHabilidad(new Habilidad("Curacion menor", 5, ClaseHabilidad.Mago, TipoHabilidad.Normal, 8, true, TipoEfecto.Curacion, 10));
        AgregarHabilidad(new HabilidadPasiva("Sabiduria", 7, ClaseHabilidad.Mago, "Aumenta el mana máximo del personaje en 10 puntos."));
    }

    public IHabilidad BuscarHabilidad(string id)
    {
        return habilidades.FirstOrDefault(h => h.Id == id);
    }

    public List<IHabilidad> BuscarHabilidades(ClaseHabilidad clase, int nivelRequerido)
    {
        return habilidades.Where(h => h.Clase == clase && h.NivelRequerido == nivelRequerido).ToList();
    }

    public List<IHabilidad> ObtenerTodasLasHabilidades()
    {
        return habilidades.ToList();
    }

    public void AgregarHabilidad(IHabilidad habilidad)
    {
        habilidades.Add(habilidad);
    }
}