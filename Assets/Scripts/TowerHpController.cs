using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHpController : MonoBehaviour
{
    public TowerHPCounter towerHpCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            towerHpCounter.towerHp--;
            Debug.Log("TowerHp: " + towerHpCounter.towerHp);
            Destroy(collision.gameObject);
            if(towerHpCounter.towerHp <= 0)
            {
                SceneManager.LoadScene("GameOver");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
