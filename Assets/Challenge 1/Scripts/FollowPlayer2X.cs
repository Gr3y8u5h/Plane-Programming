using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2X : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0.0f, 9.0f, -30.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = plane.transform.position + offset;
        
    }
}
