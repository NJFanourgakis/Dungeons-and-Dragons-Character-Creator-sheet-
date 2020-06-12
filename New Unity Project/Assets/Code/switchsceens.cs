using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchsceens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
     public string  move (GameObject at, GameObject to){
        at.active = false;
        to.active = true;
        return "go";
        }
}
