using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplayer : MonoBehaviour
{
    public TMP_Text text;
    public bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        if(won == true)
        text.text = "It took you " + GlobalTimer.time.ToString() + " frames to defeat the enemies!"; 
        else 
        text.text = "You lasted for " + GlobalTimer.time.ToString() + " frames!";        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
