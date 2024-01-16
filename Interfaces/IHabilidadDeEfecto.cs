namespace ExamenExtra_FundamentosSoftware_JuanCervantes.interfaces;

public interface IHabilidadDeEfecto : IHabilidad
{

    int CostoMana { get; }
    bool AutoAplicable { get; }
    int Potencia { get; }
    TipoEfecto TipoEfecto { get; }
    void Lanzar(IPersonaje lanzador, IPersonaje objetivo);

}