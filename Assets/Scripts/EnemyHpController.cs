using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpController : MonoBehaviour
{
    public int enemyHp = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Damage()
    {
        enemyHp--;
        Debug.Log("EnemyHp:" + enemyHp);
        if(enemyHp <= 0)
        {
            ScoreCounter.destroyedEnemyCount++;
            Destroy(this.gameObject);
        }
    }
}
