using Tyuiu.TomilovAD.Sprint3.Task0.V1.Lib;

DataService ds = new DataService();

int startvalue = 1;
int endvalue = 15;

Console.WriteLine(ds.GetSumSeries(startvalue, endvalue));