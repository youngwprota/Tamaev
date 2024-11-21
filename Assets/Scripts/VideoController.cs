using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; 

    void Start()
    {
        videoPlayer.Prepare(); 
        videoPlayer.loopPointReached += EndReached; 
    }

    public void PlayVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    public void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }

    private void EndReached(VideoPlayer vp)
    {
        Debug.Log("Видео закончилось");
    }
}
