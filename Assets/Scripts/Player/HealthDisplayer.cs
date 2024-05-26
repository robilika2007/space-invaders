using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplayer : MonoBehaviour
{
    public Health idk;
    public TMP_Text health;
    int HP;
    int maxHP;
    // Start is called before the first frame update
    void Start()
    {
        HP = idk.currentHealth;
        maxHP = idk.health;
        
        health.text = HP.ToString() + " / " + maxHP.ToString();        
    }

    // Update is called once per frame
    void Update()
    {
        HP = idk.currentHealth;
        maxHP = idk.health;
        
        health.text = HP.ToString() + " / " + maxHP.ToString();    
    }
}
