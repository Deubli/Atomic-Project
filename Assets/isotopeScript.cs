using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class isotopeScript : MonoBehaviour
{
    public GameObject[] isotopes;
    
    public void MostAbundant()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[0], new Vector3(0,0,0), Quaternion.identity);
        GameObject.Find("NeutronAmount").GetComponent<TMP_Text>().text = ("Neutrons: " + 16);
    }
    public void SecondMost()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[1], new Vector3(0,0,0), Quaternion.Euler(0, 0, -45));
        GameObject.Find("NeutronAmount").GetComponent<TMP_Text>().text = ("Neutrons: " + 18);        
    }
    public void ThirdMost()
    {
        Destroy(GameObject.Find("Atom(Clone)"));
        Instantiate(isotopes[2], new Vector3(0,0,0), Quaternion.Euler(0, 0, 45));
        GameObject.Find("NeutronAmount").GetComponent<TMP_Text>().text = ("Neutrons: " + 17);
    }
}
