using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   namespace Fabrique.CO.Assets.Scripts.Abstract
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Requin"))
            {
                return new Requin();
            }
            else if (AnimalType.Equals("Calamar"))
            {
                return new Calamar();
            }
            else
                return null;
        }
    }
}
