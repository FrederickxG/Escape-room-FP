using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTele : MonoBehaviour
{
    public GameObject gem;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == gem)
        {
            // Collect the Gem
            gem.SetActive(false);

            SceneManager.LoadScene("Winner");
        }
    }
}
