using Human;
using UnityEngine;
using Human.Eyes;
using Human.Memory;

public class Alex_Sour : MonoBehaviour
{
    public ShortTermMemory shortTermMemory;
    public LongTermMemory longTermMemory;
    public UnityGame pylonPixel;
    public UnityGame pylonPixel2;
    public Eye[] eyes;
    private bool isSleeping = false;
    public GameObject monitor;
    public ChromiumWebBrowser browser;

    void Update()
    {
        TimeSpan start = new TimeSpan(10, 0, 0); //10 AM
        TimeSpan end = new TimeSpan(23, 0, 0); // 11 PM
        TimeSpan now = DateTime.Now.TimeOfDay;

        isSleeping = (now > start) && (now < end); // If the current time is between 10 AM and 11 PM, I am awake.

        foreach (Eye eye in eyes)
        {
            eye.isOpen = !isSleeping;
        }

        if (!isSleeping)
        {
            if (Random.Range(0, 2) == 0) // 50% chance of working on Pylon Pixel 2
            {
                WorkOnUnityGame(pylonPixel2);
            }
            else // 50% chance of watching YouTube
            {
                browser.webURL = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

                foreach (Eye eye in eyes)
                {
                    eye.LookAt(monitor.transform);
                }
            }
        }
        else
        {
            Dream dream = new Dream();

            if (Random.Range(0, 50) == 0) // I almost always forget my dreams :(
            {
                shortTermMemory.Add(dream);
            }
        }
    }
}
