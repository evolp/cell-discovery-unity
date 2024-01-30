using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_Seq : MonoBehaviour
{

    public Rigidbody start;
    public GameObject[] prefabDNA_Segs;
    public int numBases = 5;
    // Start is called before the first frame update
    void Start()
    {
        GenerateRope();
        
    }

    void GenerateRope()
    {
        Rigidbody prevBod = start;
        for (int i = 0; i < numBases; i++)
        {
            int index = UnityEngine.Random.Range(0, prefabDNA_Segs.Length);
            GameObject newSeg = Instantiate(prefabDNA_Segs[index]);
            newSeg.transform.parent = transform;
            newSeg.transform.position = transform.position;
            HingeJoint hj = newSeg.GetComponent<HingeJoint>();
            hj.connectedBody = prevBod;

            prevBod = newSeg.GetComponent<Rigidbody>();
        }
    }

}
