using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{

    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = playerName;
    }

}
