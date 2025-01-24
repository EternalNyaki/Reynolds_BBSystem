using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

	public class ApplyForce_ACT : ActionTask
	{
		public Vector2 direction;
		public float variance;
		public float force;
		public BBParameter<GameObject> target;

		private Rigidbody _targetRb;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit()
		{
			direction = direction.normalized;
			_targetRb = target.value.GetComponent<Rigidbody>();

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			float angle = Random.Range(-variance, variance) + Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			Vector3 calculatedDirection = new(Mathf.Cos(angle * Mathf.Deg2Rad), 0f, Mathf.Sin(angle * Mathf.Deg2Rad));
			_targetRb.AddForce(calculatedDirection * force);

			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{

		}

		//Called when the task is disabled.
		protected override void OnStop()
		{

		}

		//Called when the task is paused.
		protected override void OnPause()
		{

		}
	}
}