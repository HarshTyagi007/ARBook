using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeroReset : MonoBehaviour
{
    Vector3 original;
    // Start is called before the first frame update
    void Start()
    {
        original = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.localPosition = original; 
    }
}
