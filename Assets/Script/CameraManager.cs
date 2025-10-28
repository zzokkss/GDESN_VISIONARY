using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Camera mazeCam;
    [SerializeField] Camera remCam;
    [SerializeField] Camera lightCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        remCam.gameObject.SetActive(true);
        mazeCam.gameObject.SetActive(false);
        lightCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
