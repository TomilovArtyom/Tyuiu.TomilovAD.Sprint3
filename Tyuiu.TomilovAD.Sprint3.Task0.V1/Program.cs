using Tyuiu.TomilovAD.Sprint3.Task0.V1.Lib;

DataService ds = new DataService();

int value = 4;
int startvalue = 1;
int endvalue = 15;

Console.WriteLine(ds.GetSumSeries(value, startvalue, endvalue));