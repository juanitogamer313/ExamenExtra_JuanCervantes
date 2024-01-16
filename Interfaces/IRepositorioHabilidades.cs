namespace ExamenExtra_FundamentosSoftware_JuanCervantes.interfaces;

public interface IRepositorioHabilidades
{

    IHabilidad BuscarHabilidad(string id);
    List<IHabilidad> BuscarHabilidades(ClaseHabilidad clase, int nivelRequerido);
    List<IHabilidad> ObtenerTodasLasHabilidades();
    void AgregarHabilidad(IHabilidad habilidad);

}