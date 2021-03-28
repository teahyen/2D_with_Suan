using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int a;
    public void teat()
    {
        a = Random.Range(1, 20); //1부터 19까지 출력
        Debug.Log(a);
    }
}
