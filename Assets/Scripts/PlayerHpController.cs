using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpController : MonoBehaviour
{
    public static int playerHp = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerDamage()
    {
        playerHp--;
        //Debug.Log("PlayerHP: " + playerHp);
    }
}
