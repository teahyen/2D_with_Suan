using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepSuan : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
     public void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target = gameObject)
            {
                GameManager.Instance.pool.EnqueueMole(this.gameObject);
                GameManager.Instance.score++;
            }
        }
    }
    void CastRay()
    {
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            target = hit.collider.gameObject;
        }   
    }
}
