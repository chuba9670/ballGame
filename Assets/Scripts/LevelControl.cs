using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelControl : MonoBehaviour
{

    public int index;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene(index);
        }
    }

    // Update is called once per frame

}
