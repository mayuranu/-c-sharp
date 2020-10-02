using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Text;
usingSystem.Threading.Tasks;


namespace eventTestClass
{

Class Program
    {
Private int nvalue;
Public delegate void valueChangedEventHandler();
Public event valueChangedEventHandler changed;
Protected virtual void onChanged()
        {
if (changed != null)
changed();
else
Console.WriteLine("Event fired. No Handler");
        }

Public Program (int value)
        {
SetValue(nvalue);
        }
Public void SetValue(int nv)
        {
if (nvalue!=nv)
            {
nvalue = nv;
onChanged();
            }
        }

    }
Class Program1
    {
Public void HandlerChange1()
        {
Console.WriteLine("Handler1");
        }
Public void HandlerChange2()
        {
Console.WriteLine("Handler2");
        }
Public void HandlerChange3()
        {
Console.WriteLine("Handler3");
        }

Static void Main(string[] args)
        {
Program p1 = newProgram(9);
Program1 p2 = newProgram1();
Program1 p3 = newProgram1();
            p1.SetValue(10);
            p1.changed += newProgram.valueChangedEventHandler(p2.HandlerChange1);
            p1.changed += newProgram.valueChangedEventHandler(p2.HandlerChange2);
            p1.SetValue(5);
            p1.SetValue(5);

            p1.changed += newProgram.valueChangedEventHandler(p2.HandlerChange1);
            p1.SetValue(5);
            p1.changed += newProgram.valueChangedEventHandler(p2.HandlerChange1);
            p1.SetValue(44);
            p1.SetValue(44);
            p1.SetValue(44);
            p1.changed += newProgram.valueChangedEventHandler(p3.HandlerChange3);
Console.WriteLine("Enter any key");
Console.ReadKey();

        }
    }
}

