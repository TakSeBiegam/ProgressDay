using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBackgroundLight : MonoBehaviour
{
    private float rotateSpeed = 0.02f;
    private float acutalTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (acutalTime > rotateSpeed)
        {
            acutalTime = 0;
            transform.Rotate(0, 0, 1);
        }
        else
        {
            acutalTime += Time.deltaTime;
        }
    }
}
