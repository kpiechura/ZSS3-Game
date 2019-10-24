using UnityEngine; 

public class Zablokowanie_Sterowania : MonoBehaviour 
{ 
    public MonoBehaviour[] player; 
    
    void OnTriggerEnter(Collider enter) 
    { 
        if(enter.tag == "Pytanie") 
        { 
            for(int i = 0; i < player.Length; ++i) 
                if(player[i]) 
                    player[i].enabled = false; 
        } 
    } 
    
    void WakeUp() 
    { 
        for(int i = 0; i < player.Length; ++i) 
        { 
            if(player[i]) 
                player[i].enabled = true; 
        } 
    } 
    
}
