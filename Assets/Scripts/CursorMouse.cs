using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMouse : MonoBehaviour
{
    public GameObject MaskDisable;
    private CrystalLives clMD;
    private SpriteMask sm;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        clMD = MaskDisable.GetComponent<CrystalLives>();
        sm = GetComponent<SpriteMask>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;


        if(clMD.isStop == true)
        {
            sm.enabled = false;
        }

    }
}
