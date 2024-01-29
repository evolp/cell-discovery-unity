using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SetText : MonoBehaviour
{

    public TMP_Text textpro;

    public Transform target;

    public string text;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mainObject = GameObject.Find("Tooltip");

        VerticalBilboard lineb = mainObject.GetComponentInChildren<VerticalBilboard>();

        lineb.set_target(target);

        textpro.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
