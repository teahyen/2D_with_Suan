using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSuan : MonoBehaviour
{
    [SerializeField]
    private GameObject Suan;

    private int RandomPos;
    private int RandomTime;

    void Start()
    {
        StartCoroutine("spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawn()
    {
        RandomTime = Random.Range(1, 5);
        RandomPos = (int)Random.Range(1,10);     //(int) 는 float, long등 을 int 값으로 바꿔준다. 반대로도 가능;
        yield return new WaitForSeconds(RandomTime);
        if(RandomPos == 1)
            Instantiate(Suan, new Vector3(-6,3,0), transform.rotation);
        else if (RandomPos == 2)
            Instantiate(Suan, new Vector3(0, 3, 0), transform.rotation);
        else if (RandomPos == 3)
            Instantiate(Suan, new Vector3(6, 3, 0), transform.rotation);
        else if (RandomPos == 4)
            Instantiate(Suan, new Vector3(-6, 0, 0), transform.rotation);
        else if (RandomPos == 5)
            Instantiate(Suan, new Vector3(0, 0, 0), transform.rotation);
        else if (RandomPos == 6)
            Instantiate(Suan, new Vector3(6, 0, 0), transform.rotation);
        else if (RandomPos == 7)
            Instantiate(Suan, new Vector3(-6, -3, 0), transform.rotation);
        else if (RandomPos == 8)
            Instantiate(Suan, new Vector3(0, -3, 0), transform.rotation);
        else if (RandomPos == 9)
            Instantiate(Suan, new Vector3(6, -3, 0), transform.rotation);

    }
}
