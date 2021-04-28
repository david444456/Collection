using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fruit" || other.tag == "Bone") {
            Destroy(other.gameObject);
        }
    }
}
