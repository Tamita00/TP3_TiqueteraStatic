public static class Ticktera{
    private static Dictionary<int, Cliente> dicClientes = new Dictionary<int, Cliente>();
    private static List<string> estadisticasTicketera = new List<string>();
    private static int UltimoIdEntrada = 0;

    public static int DevolverUltimoId(){
        return UltimoIdEntrada;
    }

    public static int AgregarCliente(Cliente cliente){
        dicClientes.Add(++UltimoIdEntrada,cliente);
        return UltimoIdEntrada;
    }

    public static Cliente BuscarCliente(int idEntrada){
        return dicClientes[idEntrada];
    }

    public static bool CambiarEntrada(int id, int tipoCambiar, int totalCambiar){
        bool posible = true;
        if(dicClientes[id].totalAbonadoEntrada > totalCambiar) posible = false;
        return posible;
    }

    public static List<string> EstadisticasTicketera(){
        estadisticasTicketera.Add("La cantidad de  entradas compradas es " + dicClientes.Count);
        int[] cantTipo = new int[4];
        int[] plataTipo = new int[4];
        foreach(Cliente item in dicClientes.Values)
        {
            cantTipo[item.tipoEntrada -1]++;
            plataTipo[item.tipoEntrada -1] += item.totalAbonadoEntrada; 
        }
        return estadisticasTicketera;
    }
}