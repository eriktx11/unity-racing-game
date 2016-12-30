using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	private Animator _animator;
	private CanvasGroup _canvasGroup;

	public bool isOpen
	{
		get{return _animator.GetBool ("isOpen");}
		set{_animator.SetBool ("isOpen", value);}
	}

	public void Awake(){
		_animator = GetComponent<Animator>();
		_canvasGroup = GetComponent<CanvasGroup>();
//
//		var rect = GetComponent<RectTransform> ();
//		rect.offsetMax = rect.offsetMin - new Vector2 (0,0);
	}
		
	public void Update () {

		if(!_animator.GetCurrentAnimatorStateInfo(0).IsName("on")){
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
		}else{
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
		}
	}
}
