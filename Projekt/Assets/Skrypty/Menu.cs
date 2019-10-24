using UnityEngine; 
using System.Collections; 

public class Menu : MonoBehaviour 
{ 

    //Wymiary przyciskow 
    private int szerokoscPrzycisku = 200; 
    private int wysokoscPrzycisku = 40; 
	

	
	
	public Texture teksturaTla;

    void OnGUI() 
    { 
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height) , teksturaTla);
		
		
		
        //przycisk Nowa Gra
        if(GUI.Button(new Rect(  
                           120 - (szerokoscPrzycisku / 2), 
                            250, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Nowa Gra")) 
		{
			Application .LoadLevel("Pasek £adowania");
			
		}
		
		//przycisk Tworcy
        if(GUI.Button(new Rect(  
                            120 - (szerokoscPrzycisku / 2), 
                            300, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Twórcy"))
			{
			
				Application.LoadLevel ("Tworcy");
			}
		
		
		
		//przycisk Wyjscie
        if(GUI.Button(new Rect(  
                            120 - (szerokoscPrzycisku / 2), 
                            350, 
                            szerokoscPrzycisku, 
                            wysokoscPrzycisku), 
                            "Wyjœcie")) 
		{
			Application.Quit();
		}
		
		 
		
		
		
    } 
}