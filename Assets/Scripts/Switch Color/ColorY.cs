using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorY : MonoBehaviour
{
    public GameObject Switcher;
    private SwitchC scY;
    private SpriteRenderer sRendYellow;

    // Start is called before the first frame update
    void Start()
    {
        scY = Switcher.GetComponent<SwitchC>();
        sRendYellow = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scY.isYellow == true)
        {
            sRendYellow.enabled = true;
        }

        if (scY.isYellow == false)
        {
            sRendYellow.enabled = false;
        }
    }
}
