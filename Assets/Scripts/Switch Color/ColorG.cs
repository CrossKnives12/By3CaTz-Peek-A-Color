using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorG : MonoBehaviour
{
    public GameObject Switcher;
    private SwitchC scG;
    private SpriteRenderer sRendGreen;

    // Start is called before the first frame update
    void Start()
    {
        scG = Switcher.GetComponent<SwitchC>();
        sRendGreen = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scG.isGreen == true)
        {
            sRendGreen.enabled = true;
        }

        if (scG.isGreen == false)
        {
            sRendGreen.enabled = false;
        }
    }
}
