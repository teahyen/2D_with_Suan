using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryTest : MonoBehaviour
{
    public GameObject aaa;
    void Start()
    {
        //Destroy(gameObject,3f);
        aaa.Instantiate(transform.position,transform.forward)
    }

    void Update()
    {
        
    }
}
