using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSingleton : MonoBehaviour
{

    public static ManagerSingleton instance = null; 
    public int HP = 3; // Hit point, variable utilisable sur un autre objet

    private void Awake() {
        if(instance == null)
        {
            instance = this; 
        }    
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void AddHealth()
    {
        HP++;
    }
}
