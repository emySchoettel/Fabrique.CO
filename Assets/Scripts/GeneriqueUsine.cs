using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe de l'usine générique avec T comme type qui est un script de type MonoBehaviour et qui instancie un prefab
public class GeneriqueUsine<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private T prefab;

    public T GetNewInstance()
    {
        return Instantiate(prefab);
    }
}