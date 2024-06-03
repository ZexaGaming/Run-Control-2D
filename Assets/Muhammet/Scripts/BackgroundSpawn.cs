using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject Background;
   bool spawmlandi = false;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && spawmlandi == false) 
        {
            Vector3 spawn_location = new Vector3(transform.position.x + 7.48f, 0, 0);
            Instantiate(Background, spawn_location, Quaternion.identity);
             spawmlandi=true;
            Destroy(this.gameObject,3f);
        }
    }
}
