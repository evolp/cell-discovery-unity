using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_Seq_Segment : MonoBehaviour
{

    public GameObject connectedAbove, connectedBelow;

    // Start is called before the first frame update
    void Start()
    {
        connectedAbove = GetComponent<HingeJoint>().connectedBody.gameObject;
        DNA_Seq_Segment aboveSegment = connectedAbove.GetComponent<DNA_Seq_Segment>();

        if (aboveSegment != null )
        {
            aboveSegment.connectedBelow = gameObject;
            float assetBottom = connectedAbove.GetComponent<MeshRenderer>().bounds.size.y;
            GetComponent<HingeJoint>().connectedAnchor = new Vector3 (0, assetBottom * -1 /100,0);
        }
        else
        {
            GetComponent<HingeJoint>().connectedAnchor = new Vector3(0,0,0);
        }
        
    }


}
