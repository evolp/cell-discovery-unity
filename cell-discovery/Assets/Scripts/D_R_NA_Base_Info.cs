using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Info : MonoBehaviour
{
    public BaseType basetype;

    public bool destroyable;

    public Transform resetPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        transform.position = resetPosition.position;
        transform.rotation = resetPosition.rotation;
    }

    public void ChangePosition(Vector3 Position)
    {
        transform.position += Position;
    }

    public BaseType getBaseType()
    {
        return basetype;
    }

    //public string getCompDNABaseType()
    //{
    //    switch (basetype)
    //    {
    //        case BaseType.A:
    //            return "T";
    //        case BaseType.T:
    //            return "A";
    //        case BaseType.G:
    //            return "C";
    //        case BaseType.C:
    //            return "G";
    //    }
    //}

    //public string getCompRNABaseType()
    //{
    //    switch (basetype)
    //    {
    //        case BaseType.A:
    //            return "U";
    //        case BaseType.G:
    //            return "C";
    //        case BaseType.C:
    //            return "G";
    //        case BaseType.U:
    //            return "A";
    //    }
    //}
}

public enum BaseType
{
    A,
    T,
    G,
    C,
    U,
}