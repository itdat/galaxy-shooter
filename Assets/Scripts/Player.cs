using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;
    [SerializeField] private float topBound = 6.0f;
    [SerializeField] private float bottomBound = -4.0f;
    [SerializeField] private float leftBound = -11.0f;
    [SerializeField] private float rightBound = 11.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * (speed * Time.deltaTime));

        var position = transform.position;
        position = new Vector3(position.x, Mathf.Clamp(position.y, bottomBound, topBound), 0);
        transform.position = position;

        if (position.x >= rightBound)
        {
            transform.position = new Vector3(leftBound, position.y, 0);
        } else if (position.x <= leftBound)
        {
            transform.position = new Vector3(rightBound, position.y, 0);
        }
    }
}
