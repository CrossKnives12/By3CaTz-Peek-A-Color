using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorB : MonoBehaviour
{
    public GameObject Switcher;
    private SwitchC scB;
    private SpriteRenderer sRendBlue;

    // Start is called before the first frame update
    void Start()
    {
        scB = Switcher.GetComponent<SwitchC>();
        sRendBlue = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scB.isBlue == true)
        {
            sRendBlue.enabled = true;
        }

        if (scB.isBlue == false)
        {
            sRendBlue.enabled = false;
        }
    }
}
