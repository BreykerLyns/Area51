static var selectedId : int;
static var speed : int = 5;
 
function Update () { selectedId = GetInstanceID();
    if (selectedId==GetInstanceID()) {
        if (Input.GetKey (KeyCode.UpArrow)) transform.Translate (Vector3(0,1,0) * Time.deltaTime*speed);
        if (Input.GetKey (KeyCode.DownArrow)) transform.Translate (Vector3(0,-1,0) * Time.deltaTime*speed);
        if (Input.GetKey (KeyCode.RightArrow)) transform.Translate (Vector3(1,0,0) * Time.deltaTime*speed);
        if (Input.GetKey (KeyCode.LeftArrow)) transform.Translate (Vector3(-1,0,0) * Time.deltaTime*speed);
    }
}
 
