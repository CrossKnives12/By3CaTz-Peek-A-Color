using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Over;
    private CrystalLives clGO;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        clGO = Over.GetComponent<CrystalLives>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(clGO.isStop == true)
        {
            sr.enabled = true;
        }


    }
}
