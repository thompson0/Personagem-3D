using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class ActivateCutScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Cutscene Activated");
            playableDirector.Play();
            GetComponent<BoxCollider>().enabled=false;
        }
    }
}
