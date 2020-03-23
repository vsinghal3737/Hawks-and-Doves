using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void addRecord()
    {
        for (int i=0; i < 5; i++)
        {
            string fileName = Application.dataPath + "/file_" + i.ToString() + "-" + DateTime.Now.ToString("HH-mm-ss-MM-dd-yyyy") + ".csv";
            File.AppendAllText(fileName, i.ToString() + ",asdasd,asdasd");
            File.AppendAllText(fileName, "asdasd\n");

            File.AppendAllText(fileName, "asdasd\n");
            File.AppendAllText(fileName, "asdasd\n");
            File.AppendAllText(fileName, "asdasd\n");
            //File.AppendAllLines(fileName, List<string>["asdasd","asdasd","asdasd"]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
