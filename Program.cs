using Human;
using UnityEngine;
using Human.Eyes;

public class Alex_Sour : MonoBehaviour
{
    public UnityGame pylonPixel;
    public UnityGame pylonPixel2;
    
    void Update()
    {
        if(Random.Range(0, 2) == 0)
        {
            WorkOnUnityGame(pylonPixel2);
        }
        else
        {
            Eyes.WatchWebURL("https://youtube.com/");
        }
    }
}
