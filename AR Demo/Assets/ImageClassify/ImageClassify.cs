using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClassify : MonoBehaviour
{
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        GetComponent<RawImage>().texture = webcamTexture;
        webcamTexture.Play();
    }
}
