using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimController : MonoBehaviour
{
    public Animator animator1; // for Animation1
    public Animator animator2; // for Animation2
    // Camera references
    public Camera cam1;
    public Camera cam2;
    public Camera mainCam;
    public Camera zoomCam;
    // UI references
    public TMPro.TMP_Text directions;
    public TMPro.TMP_Text flower;
    public TMPro.TMP_Text convo;
    public TMPro.TMP_Text pencilCase;
    // Audio references
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        // Default camera and UI
        ActivateCamera(mainCam);
        textActivate(directions);
    }

    // Update is called once per frame
    void Update()
    {
        // Input A -> Animation 1
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActivateCamera(cam1);
            animator1.SetTrigger("PlayA");
            Invoke("LoadScene", 15f); // reloads scene after animation is over
            textActivate(flower);
            
        }
        // Input B -> Animation 2
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator2.SetTrigger("PlayB");
            ActivateCamera(cam2);
            Invoke("LoadScene", 15f); // reloads scene after animation is over
            textActivate(pencilCase);
            source.PlayOneShot(clip, 1f); // sound effect for animation2
        }
        // Input scpace -> Animation 1&2 (in order)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateCamera(zoomCam);
            PlayAThenB();
            Invoke("LoadScene", 20f); // reloads scene after animation is over
            textActivate(convo);
        }
    }

    // Plays animations in order
    void PlayAThenB()
    {
        animator1.SetTrigger("PlayA");
        Invoke("triggerAnimB", 5f); // delay between animations
    }
    // Triggers Animation2
    void triggerAnimB()
    {
        animator2.SetTrigger("PlayB");
        source.PlayOneShot(clip, 1f);
    }

    // Activates selected camera
    void ActivateCamera(Camera camToActivate)
    {
        cam1.enabled = false;
        cam2.enabled = false;
        mainCam.enabled = false;
        zoomCam.enabled = false;

        camToActivate.enabled = true;
    }

    // Loads scene 
    void LoadScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Activates selected UI elements
    void textActivate(TMPro.TMP_Text textToActive)
    {
        directions.enabled = false;
        flower.enabled = false;
        convo.enabled = false;
        pencilCase.enabled = false;

        textToActive.enabled = true;
    }
   
}