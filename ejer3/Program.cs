using ejer3;

Desayuno des=new Desayuno();
des.Nombre ="Continental";
des.Precio =20.5;
des.Dias ="Lun, mar, mier";

Console.WriteLine(des);

string[] lista = des.ListaDias();
foreach (string str in lista) 
{
    Console.WriteLine(str);
}

