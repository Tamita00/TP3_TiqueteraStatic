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

    public static bool ExistenClientes(){
        bool posible = true;
        if(dicClientes == null) posible = false;
        return posible;
    }

    public static List<string> EstadisticasTicketera(){
        estadisticasTicketera.Add("La cantidad de  entradas compradas es " + dicClientes.Count);
        int[] cantTipo = new int[4], plataTipo = new int[4];
        int totalEntradas = 0, recTotal = 0;;
        foreach(Cliente item in dicClientes.Values)
        {
            cantTipo[item.tipoEntrada -1]++;
            plataTipo[item.tipoEntrada -1] += item.totalAbonadoEntrada; 
            totalEntradas++;
            recTotal += item.totalAbonadoEntrada;

        }
        estadisticasTicketera.Add("Cantidad de  entradas compradas: " + dicClientes.Count);
        estadisticasTicketera.Add("Porcentaje de cantidad de  entradas vendidas tipo 1: " + cantTipo[0]/totalEntradas);
        estadisticasTicketera.Add("Porcentaje de cantidad de  entradas vendidas tipo 2: " + cantTipo[1]/totalEntradas);
        estadisticasTicketera.Add("Porcentaje de cantidad de  entradas vendidas tipo 3: " + cantTipo[2]/totalEntradas);
        estadisticasTicketera.Add("Porcentaje de cantidad de  entradas vendidas tipo 1: " + cantTipo[3]/totalEntradas);
        estadisticasTicketera.Add("Recaudación de entradas tipo 1: " + plataTipo[0]);
        estadisticasTicketera.Add("Recaudación de entradas tipo 2: " + plataTipo[1]);
        estadisticasTicketera.Add("Recaudación de entradas tipo 3: " + plataTipo[2]);
        estadisticasTicketera.Add("Recaudación de entradas tipo 4: " + plataTipo[3]);
        estadisticasTicketera.Add("Recaudación total: " + recTotal);
        return estadisticasTicketera;
    }
}