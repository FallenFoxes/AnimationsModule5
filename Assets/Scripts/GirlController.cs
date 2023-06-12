using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    private Animator anim;
    private bool accept_input = true;

    public AnimationClip faceBlockAnimClip;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();

        if (faceBlockAnimClip != null)
        {
            AnimationEvent faceBlockDoneEvent = new AnimationEvent();
            faceBlockDoneEvent.time = faceBlockAnimClip.length;
            faceBlockDoneEvent.functionName = "OnInputBlockingAnimationDone";
            faceBlockAnimClip.AddEvent(faceBlockDoneEvent);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (accept_input){
            HandleInput();
        }
    }

    private void OnInputBlockingAnimationDone() {
        accept_input = true;
    }

        private void HandleInput()
    {
        if(Input.GetKey(KeyCode.V)){
            anim.SetTrigger("FaceBlock");
            accept_input = false;
        }
        if(Input.GetKey(KeyCode.F)) {
            anim.SetTrigger("Kick");
            accept_input = false;
        }
        if(Input.GetKey(KeyCode.G)) {
            anim.SetTrigger("RightHookPunch");
            accept_input = false;
        }
    }
}
