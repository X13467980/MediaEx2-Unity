using System. Collections;
using System. Collections. Generic;
using UnityEngine;
// Camera: https://docs.unity3d.com/ja/current/ScriptReference/Game0bject-camera.html
// GetAxis: https://docs-unity3d.com/ja/current/ScriptReference/Input.GetAxis-html
// fieldofView: https://docs.unity3d.com/ja/current/ScriptReference/Camera-fieldOfView-html
// RotateAround: https://docs.unity3d.com/ja/current/ScriptReference/Transform-Rot at eAround.ht ml
public class CameraController : MonoBehaviour {
public GameObject carPosObj; 
public GameObject cameraObj;
public float dragSpeed = 10f;
public float scrollSpeed = 10f ;
// Update is called once per frame
void Update () {
transform.position = carPosObj.transform.position; //現在位置をcarPos0b」とする
if (Input.GetAxis("Mouse ScrollWheel")!=0){//マウススクロールが回転した場合

cameraObj.GetComponent <Camera> ().fieldOfView = 
cameraObj.GetComponent <Camera> ().fieldOfView -
Input.GetAxis ("Mouse ScrollWheel") *scrollSpeed;
}
if (Input.GetMouseButton(1)){//右クリックが押されたら
//視点方向の変更：carPosobjを中心として、y軸を中心として、※方向に回転
transform.RotateAround (transform.position, Vector3.up, dragSpeed*
Input.GetAxis ("Mouse X"));
//視点方向の変更：carPosObjを中心として、※軸を中心として、※方向に回転
transform. RotateAround (transform.position, transform.right, dragSpeed*
- Input.GetAxis ("Mouse Y"));
}
}
}