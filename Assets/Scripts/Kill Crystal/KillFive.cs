using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFive : MonoBehaviour
{
    public GameObject LivesCrystal;
    private CrystalLives clFive;

    // Start is called before the first frame update
    void Start()
    {
        clFive = LivesCrystal.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if(clFive.lives == 4)
        {
            Destroy(gameObject);
        }
    }
}
