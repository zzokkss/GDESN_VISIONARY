using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    VideoPlayer videoPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();
    }
}
