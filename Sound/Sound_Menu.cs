using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum soundsGame
{
    menu,
    menuInGame,
    go,
    click,
    ratGone,
    gameOver,
    heart3_Done,
    heart2_Done,
    heart1_Done,
    heart3,
    heart2,
    hit,
    finish,
    heart1,
    changeScene,
    changeScene2,
    attack
    
}

public class Sound_Menu : MonoBehaviour
{



    public AudioClip soundMenu;
    public AudioClip soundMenuInGame;
    public AudioClip soundGo1;

    public AudioClip soundClick;
    public AudioClip soundratGone;
    public AudioClip soundgameOver;
    public AudioClip soundheart3_Done;
    public AudioClip soundheart2_Done;
    public AudioClip soundheart1_Done;
    public AudioClip soundheart3;
    public AudioClip soundheart2;
    public AudioClip soundHit;
    public AudioClip soundFinish;
    public AudioClip soundheart1;
    public AudioClip soundchangeScene;
    public AudioClip soundchangeScene2;
    public AudioClip soundAttack;


    public static Sound_Menu instance;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }
    public static void PlaySound(soundsGame currentSound)
    {
        switch (currentSound)
        {

            case soundsGame.menu:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundMenu);
                }
                break;
            case soundsGame.menuInGame:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundMenuInGame);
                }
                break;
            case soundsGame.go:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundGo1);
                }
                break;

            case soundsGame.click:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundClick);
                }
                break;
            case soundsGame.ratGone:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundratGone);
                }
                break;
            case soundsGame.gameOver:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundgameOver);
                }
                break;
            case soundsGame.heart3_Done:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart3_Done);
                }
                break;
            case soundsGame.heart2_Done:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart2_Done);
                }
                break;
            case soundsGame.heart1_Done:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart1_Done);
                }
                break;
            case soundsGame.heart3:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart3);
                }
                break;
            case soundsGame.heart2:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart2);
                }
                break;
            case soundsGame.hit:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundHit);
                }
                break;
            case soundsGame.finish:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundFinish);
                }
                break;
            case soundsGame.heart1:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundheart1);
                }
                break;

            case soundsGame.changeScene:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundchangeScene);
                }
                break;

            case soundsGame.changeScene2:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundchangeScene2);
                }
                break;
            case soundsGame.attack:
                {
                    instance.GetComponent<AudioSource>().PlayOneShot(instance.soundAttack);
                }
                break;

                
            

           
        }
    }
    public void PlaySoundHit()
    { 
        PlaySound(soundsGame.go);
    }

    // Update is called once per frame
    void Update()
    {

    }

}



