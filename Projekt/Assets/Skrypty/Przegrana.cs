using UnityEngine; 
using System.Collections; 

public class Przegrana : MonoBehaviour 
{ 

    //Wymiary przyciskow 
    private int szerokoscPrzycisku = 300; 
    private int wysokoscPrzycisku = 40; 
	

	
	
	public Texture teksturaTla;

    void OnGUI() 
    { 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height) , teksturaTla);
		
		
		
        //przycisk Powrót do Menu Głównego
        if(GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            450,
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Powtorz")) 
		{
			Application .LoadLevel("Tekst");
			
		}
		if(GUI.Button(new Rect(  
                            500 - (szerokoscPrzycisku / 10), 
                            495,  
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Wyjscie")) 
		{
			Application .LoadLevel("Menu");
			
		}
		
		
	}
}
