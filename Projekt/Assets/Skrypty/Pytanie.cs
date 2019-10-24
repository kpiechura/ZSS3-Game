using UnityEngine; 


[ExecuteInEditMode] 
public class Pytanie : MonoBehaviour 
{ 
public string pytanie; 
public string[] odpowiedzi = new string[4]; 
public int dobraOdpowiedz; 
private int zaznaczonaOdpowiedz; 

// gdy użytkownik odpowie poprawnie zostanie uruchomiona funkcja o nazwie 
// podanej w zmiennej poni    
public MonoBehaviour odbieraczPoprawnejOdpowiedzi; 
public string funkcjaPoprawnejOdpowiedzi; 

// dla zlej odpowiedzi 
public MonoBehaviour odbieraczZlejOdpowiedzi; 
public string funkcjaZlejOdpowiedzi; 

public Rect ZlaOdpowiedz;
public Rect obszarPytania; 
public Rect obszarOdpowiedzi; 
public Rect obszarPrzycisku; 

void Awake() 
{ 
   enabled = false; 
} 

void OnTriggerEnter(Collider enter) 
{// pytanie jest wyświetlane gdy gracz wejdzie w pytanie 
   if(enter.tag == "Player") 
      enabled = true; 
} 

void OnTriggerExit(Collider exit) 
{//  przestaje być wyświetlane gdy z niego wyjdzie 
   if(exit.tag == "Player") 
      enabled = false; 
} 

void Reset() 
{// ustawia domyślne wartości zmiennych // wywoływany przy dodaniu komponentu do obiektu // wywoływany tylko w edytorze 
   obszarPytania = new Rect(Screen.width * 0.3f, Screen.height * 0.1f, Screen.width * 0.4f, Screen.height * 0.2f); 
   obszarOdpowiedzi = new Rect(Screen.width * 0.1f, Screen.height * 0.4f, Screen.width * 0.8f, Screen.height * 0.4f); 
   obszarPrzycisku = new Rect(Screen.width * 0.4f, Screen.height * 0.85f, Screen.width * 0.2f, Screen.height * 0.1f); 
} 

void OnGUI() 
{ 
   GUI.Box(obszarPytania, pytanie); 
   zaznaczonaOdpowiedz = GUI.SelectionGrid (obszarOdpowiedzi, zaznaczonaOdpowiedz, odpowiedzi, odpowiedzi.Length/2); 
    
   if(GUI.Button(obszarPrzycisku, "OK") && Application.isPlaying) 
   { 
        enabled = false; 
        collider.enabled = false; // wyłącza siebie i kolider żeby nie wyświetlić ponownie tego samego pytania 

        if(dobraOdpowiedz == zaznaczonaOdpowiedz) 
        { 
             if(odbieraczPoprawnejOdpowiedzi) 
                 odbieraczPoprawnejOdpowiedzi.SendMessage(funkcjaPoprawnejOdpowiedzi); 
        } 
        else 
        { 
             if(odbieraczZlejOdpowiedzi) 
                odbieraczZlejOdpowiedzi.SendMessage(funkcjaZlejOdpowiedzi); 
        } 
   } 
} 
}

