using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform followTarget;

    void Start()
    {
        followTarget = GameObject.Find("Player_01").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = followTarget.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}
