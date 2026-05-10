using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainScene()
    {
        PlayerHpController.playerHp = 3;
        ScoreCounter.destroyedEnemyCount = 0;
        SceneManager.LoadScene("Main");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
}
