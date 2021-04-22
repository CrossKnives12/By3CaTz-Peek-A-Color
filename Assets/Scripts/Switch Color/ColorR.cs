using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorR : MonoBehaviour
{
    public GameObject Switcher;
    private SwitchC scR;
    private SpriteRenderer sRendRed;

    // Start is called before the first frame update
    void Start()
    {
        scR = Switcher.GetComponent<SwitchC>();
        sRendRed = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scR.isRed == true)
        {
            sRendRed.enabled = true;
        }

        if (scR.isRed == false)
        {
            sRendRed.enabled = false;
        }




    }
}
