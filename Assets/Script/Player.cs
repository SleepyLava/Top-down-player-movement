using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    Vector2 mousePos, nextPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RotateToMousePos();
        }
        MoveToMousePos();
    }

    void RotateToMousePos()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        nextPos = mousePos;
        Vector2 targetPos = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = targetPos;
    }

    void MoveToMousePos()
    {
        if ((Vector2)transform.position != nextPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
    }
}
