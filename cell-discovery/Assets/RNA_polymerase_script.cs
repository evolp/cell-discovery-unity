using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RNA_polymerase_script : MonoBehaviour
{

    public GameObject DNASeq;

    public GameObject adenosine;
    public GameObject uridine;
    public GameObject guanosine;
    public GameObject cytosine;

    public GameObject[] prefabDNA_Segs;

    public Transform newBaseSpawn;

    private string actualBaseType;

    // Start is called before the first frame update
    void Start()
    {
        int index = UnityEngine.Random.Range(0, prefabDNA_Segs.Length);
        GameObject newSeg = Instantiate(prefabDNA_Segs[index]);
        newSeg.transform.parent = transform;
        newSeg.transform.position = newBaseSpawn.position;
        //newSeg.transform.rotation = newBaseSpawn.rotation;

        this.setCompActualBase(newSeg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCompActualBase(GameObject actualBase)
    {
        Base_Info baseComp = actualBase.GetComponent<Base_Info>();
        string comp = baseComp.getBaseType().ToString();

        switch (comp)
        {
            case "A":
                actualBaseType = "U";
                break;
            case "G":
                actualBaseType = "C";
                break;
            case "C":
                actualBaseType = "G";
                break;
            case "U":
                actualBaseType = "A";
                break;

        }
    }

    public void compareComplement(string baseType, GameObject newRNABAase)
    {
        print(baseType);
        print(actualBaseType); print(newRNABAase);

        if (actualBaseType == baseType)
        {
            DNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(newRNABAase.GameObject());
        }

    }
}
