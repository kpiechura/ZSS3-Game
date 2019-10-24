var isQuitButton = false; 
var animacja : AnimationClip; 

function Start() 
{ 
   yield WaitForSeconds(animacja.length); 
   Application.LoadLevel(Application.loadedLevel + 1); 
}

function OnMouseEnter() 
{ 
//zmiana koloru tekstu 
renderer.material.color = Color.black; 
} 

function OnMouseExit() 
{ 
//zmiana koloru tekstu 
renderer.material.color = Color.white; 
} 
function OnMouseUp() 
{ 
//naciœnie przycisk wyjœcie? 
if ( isQuitButton ) 
{ 
//zakoñcz grê 
Application.Quit(); 
} 
else 
{ 
//wczytaj poziom 
Application.LoadLevel(3); 


} 
} 




