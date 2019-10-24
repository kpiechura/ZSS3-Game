
function Update () {
if (Input.GetAxis ("Vertical") > 0.2)
animation.CrossFade ("Chodzenie");
else
animation.CrossFade ("Idle");
}