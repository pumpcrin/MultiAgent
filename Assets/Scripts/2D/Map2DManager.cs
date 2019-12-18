using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2DManager : MonoBehaviour
{
    Dictionary<Color, GameObject> col2Buildings;

    public GameObject field;
    Texture2D map;
    Vector3 offset;

    void Start()
    {
        map = field.GetComponent<Renderer>().material.mainTexture as Texture2D;
        col2Buildings = new Dictionary<Color, GameObject>();

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
            }
        }
    }

    public Vector3 GetPos(Vector2 pos){
        return offset + new Vector3(pos.x, 0, pos.y);
    }
}