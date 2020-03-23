using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("HawksSphere") as GameObject;
        for (int i=100; i < 102; i++)
        {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.position = new Vector3(i*5, i, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
