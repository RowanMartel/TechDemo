using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0), Time.deltaTime * 15, Space.World);
    }
}