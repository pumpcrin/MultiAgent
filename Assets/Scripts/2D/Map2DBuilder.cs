using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2DBuilder : MonoBehaviour
{


    public GameObject field;
    Texture map;

    void Start()
    {
        map = field.GetComponent<Material>().mainTexture;
        Debug.Log("isTexture2D: "+(map is Texture2D));
        
    }
}