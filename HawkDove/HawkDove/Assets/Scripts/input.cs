using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class input : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI Hawks;
    public TextMeshProUGUI Doves;
    public TextMeshProUGUI Food;
    void Start()
    {
        
    }
    public void check()
    {
        DataSource obj = DataSource.getSingletonInstance();
        obj.setNumberOfHawks(Int32.Parse(Hawks.text.Replace("\u200B", "").ToString()));
        obj.setNumberOfDoves(Int32.Parse(Doves.text.Replace("\u200B", "").ToString()));
        obj.setNumberOfFood(Int32.Parse(Food.text.Replace("\u200B", "").ToString()));
        Debug.Log(obj.getNumberOfDoves());
        Debug.Log(obj.getNumberOfHawks());
        Debug.Log(obj.getNumberOfFood());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
