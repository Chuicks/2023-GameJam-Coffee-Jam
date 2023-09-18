using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float deadZone;
    private void Update()
    {
        if(transform.position.y > deadZone)
        {
            Destroy(gameObject);
        }
    }
    //public GameObject hitEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Instead of playing game effect we play a sound for hits
        //GameObject effect = Instantiate(hitEffect,transform.position, Quaternion.identity);

        Destroy(gameObject);
    }

    

    
}


