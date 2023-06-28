using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float steerSpeed = 109f;
    [SerializeField] float boostSpeed = 25f;
    private float curSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        curSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * curSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Speed")
        {
            curSpeed = boostSpeed;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Speed")
        {
            curSpeed = moveSpeed;
        }
    }
}
