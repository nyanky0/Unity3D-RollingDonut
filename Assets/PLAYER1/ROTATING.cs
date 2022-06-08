using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATING : MonoBehaviour {

    private void Start()
    {
        RotateRight();
    }
    void RotateRight()
    {
        transform.Rotate(Vector3.forward * -90);
    }
}
