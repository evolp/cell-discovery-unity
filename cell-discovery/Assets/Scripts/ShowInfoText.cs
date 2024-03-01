using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.XR.CoreUtils;

public class ShowInfoText : MonoBehaviour
{

    public GameObject menu;

    public TMP_Text testobj;

    public string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Set the info text
    public void SetText() 
    {
        testobj.text = text;
        menu.SetActive(true);
    }

    public void Deactivate() {
        menu.SetActive(false);
    }

}
