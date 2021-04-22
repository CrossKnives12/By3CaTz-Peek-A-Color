using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D red)
    {
        if (red.CompareTag("BulletRed"))
        {
            ScoreScript.scoreValue += 5;
            Destroy(gameObject);
        }
    }
}
