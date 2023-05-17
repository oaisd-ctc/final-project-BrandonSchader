using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicSelector : MonoBehaviour
{

    public AudioSource Track1;
    public AudioSource Track2;
    public AudioSource Track3;
    public AudioSource Track4;
    public AudioSource Track5;

    private int TrackSelector;
    private int TrackHistory;
    // Start is called before the first frame update
    void Start()
    {
        TrackSelector = Random.Range(0, 5);

        if (TrackSelector == 0)
        {
            Track1.Play();
            TrackHistory = 1;
        } 
        else if (TrackSelector == 1)
        {
            Track2.Play();
            TrackHistory = 2;
        }
        else if (TrackSelector == 2)
        {
            Track3.Play();
            TrackHistory = 3;
        }
        else if (TrackSelector == 3)
        {
            Track4.Play();
            TrackHistory = 4;
        }
        else if (TrackSelector == 4)
        {
            Track5.Play();
            TrackHistory = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Track1.isPlaying == false && Track2.isPlaying == false && Track3.isPlaying == false && Track4.isPlaying == false && Track5.isPlaying == false)
        {
            TrackSelector = Random.Range(0, 5);

            if (TrackSelector == 0 && TrackHistory != 1)
            {
                Track1.Play();
                TrackHistory = 1;
            }
            else if (TrackSelector == 1 && TrackHistory != 2)
            {
                Track2.Play();
                TrackHistory = 2;
            }
            else if (TrackSelector == 2 && TrackHistory != 3)
            {
                Track3.Play();
                TrackHistory = 3;
            }
            else if (TrackSelector == 3 && TrackHistory != 4)
            {
                Track4.Play();
                TrackHistory = 4;
            }
            else if (TrackSelector == 4 && TrackHistory != 5)
            {
                Track5.Play();
                TrackHistory = 5;
            }
        }
    }
}
