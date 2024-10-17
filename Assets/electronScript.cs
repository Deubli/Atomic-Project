using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electronScript : MonoBehaviour
{
    public atomScript atomScript;
    // Start is called before the first frame update
    void Update()
    {
        atomScript = GameObject.Find("Atom(Clone)").GetComponent<atomScript>();
    }
    void Awake()
    {
        atomScript = GameObject.Find("Atom(Clone)").GetComponent<atomScript>();
        for(int i = 0; i < 16; i++)
        {
            if(atomScript.electrons[i] == null)
            {
                atomScript.electrons[i] = gameObject;
            }
        }
        StartCoroutine("DestroyObject");
    }
    

    IEnumerator DestroyObject() 
    {
        yield return new WaitForSeconds(1.99f);
        Destroy(gameObject);
    }
}
