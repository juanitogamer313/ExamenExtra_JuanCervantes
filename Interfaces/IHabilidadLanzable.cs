namespace ExamenExtra_FundamentosSoftware_JuanCervantes.interfaces;

public interface IHabilidadLanzable : IHabilidad
{

    int CostoMana { get; }
    bool AutoAplicable { get; }
    TipoEfecto TipoEfecto { get; }
    int Potencia { get; }
    void Lanzar(IPersonaje lanzador, IPersonaje objetivo);

}