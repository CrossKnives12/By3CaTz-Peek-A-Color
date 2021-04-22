using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalLives : MonoBehaviour
{
    public int lives = 5;
    private SpriteRenderer rend;

    public float counter = 1f;
    public bool isStop = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            Color c = rend.material.color;
            c.a -= 0.01f;
            rend.material.color = c;

            if (lives == 0 && c.a == 0)
            {
                c.a -= 0.01f;
                rend.material.color = c;
                if (c.a == 0f)
                {
                    c.a = 0f;
                    Destroy(gameObject);
                }
            }
            else
            {
               // c.a = 0f;
                rend.material.color = c;
            }//
        }

        // Counter to destroy
        if(lives <= 0)
        {
            lives = 0;
            counter -= 0.01f;
        }
        
        if(counter <= 0f)
        {
            isStop = true;
            counter = 0;
            Destroy(gameObject);
            Time.timeScale = 0f;
        }


    }

    void OnTriggerEnter2D(Collider2D crystal)
    {
        if (crystal.CompareTag("Enemy"))
        {
            lives--;
        }
    }
}
