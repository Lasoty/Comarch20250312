using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia20250312.App.Cwiczenia;

class CarManager
{
    public void Metoda()
    {
        ICar car = new Car();
        ICar car2 = new Truck();

        Car car3 = new Truck();
        Truck truck = (Truck)car3;

        Metoda2(car);
        Metoda2(car2);
        Metoda2(car3);
        Metoda2(truck);

        Auto auto = new Car();

        Car car5 = new Bus();
        car5.Zatankuj();

        Bus car5b = (Bus)car5;
        car5b.Zatankuj();

        Car car6 = new Truck();
        car5.Zatankuj();

    }

    public void Metoda2(ICar car)
    {
        car.Uruchom();
    }
}

public interface ICar
{
    string Marka { get; init; }

    void Uruchom();
}

abstract class Auto
{
    public string Model { get; set; }

    public abstract void Zatankuj();
}

class Car : Auto, ICar
{
    public string Marka { get; init; }

    public void Uruchom()
    {
        Console.WriteLine("Metoda uruchom klasy Car.");
    }

    public override void Zatankuj()
    {
        
    }
}

class Truck : Car
{
    public Truck()
    {
        Marka = "MAN";
    }

    public override void Zatankuj()
    {
        Console.WriteLine("Metoda zatankuj z klasy Truck");
        base.Zatankuj();
    }
}

sealed class Bus : Truck, INotifyPropertyChanged, ICloneable
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public new void Zatankuj()
    {
        base.Zatankuj();
    }
}


