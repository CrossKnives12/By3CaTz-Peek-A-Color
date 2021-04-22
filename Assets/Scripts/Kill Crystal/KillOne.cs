using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOne : MonoBehaviour
{
    public GameObject LivesCrystal;
    private CrystalLives clOne;

    // Start is called before the first frame update
    void Start()
    {
        clOne = LivesCrystal.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clOne.lives == 0)
        {
            Destroy(gameObject);
        }
    }
}
