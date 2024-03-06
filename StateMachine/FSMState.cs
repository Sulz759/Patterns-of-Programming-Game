namespace StateMachine
{
	public abstract class FSMState
	{
		protected readonly FSM Fsm;

		public FSMState(FSM fsm)
		{
			Fsm = fsm;
		}

		protected FSMState()
		{
			throw new System.NotImplementedException();
		}

		public virtual void Enter() { }
		public virtual void Exit() { }
		public virtual void Update() { }
	}
}