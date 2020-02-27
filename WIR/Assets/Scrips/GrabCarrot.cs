using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrabCarrot : MonoBehaviour
{
    public GameObject carrot;

    void OnMouseDown()
    {
        Destroy(carrot);
    }
}
