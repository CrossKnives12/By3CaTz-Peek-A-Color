using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchC : MonoBehaviour
{
    private SpriteRenderer rend;

    public bool isBlack = true;
    public bool isRed = false;
    public bool isGreen = false;
    public bool isBlue = false;
    public bool isYellow = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            // Red
            isBlack = false;
            isRed = true;
            isGreen = false;
            isBlue = false;
            isYellow = false;
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            // Green
            isBlack = false;
            isRed = false;
            isGreen = true;
            isBlue = false;
            isYellow = false;
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            // Blue
            isBlack = false;
            isRed = false;
            isGreen = false;
            isBlue = true;
            isYellow = false;
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            // Yellow
            isBlack = false;
            isRed = false;
            isGreen = false;
            isBlue = false;
            isYellow = true;
        }




    }
}
