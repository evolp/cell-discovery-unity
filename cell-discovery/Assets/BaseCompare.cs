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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Base_Info baseInfo = other.GetComponent<Base_Info>();

        if (baseInfo != null)
        {
            string baseName = baseInfo.getBaseType().ToString();
            
            switch (baseName)
            {
                case "A":
                    hoverBase = Instantiate(adenosineHover);
                    rnaBase = adenosine;
                    break;
                case "U":
                    hoverBase = Instantiate(uridineHover);
                    rnaBase = uridine;
                    break;
                case "G":
                    hoverBase = Instantiate(guanosineHover);
                    rnaBase = guanosine;
                    break;
                case "C":
                    hoverBase = Instantiate(cytosineHover);
                    rnaBase = cytosine;
                    break;
            }
            hoverBase.transform.position = hoverBasePos.transform.position;
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
        
        Destroy(hoverBase);
    }

}
