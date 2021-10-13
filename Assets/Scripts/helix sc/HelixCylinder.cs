using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixCylinder : MonoBehaviour
{
    private GameObject Helix;
     void Awake()
    {
        Helix = GameObject.Find("Helix");
    }
     void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, Helix.gameObject.transform.eulerAngles.z % 25);
    }
}

