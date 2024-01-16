namespace ExamenExtra_FundamentosSoftware_JuanCervantes.Clases;

public class Habilidad : IHabilidadLanzable
{
    public string Id { get; private set; }
    public string Nombre { get; private set; }
    public int NivelRequerido { get; private set; }
    public ClaseHabilidad Clase { get; private set; }
    public TipoHabilidad Tipo { get; private set; }
    public int CostoMana { get; private set; }
    public bool AutoAplicable { get; private set; }
    public TipoEfecto TipoEfecto { get; private set; }
    public int Potencia { get; private set; }

    public Habilidad(string nombre, int nivelRequerido, ClaseHabilidad clase, TipoHabilidad tipo, int costoMana, bool autoAplicable, TipoEfecto tipoEfecto, int potencia)
    {
        Id = Guid.NewGuid().ToString(); // Asigna un identificador único
        Nombre = nombre;
        NivelRequerido = nivelRequerido;
        Clase = clase;
        Tipo = tipo;
        CostoMana = costoMana;
        AutoAplicable = autoAplicable;
        TipoEfecto = tipoEfecto;
        Potencia = potencia;
    }

    public void Lanzar(IPersonaje lanzador, IPersonaje objetivo)
    {
        
    }
}