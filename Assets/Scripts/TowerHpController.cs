using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHpController : MonoBehaviour
{
    int towerHp = 10;
    public Text towerHpText;
    // Start is called before the first frame update
    void Start()
    {
        towerHpText.text = "TowerHP: " + towerHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        towerHpText.text = "TowerHP: " + towerHp.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            towerHp--;
            Destroy(collision.gameObject);
            if(towerHp <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
