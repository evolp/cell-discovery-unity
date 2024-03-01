using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseCompare : MonoBehaviour
{
    


    public GameObject RNARoot;

    public GameObject adenosineHover;
    public GameObject uridineHover;
    public GameObject guanosineHover;
    public GameObject cytosineHover;
    public GameObject thymineHover;
    public GameObject hoverBasePos;
    private GameObject hoverBase;

    public GameObject adenosine;
    public GameObject uridine;
    public GameObject guanosine;
    public GameObject cytosine;
    private GameObject rnaBase;


    //private GameObject 
    // Start is called before the first frame update
    void Start()
    {
        adenosineHover.SetActive(false);
        uridineHover.SetActive(false);
        guanosineHover.SetActive(false);
        cytosineHover.SetActive(false);
        thymineHover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        bool notIgnored = other.GetComponent<Base_Info>().destroyable;
        Base_Info baseInfo = other.GetComponent<Base_Info>();

        if (notIgnored == false)
        {
            string baseName = baseInfo.getBaseType().ToString();
            
            switch (baseName)
            {
                case "A":
                    //hoverBase = Instantiate(adenosineHover);
                    adenosineHover.SetActive(true);
                    rnaBase = adenosine;
                    break;
                case "U":
                    //hoverBase = Instantiate(uridineHover);
                    uridineHover.SetActive(true);
                    rnaBase = uridine;
                    break;
                case "G":
                    //hoverBase = Instantiate(guanosineHover);
                    guanosineHover.SetActive(true);
                    rnaBase = guanosine;
                    break;
                case "C":
                    //hoverBase = Instantiate(cytosineHover);
                    cytosineHover.SetActive(true);
                    rnaBase = cytosine;
                    break;
                case "T":
                    //hoverBase = Instantiate(cytosineHover);
                    thymineHover.SetActive(true);

                    break;
            }
            //hoverBase.transform.position = hoverBasePos.transform.position;
            //hoverBase.transform.rotation = new Quaternion(180, 90, 90, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        string baseType = rnaBase.GetComponent<Base_Info>().getBaseType().ToString();
        switch (baseType)
        {
            case "A":
                RNARoot.GetComponent<RNA_polymerase_script>().compareComplement(baseType, adenosine);
                break;
            case "U":
                RNARoot.GetComponent<RNA_polymerase_script>().compareComplement(baseType, uridine);
                break;
            case "G":
                RNARoot.GetComponent<RNA_polymerase_script>().compareComplement(baseType, guanosine);
                break;
            case "C":
                RNARoot.GetComponent<RNA_polymerase_script>().compareComplement(baseType, cytosine);
                break;
        }

        adenosineHover.SetActive(false);
        uridineHover.SetActive(false);
        guanosineHover.SetActive(false);
        cytosineHover.SetActive(false);
        thymineHover.SetActive(false);

        Destroy(hoverBase);
    }

}
