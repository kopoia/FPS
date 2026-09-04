using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPGController : MonoBehaviour
{
    public Image RPGImage;
    public RayCaster Raycaster;
    // Start is called before the first frame update
    void Start()
    {
        Color color = RPGImage.color;
        color.a = 0.1f;
        RPGImage.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCounter.destroyedEnemyCount >= 5)
        {
            Color color = RPGImage.color;
            color.a = 1f;
            RPGImage.color = color;
            if(Input.GetKeyDown(KeyCode.R))
            {
                Raycaster.pistol.SetActive(false);
                Raycaster.rocketLauncher.SetActive(true);
            }
        }
        else
        {
            Color color2 = RPGImage.color;
            color2.a = 0.1f;
            RPGImage.color = color2;
        }
    }
}
