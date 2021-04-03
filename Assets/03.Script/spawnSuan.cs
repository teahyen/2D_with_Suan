using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSuan : MonoBehaviour
{

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
        GameObject obj = GameManager.Instance.pool.DequeueBeat();   //PoolManager에서 불러오기!
        if (RandomPos == 1)
            obj.transform.position = new Vector2(-6,3); //PoolManager에서 불러온것의 위치 조정
        else if (RandomPos == 2)               
            obj.transform.position = new Vector2(0, 3);
        else if (RandomPos == 3)               
            obj.transform.position = new Vector2(6, 3);
        else if (RandomPos == 4)               
            obj.transform.position = new Vector2(-6,0);
        else if (RandomPos == 5)                    
            obj.transform.position = new Vector2(0, 0);
        else if (RandomPos == 6)                    
            obj.transform.position = new Vector2(6, 0);
        else if (RandomPos == 7)               
            obj.transform.position = new Vector2(-6,-3);
        else if (RandomPos == 8)                    
            obj.transform.position = new Vector2(0, -3);
        else if (RandomPos == 9)                    
            obj.transform.position = new Vector2(-6,-3);
        obj.transform.rotation = transform.rotation;
        yield return new WaitForSeconds(RandomTime);

    }
}
