using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fabrique.CO.Assets.Scripts.Abstract
{
    public abstract class AnimalFactory
    {
    public abstract Animal GetAnimal(string animalType);

    public static AnimalFactory CreateAnimalFactory(string FactoryType)
    {
        if(FactoryType.Equals("Mer"))
            return new SeaAnimalFactory();
        else
            return new LandAnimalFactory(); 
    }

    }
}
