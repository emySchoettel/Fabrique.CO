using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fabrique.CO.Assets.Scripts.Abstract
{
        public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string animalType)
        {
            if(animalType.Equals("Chien"))
                return new Chien(); 
            else if (animalType.Equals("Chat"))
                return new Chat();
            else
                return null; 
        }
    }
}