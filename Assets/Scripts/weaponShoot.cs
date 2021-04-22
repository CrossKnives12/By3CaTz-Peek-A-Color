using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShoot : MonoBehaviour
{
    public float offset;

    public GameObject[] projectile;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject switcher;
    private SwitchC sc;
    private int colorNum;

    public GameObject stopper;
    private CrystalLives cl;


    // Start is called before the first frame update
    void Start()
    {
        sc = switcher.GetComponent<SwitchC>();
        cl = stopper.GetComponent<CrystalLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cl.isStop == false)
        { 
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(1f, 0f, rotZ + offset);
        }   

        // Shoots the projectile
        if(cl.isStop == false)
        {

            if(timeBtwShots <= 0)
        {
                if(Input.GetMouseButtonDown(0) && sc.isBlack == true)
                {
                    // Black
                    Instantiate(projectile[0], shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
                else if (Input.GetMouseButtonDown(0) && sc.isRed == true)
                {
                    // Red
                    Instantiate(projectile[1], shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
                else if (Input.GetMouseButtonDown(0) && sc.isGreen == true)
                {
                    // Green
                    Instantiate(projectile[2], shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
                else if (Input.GetMouseButtonDown(0) && sc.isBlue == true)
                {
                   // Blue
                   Instantiate(projectile[3], shotPoint.position, transform.rotation);
                   timeBtwShots = startTimeBtwShots;
                }

                else if (Input.GetMouseButtonDown(0) && sc.isYellow == true)
                {
                   // yellow
                   Instantiate(projectile[4], shotPoint.position, transform.rotation);
                   timeBtwShots = startTimeBtwShots;
                }

            }
            else
            {
               timeBtwShots -= Time.deltaTime;
            }
        }
    }
}
