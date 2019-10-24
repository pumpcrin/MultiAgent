using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Villager"){
            c.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    void OnTriggerExit(Collider c){
        if(c.gameObject.tag == "Villager"){
            c.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
