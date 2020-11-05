using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fabrique.CO.Assets.Scripts.Abstract{
public class ManagerFactory : MonoBehaviour
{

    [SerializeField]
    private GameObject[] prefabs;

    private string[] nomsAnimaux = new string[4] {"Calamar",  "Requin", "Chien", "Chat" }; 
    private string[] typeOfFactory = new string[2] { "Mer", "Terre"};

    // Start is called before the first frame update
    void Start()
    {
        print("Usine à animaux, démarrage"); 
        Animal animal = null;
        AnimalFactory animalFactory = null;  
        int y = 4;   

        foreach(string nomUsine in typeOfFactory)
        {
            animalFactory = AnimalFactory.CreateAnimalFactory(nomUsine);
            print(" Factory type : " + animalFactory.GetType().Name);

            for(int i = 0; i < prefabs.Length; i++)
            {
                animal = animalFactory.GetAnimal(nomsAnimaux[i]);
                if(animalFactory.GetAnimal(nomsAnimaux[i]) != null)
                {
                    print("Un " + animal.GetType().Name  + " est en cours de chargement");
                    Instantiate(prefabs[i], new Vector3(0, y, 0), Quaternion.identity);
                    print(animal.Speak());
                    y = y - 2;
                }               
            }
        }
        print("Fin du clonage par usine !");
        
    }
}

}