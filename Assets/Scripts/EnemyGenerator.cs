using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("Generate", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameOver")
        {
            CancelInvoke("Generate");
        }
    }
    void Generate()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
