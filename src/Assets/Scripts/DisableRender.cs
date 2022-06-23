using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRender : MonoBehaviour
{
    private GameObject lvl1;
    private GameObject lvl2;
    private GameObject lvl3;
    private GameObject lvl4;

    // Start is called before the first frame update
    void Start()
    {
        lvl1 = GameObject.Find("Level 1");
        lvl2 = GameObject.Find("Level 2");
        lvl3 = GameObject.Find("Level 3");
        lvl4 = GameObject.Find("Level 4");


        lvl2.SetActive(false);
        lvl3.SetActive(false);
        lvl4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoringSystem.theScore == 2 && lvl2.active == false){
            lvl2.SetActive(true);
            GameObject.Find("Music Level 1").active = false;
        }
            
        if(ScoringSystem.theScore == 5 && lvl3.active == false){
            lvl3.SetActive(true);
            lvl1.SetActive(false);
            GameObject.Find("Music Level 2").active = false;
        }

        if(ScoringSystem.theScore == 9 && lvl2.active == true){
            lvl2.SetActive(false);
            lvl4.SetActive(true);
            GameObject.Find("Music Level 3").active = false;
        }
            
        if(Input.GetKeyDown("l")){
            lvl1.SetActive(true);
            lvl2.SetActive(true);
            lvl3.SetActive(true);
            lvl4.SetActive(true);
            GameObject.Find("Music Level 1").active = false;
            GameObject.Find("Music Level 2").active = false;
            GameObject.Find("Music Level 3").active = false;
        }

        if(Input.GetKeyDown("p")){
            // List<Animation> anims = new List<Animation>();
            // if(!animsAreStopped){
                
            //     foreach (Animation go in Resources.FindObjectsOfTypeAll(typeof(Animation)) as Animation[])
            //     {
            //         go.Stop();
            //     }
            //     animsAreStopped = true;
            // }
            // else{
            //     foreach (Animation go in Resources.FindObjectsOfTypeAll(typeof(Animation)) as Animation[])
            //     {
            //         go.Play();
            //     }
            //     animsAreStopped = false;
            // }

            var allAnims = FindObjectsOfType<Animation>();
            foreach( var anim in allAnims ) 
            {
                anim.Stop();
            }
                    
        }
    }
}
