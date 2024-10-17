using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isotopeScript : MonoBehaviour
{
    public GameObject[] isotopes;
    
    public void MostAbundant()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[0], new Vector3(0,0,0), Quaternion.identity);
    }
    public void SecondMost()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[1], new Vector3(0,0,0), Quaternion.identity);
    }
    public void ThirdMost()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[2], new Vector3(0,0,0), Quaternion.identity);
    }
}
