using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public float damage;
    public float range;

    public Camera Gun_Cam;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(Gun_Cam.transform.position, Gun_Cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.name);

            Bot_Health target = hitInfo.transform.GetComponent<Bot_Health>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
