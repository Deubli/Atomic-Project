using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electronScript : MonoBehaviour
{
    private atomScript atomScript;
    // Start is called before the first frame update
    void Awake()
    {
        atomScript = GameObject.Find("Atom").GetComponent<atomScript>();
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
