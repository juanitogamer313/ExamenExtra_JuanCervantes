namespace ExamenExtra_FundamentosSoftware_JuanCervantes.interfaces;

public interface IPersonaje
{

    string Nombre { get; }
    int Nivel { get; }
    int Ataque { get; }
    int Defensa { get; }
    int VidaMaxima { get; }
    int VidaActual { get; }
    int ManaMaximo { get; }
    int ManaActual { get; }
    ClaseHabilidad Clase { get; }
    List<IHabilidad> HabilidadesAprendidas { get; }
    List<IHabilidadNormal> HabilidadesNormalesEquipadas { get; }
    IHabilidadPasiva HabilidadPasivaEquipada { get; }

    void SubirNivel();
    List<IHabilidad> ObtenerHabilidadesAprendidas();
    List<IHabilidadNormal> ObtenerHabilidadesNormalesEquipadas();
    void EquiparHabilidad(IHabilidad habilidad);
    void DesEquiparHabilidad(IHabilidad habilidad);
    void LanzarHabilidad(int indice, IPersonaje objetivo);
    void ExaminarPersonaje();
    void Morir();

}