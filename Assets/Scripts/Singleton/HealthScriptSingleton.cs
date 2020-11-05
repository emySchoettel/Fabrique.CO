using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScriptSingleton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ManagerSingleton.instance.HP--; 
        }
        else if(ManagerSingleton.instance.HP == 0)
        {
            Destroy(gameObject);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            ManagerSingleton.instance.AddHealth(); 
        }
    }

}
