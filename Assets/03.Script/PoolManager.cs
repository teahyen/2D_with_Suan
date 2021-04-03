using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    Queue<GameObject> moleList = new Queue<GameObject>();
    public GameObject mole = null;

    [SerializeField]
    private GameObject parent;  //게임오브젝트를 Parent안에 넣기

    public void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject _mole = Instantiate(mole, transform);
            EnqueueMole(_mole);
        }
    }

    public void EnqueueMole(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.parent = parent.transform;
        moleList.Enqueue(obj);
    }

    public GameObject DequeueBeat()
    {
        GameObject obj = moleList.Dequeue();

        if (obj == null)
        {
            print("큐가 비어있습니다"); //디버그 로그랑 유사
            return null;
        }

        obj.transform.parent = transform.parent;
        obj.SetActive(true);
        return obj;
    }
}
