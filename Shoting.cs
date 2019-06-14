using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public Transform BulletPref;
    public Transform Pivot;
    public int Power = 100;
    private bool StartRecharg = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & Power==100)
        {
            Instantiate(BulletPref, Pivot.position, Pivot.rotation);
            Power = 0;
        }

        //if (Input.GetButtonDown("R"))
        //{

        //}

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RechargingPosition")
        {
            StartRecharg = true;
        }
    }

    void Recharging()
    {
        if (StartRecharg & Input.GetKeyDown(KeyCode.F) & Power<100)
        {
            Power += 10;
        }

    }
}
