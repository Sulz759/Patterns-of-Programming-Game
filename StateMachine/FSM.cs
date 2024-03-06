namespace StateMachine
{
	public class FSM
	{
		public FSMState StateCurrent {get;private set;}

		private Dictionary<Type, FSMState> _states = new Dictionary<Type, FSMState>();

		public void AddState(FSMState state) 
		{
			_states.Add(state.GetType(), state);
		}

		public void SetState<T>() where T : FSMState 
		{
			var type = typeof(T);

			if (StateCurrent != null && StateCurrent.GetType() == type) 
			{
				return;
			}

			if (_states.TryGetValue(type, out var newState)) 
			{
				StateCurrent?.Exit();

				StateCurrent = newState;

				StateCurrent.Enter();
			}
		}

		public void Update() 
		{ 
			StateCurrent?.Update();
		}
	}

}