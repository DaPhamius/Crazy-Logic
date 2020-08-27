using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoPlayer : MonoBehaviour
{
    public VideoClip videoClip;
    private Camera cam;


    void Start()
    {
        cam = Camera.main;

        var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = this.gameObject.AddComponent<AudioSource>();

        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "0-10.mp4");

        
        videoPlayer.playOnAwake = true;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
        videoPlayer.source = UnityEngine.Video.VideoSource.VideoClip;
    }



}
