using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yes : MonoBehaviour
{
    public void id()
    {
        switch (this.gameObject.name)
        {
            case "resume":
                SceneManager.LoadScene("Menu");
                break;

                        
               
        }
    }
}
