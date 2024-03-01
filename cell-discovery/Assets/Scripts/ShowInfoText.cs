using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.XR.CoreUtils;

public class ShowInfoText : MonoBehaviour
{

    public GameObject menu;

    public string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText() {
        //TMP_Text testobj = menu.Find("TMP_Text");
        //Assets\Scripts\ShowInfoText.cs(27,28): error CS0176: Member 'GameObject.Find(string)' cannot be accessed with an instance reference; qualify it with a type name instead


        //testobj.text = text;
        menu.SetActive(true);
    }

    public void Deactivate() {
        menu.SetActive(false);
    }

}
