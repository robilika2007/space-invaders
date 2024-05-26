using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startEasyScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void runEasy()
    {
        SceneManager.LoadScene("EasyMode");
    }
    public void runMedium()
    {
        SceneManager.LoadScene("MediumMode");
    }
    public void runHard()
    {
        SceneManager.LoadScene("HardMode");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
