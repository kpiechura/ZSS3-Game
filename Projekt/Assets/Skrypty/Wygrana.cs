using UnityEngine; 
using System.Collections; 

public class Wygrana : MonoBehaviour 
{ 

    //Wymiary przyciskow 
    private int szerokoscPrzycisku = 300; 
    private int wysokoscPrzycisku = 40; 
	

	
	
	public Texture teksturaTla;

    void OnGUI() 
    { 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height) , teksturaTla);
		
		
		
        //przycisk Wyjscie
        if(GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 11), 
                            495,
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Wyjscie")) 
		{
			Application .LoadLevel("Menu");
			
		}
		
		
		
	}
}
