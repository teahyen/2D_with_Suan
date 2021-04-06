using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    /*
     1   2   3
     4   5   6
     7   8   9
     */
    private void Start()
    {
        StartCoroutine("TestTime");
    }
    IEnumerator TestTime()
    {
        while(true) //매 프레임마다 실행
        {
            GameManager.Instance.a = Random.Range(1, 20); //1부터 19까지 출력

            //3초동안 랜덤숫자 실행됨
            yield return new WaitForSeconds(GameManager.Instance.a); //3초 기다림
            Debug.Log(GameManager.Instance.a);
        }
    }
    public void teat()
    {
        
    }
}
