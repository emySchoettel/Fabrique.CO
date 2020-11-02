using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneriqueUsine<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private T prefab;

    public T GetNewInstance()
    {
        return Instantiate(prefab);
    }
}