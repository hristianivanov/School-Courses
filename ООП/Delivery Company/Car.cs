using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Company
{
    internal class Car
    {
        //Car с информация за модела, двигателя, товара и колекция от точно 4 гуми.
        //Моделът, товарът и гумите трябва да са отделни класове; създайте конструктор,
        //който получава пълната информация за колата и създава и инициализира нейните вътрешни компоненти(двигател, товар и гуми).


        //<Модел> <СкоростНаДвигателя> <МощностнаДвигателя> <ТеглоНаТовара> <ТипНаТовара>
        //<Гума1Налягане> <Гума1Възраст>
        //<Гума2Налягане> <Гума2Възраст>
        //<Гума3Налягане> <Гума3Възраст>
        //<Гума4Налягане> <Гума4Възраст>

        //ChevroletAstro
        //200 180
        //1000 fragile
        //1.3 1
        //1.5 2
        //1.4 2
        //1.7 4

        public Car(string model,int speed,int power,int weight,string type,double firstTyrePreasure,int firstTyreOld, double secondTyrePreasure, int secondTyreOld,
            double thirdTyrePreasure, int thirdTyreOld, double fourthTyrePreasure, int fourthTyreOld)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tyres.Add(new Tyre(firstTyrePreasure, firstTyreOld));
            Tyres.Add(new Tyre(secondTyrePreasure, secondTyreOld));
            Tyres.Add(new Tyre(thirdTyrePreasure, thirdTyreOld));
            Tyres.Add(new Tyre(fourthTyrePreasure, fourthTyreOld));
        }


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tyre> Tyres { get; set; } = new List<Tyre>();


    }
}
