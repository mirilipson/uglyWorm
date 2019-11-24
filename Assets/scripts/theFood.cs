using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theFood : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wormHead"))
        {
            other.GetComponent<wormMove>().AddTail();
            Destroy(gameObject);
        }
    }
}
