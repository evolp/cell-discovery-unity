using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_Seq_Dynamic : MonoBehaviour
{
    public GameObject hook;

    private GameObject last;

    // Start is called before the first frame update
    void Start()
    {
        last = hook; 
    }

    public void addBase(GameObject dnaBase)
    {
        GameObject newBase = Instantiate(dnaBase);
        newBase.transform.parent = transform;
        newBase.transform.position = transform.position;
        HingeJoint hj = newBase.GetComponent<HingeJoint>();
        hj.connectedBody = last.GetComponent<Rigidbody>();

        last = newBase;
    }
}
