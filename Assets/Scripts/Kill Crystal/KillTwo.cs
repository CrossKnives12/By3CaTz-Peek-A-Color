using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTwo : MonoBehaviour
{
    public GameObject LivesCrystal;
    private CrystalLives clTwo;

    // Start is called before the first frame update
    void Start()
    {
        clTwo = LivesCrystal.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clTwo.lives == 1)
        {
            Destroy(gameObject);
        }
    }
}
