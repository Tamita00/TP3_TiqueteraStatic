public static class Funciones{
    public static DateTime IngresarDateTime(string msg){
	Console.WriteLine(msg);
	return DateTime.Parse(Console.ReadLine());
}
public static int IngersarDni(string msg){
    int dni = IngresarInt(msg);
    while(dni.ToString().Length > 8 || dni < 0){
        dni = IngresarInt(msg);
    }
    return dni;
}
public static int IngresarInt(string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine());
}

public static string IngresarString(string msg)
{
	Console.WriteLine(msg);
	return Console.ReadLine();
}
public static int IngresarIntEntre(string msg, int desde, int hasta)
{
	int num;
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	while(num < desde || num > hasta + 1)
	{
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	}
	return num;
}

}