using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 35, 45) * Time.deltaTime); // public void Rotate(Vector3 eulerAngles, Space relativeTo = Space.Self);
    } // vector multiplied by Time.deltaTime to make it smooth and frame-rate independent
}
