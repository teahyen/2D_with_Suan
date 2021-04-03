using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    Queue<GameObject> moleList = new Queue<GameObject>();
    public GameObject mole = null;

    [SerializeField]
    private GameObject parent;  //���ӿ�����Ʈ�� Parent�ȿ� �ֱ�

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
            print("ť�� ����ֽ��ϴ�"); //����� �α׶� ����
            return null;
        }

        obj.transform.parent = transform.parent;
        obj.SetActive(true);
        return obj;
    }
}
