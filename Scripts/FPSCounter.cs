using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{

    public float updateInterval = 0.2f; //How often should the number update

    TMP_Text txt;
    float time = 0.0f;
    int frames = 0;

    void Start()
    {
        txt = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.unscaledDeltaTime;
        ++frames;

        // Interval ended - update GUI text and start new interval
        if (time >= updateInterval)
        {
            float fps = (int)(frames / time);
            time = 0.0f;
            frames = 0;

            txt.text = fps.ToString();
        }
    }
}

