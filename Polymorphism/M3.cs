using System;

namespace Polymorphism
{
    //if BMW class is sealed 
    //then M3 won't be able to inherit it 
    class M3 : BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }

        //since the base class has sealed this method
        //the child class cannot override it anymore
        public override void Repair() //==> will return an error when BMW Repair() is sealed
        {
            base.Repair();
        }
    }
}