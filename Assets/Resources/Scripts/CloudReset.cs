using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudReset : MonoBehaviour
{
    Vector3 originalC;
    // Start is called before the first frame update
    void Start()
    {
        originalC = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.localPosition = originalC;
    }
}