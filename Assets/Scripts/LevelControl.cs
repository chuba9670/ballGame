using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene(1);
            SceneManager.LoadScene(levelName);
        }
    }

    // Update is called once per frame

}
