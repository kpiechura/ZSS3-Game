using UnityEngine; 

public class MusicPlayer : MonoBehaviour 
{ 
   static AudioSource muzyka; 

   void Awake() 
   { 
      if(muzyka) 
      { 
          Destroy(gameObject); 
          return; 
      } 

      muzyka = audio; 
      DontDestroyOnLoad(gameObject); 
   } 

   void OnLevelWasLoaded(int level) 
   { 
      if(level == 4) 
         audio.Stop(); 
   } 
}