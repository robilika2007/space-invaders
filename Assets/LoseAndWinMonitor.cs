using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnerMonitoring : MonoBehaviour
{
    public Health spawner1;
    public Health player;
    public Health spawner2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawner1.currentHealth <= 0 && spawner2.currentHealth <= 0)
        {
            SceneManager.LoadScene("WinningScene");
        }

        if (player.currentHealth <= 0)
        {
            SceneManager.LoadScene("LosingScene");
        }
    }
}
