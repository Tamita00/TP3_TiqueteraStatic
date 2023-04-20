public class Cliente{
    public int dni {get; private set;}
    public string apellido {get; private set;}
    public string nombre {get; private set;}
    public DateTime fechaInscripcion {get; set;}
    public int tipoEntrada {get; set;}
    public int totalAbonadoEntrada {get; set;}
    
    //Constructor
    public Cliente (int dniRecibido, string apellidoRecibido, string nombreRecibido, DateTime fechaInscripcionRecibida, int tipoEntradaRecibido, int totalAbonadoRecibido)
    {
        dni = dniRecibido;
        nombre = nombreRecibido;
        apellido = apellidoRecibido;
        fechaInscripcion = fechaInscripcionRecibida;
        tipoEntrada = tipoEntradaRecibido;
        totalAbonadoEntrada = totalAbonadoRecibido;
    }
    public Cliente (){}
}