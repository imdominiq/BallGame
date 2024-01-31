using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    
        private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
            {
                other.GetComponent<PointSystem>()?.AddPoint();
                Destroy(gameObject);
            }
    }
}
