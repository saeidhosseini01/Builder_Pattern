// See https://aka.ms/new-console-template for more information
using Builder_Pattern.Builder;

Console.WriteLine("Hello, World!");


Direcctor direcctor=new Direcctor ();



var builder1=new Concretebuilder1 ();
var builder2=new Concretebuilder2 ();

direcctor.SetBuilder(builder2);
direcctor.Constract();

var res=builder2.Getresult();
res.Displayinfo();
Console.WriteLine("finished");
Console.ReadLine();
