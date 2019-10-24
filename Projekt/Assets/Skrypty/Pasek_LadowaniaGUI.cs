using UnityEngine; 
using System.Collections; 

public class Pasek_LadowaniaGUI : MonoBehaviour 
{ 

    
	
	public Texture teksturaTla;

    void OnGUI() 
    { 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height) , teksturaTla);
		
		
		
        
		
		
    } 
}