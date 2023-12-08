using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // This method is called once, at the start of the script execution.
        // You can initialize variables or perform actions needed at the beginning here.
    }

    // Update is called once per frame
    void Update()
    {
        // This method is called once per frame.
        // You can put continuous actions that need to happen every frame here.
    }

    // This method is called when a button that uses this script is clicked.
    public void OnClickButton()
    {
        // This line loads the scene named "SampleScene" when the button is clicked.
        SceneManager.LoadScene("SampleScene");
    }
}
