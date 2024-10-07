using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class ActivateCutScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Cutscene Activated");
           playableDirector.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
