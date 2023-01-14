using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float fireRate = 1f;
    public GameObject muzzleFlash;
    public OVRInput.Button shootingButton;
    private OVRGrabbable ovrGrabbable;
    public float lastfired = 10;
    public Transform BulletSpawn;
    private bool isReady = false;


    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();

    }

    void Update()
    {
        if(isReady)
            if (ovrGrabbable.isGrabbed && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (Time.time - lastfired > 1 / fireRate)
                {
                    Shoot();
                }
            }
            if (ovrGrabbable.isGrabbed && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (Time.time - lastfired > 1 / fireRate)
                {
                    Shoot();
                }
            }
    }
    void Shoot()
    {
        Instantiate(muzzleFlash, BulletSpawn.position, BulletSpawn.rotation);


    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Pin")
        {
            isReady = true;
        }
    }
}
