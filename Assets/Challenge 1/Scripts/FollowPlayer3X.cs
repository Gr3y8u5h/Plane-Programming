using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer3X : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0.0f, 172.0f, -75.0f);

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
