using Tyuiu.TomilovAD.Sprint3.Task2.V9.Lib;

DataService ds = new DataService();

int value = 5;
int startvalue = 1;
int endvalue = 10;

Console.WriteLine(ds.GetSumSeries(value, startvalue, endvalue));