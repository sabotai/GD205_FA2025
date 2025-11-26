using UnityEngine;
using UnityEngine.SceneManagement; //we add the scenemanagement directive for addl functionality

public class UIStuff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is an example of a function call that returns a value
        //we are using it to send a message to the console
        Debug.Log(boolFunc());
    }


    //sample of a return function of type bool
    //it returns a boolean value where the function is called
    bool boolFunc()
    {
        return true;
    }

    //create a new public function to quit the game for desktop builds
    //we have to make it public if we want to access it outside of this script (i.e. through a button)
    public void QuitGame()
    {
        Application.Quit();
    }

    //create a new public void function to change the scene
    public void GoScene()
    { //we can use the loadscene function with either the scene index or title as a string
        SceneManager.LoadScene(0);
    }
}
