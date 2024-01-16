namespace ExamenExtra_FundamentosSoftware_JuanCervantes.interfaces; 
    public interface IHabilidad
    {
        string Id {get; }
        string Nombre {get; }
        int NivelNecesario {get; }
        ClaseHabilidad Clase{get; }
        TipoHabilidad Tipo{get; }
    }
