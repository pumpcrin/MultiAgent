using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2DManager : MonoBehaviour
{
    public static Map2DManager Singleton;

    Dictionary<Color, GameObject> col2Buildings;

    public GameObject field;
    Texture2D map;
    Vector3 offset;

    void Awake(){
        Singleton = this ?? Singleton;
    }

    void Start()
    {

        map = field.GetComponent<Renderer>().material.mainTexture as Texture2D;
        col2Buildings = new Dictionary<Color, GameObject>();

        var buildingsParent = new GameObject();
        buildingsParent.name = "Buildings";
        buildingsParent.transform.parent = field.transform;

        var cols = new Color[]{Color.black, Color.red, Color.green, Color.blue};
        foreach(var col in cols){
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = Vector3.one * 0.8f;
            cube.transform.position = Vector3.one * -10000;
            cube.GetComponent<Renderer>().material.color = col;
            col2Buildings.Add(col, cube);
        }

        offset = new Vector3(map.width, 0, map.height)/2 * (-1) + new Vector3(1, 0, 1)*0.5f;

        var pixels = map.GetPixels();
        for(int z = 0; z < map.height; z++){
            for(int x = 0; x < map.width; x++){
                int index = z*map.width + x;
                var col = pixels[index];
                if(col == Color.black)
                    continue;

                var pos = new Vector3(x, 0, z);

                var building = Instantiate(col2Buildings[col], offset + pos, Quaternion.identity);
                building.transform.parent = buildingsParent.transform;
            }
        }
    }

    public Vector3 GetPosition(Vector2 pos){
        return offset + new Vector3(pos.x, 0, pos.y);
    }

    public Vector2 GetPos(Vector3 position){
        var normalizedPosition = position - offset;
        int x = Mathf.RoundToInt(position.x);
        int z = Mathf.RoundToInt(position.z);

        return new Vector2(x, z);
    }
}