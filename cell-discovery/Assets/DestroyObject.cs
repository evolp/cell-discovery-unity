using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
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
        print(other.gameObject);
        print(other.GetComponent<Base_Info>().destroyable);
        if(other.GetComponent<Base_Info>().destroyable == true)
        {
            Destroy(other.gameObject);
        }
    }
}
