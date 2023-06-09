﻿int[] cantTipo = { 0, 0, 0, 0}, abonoDia = {0, 0, 0, 0};
int abonoTotal = 0, id;
int seleccion = Funciones.IngresarIntEntre("Ingresá la opción que quieras", 1, 5);
while(seleccion!=5){
    switch(seleccion){
        case 1:
            Cliente cliente = NuevaInscripcion();
            Console.WriteLine("Su numero de entrada es " + Ticktera.AgregarCliente(cliente));
            break;
        case 2:
        if(Ticktera.ExistenClientes() == false) Console.WriteLine("Aún no se anotó nadie");
        else ObtenerEstadistcasEvento();
            break;
        case 3:
        id = Funciones.IngresarInt("Ingresá el ID de la persona que busques");
        if(Ticktera.BuscarCliente(id) == null) Console.WriteLine("no existe dicho ID");
        else BuscarCliente(id);
            break;
        case 4:
        id = Funciones.IngresarInt("Ingresá el ID de la persona a la que le quieras cambiar la entrada");
        if(Ticktera.BuscarCliente(id) == null) Console.WriteLine("no existe dicho ID");
        else {
            int tipoCambiar = Funciones.IngresarInt("Ingresá el tipo de entrada por la que la quieras cambiar");
        int abonoCambiar = SaberAbono(tipoCambiar);
        if(Ticktera.CambiarEntrada(id, tipoCambiar, abonoCambiar)){
            Ticktera.BuscarCliente(id).tipoEntrada = tipoCambiar;
            Ticktera.BuscarCliente(id).totalAbonadoEntrada = abonoCambiar;
            Console.WriteLine("Cambio realizado con exito");
        }
        else Console.WriteLine("No fue posible cambiar la entrada");
        }        
            break;
    }
    seleccion = Funciones.IngresarIntEntre("Ingresá la opción que quieras", 1, 5);
}

void BuscarCliente(int id){
    Console.WriteLine("Nombre: " + Ticktera.BuscarCliente(id).nombre);
    Console.WriteLine("Apellido: " + Ticktera.BuscarCliente(id).nombre);
    Console.WriteLine("DNI: " + Ticktera.BuscarCliente(id).dni);
    Console.WriteLine("Tipo de entrada que compró: " + Ticktera.BuscarCliente(id).tipoEntrada);
    Console.WriteLine("Total abonado: " + Ticktera.BuscarCliente(id).totalAbonadoEntrada);
    Console.WriteLine("Fecha de inscripción: " + Ticktera.BuscarCliente(id).fechaInscripcion);
}

Cliente NuevaInscripcion()
{
    string nombre = Funciones.IngresarString("Ingresá el nombre del cliente: ");
    string apellido = Funciones.IngresarString("Ingresá el apellido del cliente: ");
    int dni = Funciones.IngersarDni("Ingresá el DNI: ");
    DateTime fechaIncripcion = Funciones.IngresarDateTime("Ingresá la fecha de inscripción");
    int tipoEntrada = Funciones.IngresarIntEntre("Ingresá el tipo de entrada", 1, 3);
    int valorAbonado = SaberAbono(tipoEntrada);
    
    return new Cliente(dni, apellido, nombre, fechaIncripcion, tipoEntrada, valorAbonado);
}
int SaberAbono(int tipoEntrada){
    int valorAbonado = 0;
switch (tipoEntrada)
    {
        case 1:
            valorAbonado = 15000;
            break;
        case 2:
        valorAbonado = 30000;
            break;
        case 3:
            valorAbonado = 10000;
            break;
        case 4:
            valorAbonado = 40000;
            break;
    }
return valorAbonado;
}
void ObtenerEstadistcasEvento(){  
    foreach(string texto in Ticktera.EstadisticasTicketera())
    {
        Console.WriteLine(texto);
    }
}