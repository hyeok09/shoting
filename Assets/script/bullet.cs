using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wall")
        {
            Destroy(gameObject);
        }
    }

    void Shot()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
