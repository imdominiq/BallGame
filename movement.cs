using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed = 0.5f;
    public float jumpForce = 10f;
    public Rigidbody rb;
    private int _maxJumps = 2;
    private int _currentJumps = 0;
    // Start is called before the first frame update
    void Start()
    {
       transform.position = new Vector3(0, 8, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        float cameraAngleY = Camera.main.transform.eulerAngles.y;

        Vector3 direction = new Vector3(inputX, y: 0, z: inputY);

        rb.velocity += Quaternion.Euler(x: 0, cameraAngleY, z: 0) * direction * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && _currentJumps < _maxJumps)
        {
            rb.velocity += Vector3.up * jumpForce;
            _currentJumps++;
        } }

        private void OnCollisionEnter(Collision collision)
    {
            if (collision.transform.CompareTag("Ground"))
            {
                _currentJumps = 0;
            }

            if (collision.transform.CompareTag("enemy"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
}

