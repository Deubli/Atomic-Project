using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour
{
    public void Pause()
    {
        GameObject.Find("Atom(Clone)").GetComponent<atomScript>().Pause();
    }
}
