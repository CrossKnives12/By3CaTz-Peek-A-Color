using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    public GameObject destroyEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * speed * Time.deltaTime;
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        Destroy(gameObject, lifeTime);
    }


    // This is for particle effect and destroy object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
