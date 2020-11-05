using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Classe initiale usine qui instancie un prefab
public class Usine : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour prefab;
    
    public MonoBehaviour GetNewInstance()
    {
        return Instantiate(prefab); 
    }
}
