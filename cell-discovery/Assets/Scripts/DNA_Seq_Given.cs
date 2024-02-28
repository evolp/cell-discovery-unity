using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_Seq_Given : MonoBehaviour
{

    public Rigidbody start;

    public GameObject adenosine;
    public GameObject thyomsine;
    public GameObject guanosine;
    public GameObject cytosine;
    
    public string sequence;

    private GameObject newSeg;
    // Start is called before the first frame update
    void Start()
    {
        GenerateSequence();
    }


    void GenerateSequence()
    {
        Rigidbody prevBod = start;
        //GameObject newSeg;

        foreach (char Base in sequence)
        {
            
            
            switch (Base)
            {
                case 'A':
                    newSeg = Instantiate(adenosine);
                    break;               
                case 'T':
                    newSeg = Instantiate(thyomsine);
                    break;     
                case 'G':
                    newSeg = Instantiate(guanosine);
                    break;     
                case 'C':
                    newSeg = Instantiate(cytosine);
                    break;
            }

            newSeg.transform.parent = transform;
            newSeg.transform.position = transform.position;
            HingeJoint hj = newSeg.GetComponent<HingeJoint>();
            hj.connectedBody = prevBod;

            prevBod = newSeg.GetComponent<Rigidbody>();
        }
    }
}
