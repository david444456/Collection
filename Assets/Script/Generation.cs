using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public GameObject[] collectionObject = new GameObject[5];
    public float positionX = 2.5f;
    public float timeToGeneration = 1.3f;
    public GameObject ButtonUIStart = null;

    private Vector3 positionToGeneration;
    private int valueGeneration = 0;

    public void ButtonStart() {
        GenerationCollection();
        ButtonUIStart.SetActive(false);
    }

    void GenerationCollection() {
        positionToGeneration = new Vector3(Random.Range(-positionX, positionX), transform.position.y, 0);
        valueGeneration = Random.Range(0, collectionObject.Length);
        Instantiate(collectionObject[valueGeneration], positionToGeneration, Quaternion.identity);
        Invoke("GenerationCollection", timeToGeneration);
    }


}
