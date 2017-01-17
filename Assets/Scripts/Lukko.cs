using UnityEngine;
using System.Collections;
//-------------------------------------------------------------------------

public class Lukko : MonoBehaviour
{
    public GameObject ovi; // Referenssi siltä varalta, ettei trigger ole animaation sisältävän objektin lapsi

    //-------------------------------------------------

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "avain")
        {
            Debug.Log("AVAIN OSUI");
            ovi.GetComponentInParent<Animator>().SetTrigger("Avain");
        }
    }
}
