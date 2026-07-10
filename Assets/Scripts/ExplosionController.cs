using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
        {
            Debug.Log("Particle Collision with: " + other.name);
            if (other.gameObject.tag == "Enemy")
            {
                Debug.Log(other.gameObject.name);
                Destroy(other.gameObject);
            }
        }
}
