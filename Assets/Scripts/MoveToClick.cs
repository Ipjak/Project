using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Vector3 mousePos, transPos, targetPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CalTargetPos();
        MoveToTarget();
    }

    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);
    }

    void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
    }
}
