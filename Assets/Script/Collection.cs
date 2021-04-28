using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    public float score = 0;
    public float life = 15;

    [Header("UI")]
    public Slider SliderHeart = null;
    public Text textScore = null;
    
    [Header("ParticleSystem")]
    public ParticleSystem EffectScore = null;
    public ParticleSystem EffectBone = null;

    [Header("GameObject")]
    public GameObject GenerationObject = null;
    public GameObject ButtonRestart = null;

    [Header("Sound")]
    public AudioSource audioSource;
    public AudioClip ClipPickupFruit;
    public AudioClip ClipPickupBone;
    public AudioClip ClipDead;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fruit") {
            score++;
            EffectScore.Play();
            audioSource.clip = ClipPickupFruit;
            audioSource.Play();
        }
        else if(other.tag == "Bone"){
            score--;
            life--;
            EffectBone.Play();
            audioSource.clip = ClipPickupBone;
            
            if (life <= 0) {
                OnDie();
            }
            audioSource.Play();
        }
        Destroy(other.gameObject, 0.1f);
        SliderHeart.value = life;
        textScore.text = score.ToString();
    }

    public void Restart() {
        SceneManager.LoadScene(0);
    }

    void OnDie() {
        Destroy(GenerationObject);
        ButtonRestart.SetActive(true);
        audioSource.clip = ClipDead;
        GetComponent<CapsuleCollider2D>().enabled = false;
    }
}
