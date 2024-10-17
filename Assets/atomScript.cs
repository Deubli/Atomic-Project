using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class atomScript : MonoBehaviour
{
    private Vector3 origin;
    public int electronAmnt;
    [SerializeField] private GameObject electron;
    public GameObject[] electrons = new GameObject[16];
    [SerializeField] public GradientAlphaKey alpha = new GradientAlphaKey(1.0f, 0.0f);
    private object electronCloud;
    private TMP_Text chargeText;
    private TMP_Text electronText;
    private TMP_Text ionText;
    private TMP_Text nameText;
    private TMP_Text ionNameText;
    private int charge;
    public string chargeTypeText;
    [SerializeField] private bool Sulfide;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnElectrons");
       chargeText = GameObject.Find("Charge").GetComponent<TMP_Text>();
       electronText = GameObject.Find("ElectronAmount").GetComponent<TMP_Text>();
       ionText = GameObject.Find("IonType").GetComponent<TMP_Text>();
       nameText = GameObject.Find("Name").GetComponent<TMP_Text>(); 
       ionNameText = GameObject.Find("ionNameText").GetComponent<TMP_Text>();
       electronAmnt = 16;
    }
    void Update()
    {
        charge = 16 - electronAmnt;
        electronText.text = ("Electrons: " + electronAmnt);
        chargeText.text = ("Charge: " + charge.ToString());
        if(electronAmnt == 18)
        {
            Sulfide = true;
            ionText.text = "Anion";
        }
        else
        {
            Sulfide = false;
            ionText.text = "Neutral Atom";
        }
        print(Sulfide);
    }
    IEnumerator SpawnElectrons()
    {
        yield return new WaitForSeconds(2);
        for(int i = 0; i < electronAmnt; i++)
        {
            int randomNumber;
            Vector3 pos= new Vector3(Random.value- 0.5f, Random.value-0.5f, 0).normalized * Random.Range(4f,5.5f);
            Instantiate(electron, new Vector3(pos.x, pos.y, transform.position.z), Quaternion.identity);
        }
        StartCoroutine("SpawnElectrons");
    }
    public void AddElectron()
    {
        if(Sulfide == true)
        {
            electronAmnt = 16;
            nameText.text = "Sulfur";
            ionNameText.text = "Sulfide";
            return;
        }
        else if(Sulfide == false);
        {
            electronAmnt = 18;
            nameText.text = "Sulfide";
            ionNameText.text = "Sulfur";
            return;
        }
    }

}
