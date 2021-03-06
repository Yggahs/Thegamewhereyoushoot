﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchZone : MonoBehaviour {
    GameObject PlayerRef;
    Material currentMat;
    Material forestMat;
    Material labMat;
    Material officeMat;
    //Material targetMat = null;
    private void Start()
    {
        PlayerRef = GameObject.FindGameObjectWithTag("GameController");
        
        labMat = PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().lab;
        forestMat = PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().forest;
        officeMat = PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().offices;
    }
    public void SwitchToForest()
    {
        if (PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material != forestMat)
        {            
            PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material = forestMat;   
        }

    }
    public void SwitchToLab()
    {
        if (PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material != labMat)
        {
            PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material = labMat;
        }
    }
    public void SwitchToOffices()
    {
        if (PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material != officeMat)
        {   
            PlayerRef.transform.GetChild(7).GetComponent<BackgroundScript>().bgRend.material = officeMat;
        }
    }
}
