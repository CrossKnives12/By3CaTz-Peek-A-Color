using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D blue)
    {
        if (blue.CompareTag("BulletBlue"))
        {
            ScoreScript.scoreValue += 8;
            Destroy(gameObject);
        }
    }
}
