using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe pour détruire l'objet en préfab
public class Destruction : MonoBehaviour
{
    [SerializeField]
    private float timeout = 2;

    private float startTime;
    private void OnEnable() 
    {
        startTime = Time.time; 
    }

    private void Update() {
        if(Time.time - startTime > timeout)
        {
            Destroy(gameObject);
        }
    }

}
