using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillThree : MonoBehaviour
{
    public GameObject LivesCrystal;
    private CrystalLives clThree;

    // Start is called before the first frame update
    void Start()
    {
        clThree = LivesCrystal.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clThree.lives == 2)
        {
            Destroy(gameObject);
        }
    }
}
