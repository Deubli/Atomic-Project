using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomScript : MonoBehaviour
{
    private Vector3 origin;
    [SerializeField] private int electronAmnt;
    [SerializeField] private GameObject electron;
    public GameObject[] electrons = new GameObject[16];
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("SpawnElectrons");
    }

    IEnumerator SpawnElectrons()
    {
        yield return new WaitForSeconds(2);
        print("test");
        for(int i = 0; i < electronAmnt; i++)
        {
            int randomNumber;
            Vector3 pos= new Vector3(Random.value- 0.5f, Random.value-0.5f, 0).normalized * Random.Range(4,10);
            Instantiate(electron, new Vector3(pos.x, pos.y, transform.position.z), Quaternion.identity);
        }
        StartCoroutine("SpawnElectrons");
    }
}
