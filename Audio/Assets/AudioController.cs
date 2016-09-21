using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class AudioController : MonoBehaviour
{

    public AudioMixerSnapshot normal;
    public AudioMixerSnapshot underwater;

    private bool isNormal = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isNormal)
            {
                underwater.TransitionTo(.2f);
                isNormal = false;
            }
            else
            {
                normal.TransitionTo(.2f);
                isNormal = true;
            }
        }
    }
}
