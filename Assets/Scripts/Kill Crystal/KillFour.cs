using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFour : MonoBehaviour
{
    public GameObject LivesCrystal;
    private CrystalLives clFour;

    // Start is called before the first frame update
    void Start()
    {
        clFour = LivesCrystal.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clFour.lives == 3)
        {
            Destroy(gameObject);
        }
    }
}
