using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            myAnimationController.SetBool("inObject", true);
            //other.GetComponent<Animation>().Play();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            myAnimationController.SetBool("inObject", false);
        }
    }
}


