using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 speedMove = new Vector3(0.2f,0,0);
    public float distanceLimit = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
            RightMove();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftMove();
        }
    }

    public void RightMove() {
        transform.position = transform.position + speedMove;
        if (transform.position.x > distanceLimit)
        {
            transform.position = new Vector3(distanceLimit, -4, 0);
        }
    }

    public void LeftMove() {
        transform.position = transform.position - speedMove;
        if (transform.position.x < (-distanceLimit))
        {
            transform.position = new Vector3(-distanceLimit, -4, 0);
        }
    }

}
