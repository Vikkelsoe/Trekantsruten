using UnityEngine;

public class AnimationLibrary : MonoBehaviour
{

    [Header("Boyancy Control Variable")]
    //public GameObject floatingObj;
    public float amount;
    public float time;

    public Vector3 startRotation;
    public Vector3 rotationVector;
    public float rotationTime;
    public float delayValueMin;
    public float delayValueMax;


    public void BoyancyControl()
    {
        float delayValue = Random.Range(delayValueMin, delayValueMax);
        Vector2 startPos = this.transform.position;
        LeanTween.move(this.gameObject, new Vector2(startPos.x, startPos.y + amount), time).setEaseInOutQuad().setLoopPingPong().setDelay(delayValue);
        LeanTween.rotate(this.gameObject, rotationVector, rotationTime).setFrom(startRotation).setEaseInOutQuad().setLoopPingPong();
    }

    private void Start()
    {

        BoyancyControl();

        float xPos = Mathf.Sin(Time.time);
    }

    private void Update()
    {
        
    }


}
