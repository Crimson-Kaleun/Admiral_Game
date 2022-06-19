using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PirateGun : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator a;
    private Slider hp;
    private int lvl;
    public AudioClip gunSound;
    public AudioSource sndSrc; 
    void Start()
    {
        hp = GameObject.Find("HealthBar").GetComponent<Slider>();
        a=this.GetComponent<Animator>();
        
        float p = Random.Range(0f,1f);
        if (p < 0.7) lvl = 1;
        else if (p < 0.9) lvl = 2;
        else lvl = 3;

        if (lvl == 2) this.GetComponent<SpriteRenderer>().color = new Color(0.1f, 0.1f, 0.1f, 1f);
        else if (lvl == 3) this.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 0.1f, 1f);

        testAngle();
        sndSrc.volume = 0.3f;
        sndSrc.clip = gunSound;
        shoot();
    }

    void testAngle()
    {
        float g = Quaternion.Angle(transform.rotation, Quaternion.Euler(0f, 0f, 0f));
        if (g>33f && g<60f && transform.position.x < 130) a.SetBool("Dir", true);
        else a.SetBool("Dir", false);
        Invoke("testAngle", 1f);
    }

    void shoot()
    {
        if (a.GetBool("Open") && a.GetBool("Dir")) 
        {   hp.value -= (0.7f + Random.Range(0.45f, 0.95f)) * lvl * Mathf.Pow(1.05f, PirateSpawner.hard); 
            sndSrc.Play();
        }
        Invoke("shoot", 0.3f + Random.Range(0.15f, 0.25f));
    }
}
