using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class RNA_polymerase_script : MonoBehaviour
{

    public GameObject RNASeq;

    public GameObject adenosine;
    public GameObject uridine;
    public GameObject guanosine;
    public GameObject cytosine;

    public GameObject[] prefabDNA_Segs;

    public Transform newBaseSpawn;
    public Transform actualBasePos;

    private string actualBaseType;
    private GameObject newBase;

    // Start is called before the first frame update
    void Start()
    {
        addNewBase();
        setCompActualBase(newBase);
        addNewBase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addNewBase()
    {
        int index = UnityEngine.Random.Range(0, prefabDNA_Segs.Length);
        newBase = Instantiate(prefabDNA_Segs[index]);
        newBase.transform.parent = transform;
        newBase.transform.position = newBaseSpawn.position;
        newBase.transform.rotation = new Quaternion(0, 0, 90, 0);
    }

    public void setCompActualBase(GameObject actualBase)
    {
        actualBase.transform.parent = transform;
        actualBase.transform.position = actualBasePos.position;
        actualBase.transform.rotation = new Quaternion(0, 0, 90, 0);

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
            RNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(newRNABAase.GameObject());

            setCompActualBase(newBase);
            addNewBase();

            //switch (baseType)
            //{
            //    case "A":
            //        RNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(adenosine);
            //        break;
            //    case "G":
            //        RNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(guanosine);
            //        break;
            //    case "C":
            //        RNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(cytosine);
            //        break;
            //    case "U":
            //        RNASeq.GetComponent<DNA_Seq_Dynamic>().addBase(uridine);
            //        break;

            //}
        }

    }
}
